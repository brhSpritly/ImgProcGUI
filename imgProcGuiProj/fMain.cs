/****************************************************************************** 
** @Filename: 	fMain.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** fMain ist das Hauptformular (GUI) des Programmes.
******************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace imgProc {
   public partial class fMain : Form {
      Bitmap orgImg, // geladenes Bild
             inImg,  // Eingangsbild fuer die Bildbearbeitung
             outImg; // Ergebnisbild
                     // Auflistung von Bildformaten
      private enum pixelformatInImg { UNKNOWN_FORMAT, COLOR_FORMAT, GREY_FORMAT, BINAER_FORMAT };
      // Auflistung der Kantenfilter, die im Programm verwendet werden
      private enum edgeFilterTyp { Sobel = 0, Prewitt = 1, Laplace = 2 };
      // Auflistung der Glaettungsfilter, die im Prg verwendet werden
      private enum smoothFilterTyp { Median = 0, Gauss = 1, Mittelwert = 2 };
      // es wird entsprehend der GUI Auswahl bestimmt, welche von Filter  
      // abgeleitete Klasse aufgerufen wird
      CFilter currFilter; // akt. Filter
      public fMain() {
         InitializeComponent();
         init();
      }
      /// <summary>init
      /// Initialisierung der Gui elemente
      /// </summary>
      /// <returns>true/false</returns>
      private bool init() {
         cbMaskSize.SelectedIndex = 0;
         fillEdgeFilterTypBox(); // Auswahl der Kantenfilter anlegen
         fillSmoothFilterTypBox();// Auswahl der Glaettungsfilter anlegen
         setProgressBarOn(false); //Anzeige in der Statusleiste loeschen
         return true;
      }
      /// <summary>loadImg
      /// Laden eines Bildes ueber Dateiauswahldialog
      /// </summary>
      /// <returns>true(Bild wurde geladen)/false</returns>
      private bool loadImg() {
         // Dialog zum laden des bildes
         loadImgDialog.Filter = "Bilddatei|*.bmp"; // nur bmp's zulassen
         try {
            if (loadImgDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
               orgImg = new Bitmap(loadImgDialog.FileName);
               inImg = orgImg;
            }
            return inImg != null ? true : false;
         }
         catch {
            return false;
         }
      } // LoadImg
      /// <summary>saveImg
      /// Speicherung des uebergebenen Bildes als bmp mittels Dialog
      /// </summary>
      /// <param name="img">zu speicherndes Bild</param>
      /// <returns>true(Bild wurde gespeichert)/false</returns>
      private bool saveImg(Image img) {
         saveImgDialog.Filter = "Bilddatei|*.bmp"; // nur bmp's zulassen
         try {
            if (saveImgDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
               img.Save(saveImgDialog.FileName);
            }
         }
         catch {
            return false;
         }
         return true;
      }
      /// <summary>setProgressBarOn
      /// Statusanzeige zur Bearbeitung des Bildes setzen
      /// </summary>
      /// <param name="setOn">true-Text zur Bearbeitung des Bildes wird
      /// angezeigt, false-keine Textanzeige</param>
      private void setProgressBarOn(bool setOn) {
         if (setOn) {
            statusBarLabel.Text = "Bild wird bearbeitet, bitte warten...";
            Color col = statusBarLabel.BackColor;
            statusBarLabel.BackColor = Color.Yellow;
         }
         else {
            statusBarLabel.Text = "";
            statusBarLabel.BackColor = SystemColors.MenuBar;
         }
         statusBar.Refresh();
      }
      /// <summary>showInImg
      /// Anzeige des Eingangsbildes in GUI
      /// </summary>
      /// <returns>true/false</returns>
      private bool showInImg() {
         picBoxInImg.Image = inImg;
         return true;
      }
      /// <summary>showOutImg
      /// Anzeige des Ergebnisbildes in GUI
      /// </summary>
      /// <returns>true/false</returns>
      private bool showOutImg() {
         picBoxResImg.Image = outImg;
         picBoxResImg.Refresh();
         return true;
      }
      /// <summary>fillEdgeFilterTypBox
      /// Auswahl der Kantenfilter anlegen
      /// </summary>
      private void fillEdgeFilterTypBox() {
         foreach (string filter in Enum.GetNames(typeof(edgeFilterTyp))) {
            cbEdgeFilter.Items.Add(filter);
         }
         cbEdgeFilter.SelectedIndex = 0;
      }
      /// <summary>fillSmoothFilterTypBox
      /// Auswahl der Glaettungsfilter anlegen
      /// </summary>
      private void fillSmoothFilterTypBox() {
         foreach (string filter in Enum.GetNames(typeof(smoothFilterTyp))) {
            cbSmoothFilter.Items.Add(filter);
         }
         cbSmoothFilter.SelectedIndex = 0;
      }
      /// <summary> calcAndShowEdgeImg
      /// Berechnung des Kantenbildes anhand des ausgewaehlten Filters
      /// </summary>
      /// <returns>true-Bild wurde gefiltert und angezeigt in GUI</returns>
      private bool calcAndShowEdgeImg() {
         setProgressBarOn(true); // Anzeige in Statusleiste, das BV laeuft         
         outImg = null;
         showOutImg(); // altes ergbild loeschen
                       // ermittle den gewaehlten Filter:
         switch (cbEdgeFilter.SelectedIndex) {
            case (int)edgeFilterTyp.Laplace:
               currFilter = new CLaplaceFilter();
               break;
            case (int)edgeFilterTyp.Prewitt:
               currFilter = new CPrewittFilter();
               break;
            case (int)edgeFilterTyp.Sobel:
               currFilter = new CSobelFilter();
               break;
            default:
               setProgressBarOn(false);
               return false;
         } // switch
         outImg = currFilter.Run(inImg); // Filterung
         showOutImg(); // neues Ergbild anzeigen
         setProgressBarOn(false);
         return true;
      }
      /// <summary> calcAndShowSmoothImg
      /// Berechnung des Glaettungsbildes anhand des ausgewaehlten Filters
      /// </summary>
      /// <returns>true-Bild wurde gefiltert und angezeigt in GUI</returns>
      private bool calcAndShowSmoothImg() {
         outImg = null;
         showOutImg(); // altes ergbild loeschen
                       // ermittle den gewaehlten Filter:
         switch (cbSmoothFilter.SelectedIndex) {
            case (int)smoothFilterTyp.Median:
               currFilter = new CMedianFilter(
                                 int.Parse(cbMaskSize.SelectedItem.ToString()));
               break;
            case (int)smoothFilterTyp.Gauss:
               currFilter = new CGaussFilter(
                                 int.Parse(cbMaskSize.SelectedItem.ToString()));
               break;
            case (int)smoothFilterTyp.Mittelwert:
               currFilter = new CMidValFilter(
                                 int.Parse(cbMaskSize.SelectedItem.ToString()));
               break;
            default:
               return false;
         } // switch
         outImg = currFilter.Run(inImg);
         showOutImg(); // neues Ergbild anzeigen
         return true;
      }
      /// <summary> colorToBin
      /// wandelt ein farb/gwBild in binaerbild um
      /// </summary>
      /// <param name="oldImg">Bild, von dem das Binaerbild erstellt werden soll</param>
      /// <param name="thresh">Schwellwert</param>
      /// <returns>Binarisiertes Bild</returns>
      private Bitmap colorToBin(Bitmap oldImg, int thresh) {
         Bitmap newImg = new Bitmap(oldImg.Width, oldImg.Height, PixelFormat.Format1bppIndexed);
         Color col;
         for (int z = 0; z < oldImg.Height; z++) {
            for (int s = 0; s < oldImg.Width; s++) {
               col = oldImg.GetPixel(s, z);
               int gray = (col.R + col.G + col.B) / 3;
               if (gray > thresh)
                  newImg.SetPixel(s, z, Color.White);
               else
                  newImg.SetPixel(s, z, Color.Black);
            }
         }
         return newImg;
      }
      /// <summary>BitmapTo1Bpp(..)
      /// liefert vom uebergebenen Bild das binaerbild. Der zweite Para
      /// ist die Schwelle zum Binarisieren des Bildes.
      /// </summary>
      /// <param name="img">GW oder Farbbild das binarisiert werden soll.</param>
      /// <param name="tresh">Schwelle zum Binarisieren (0.0-1.0 Helligkeitswerte)</param>
      /// <returns>binarisiertes Eingangsbild</returns>
      public Bitmap BitmapTo1Bpp(Bitmap img, double thresh) {
         // Breite und Hoehe des Eingangsbildes
         try {
            int wImg = img.Width;
            int hImg = img.Height;
            int newGrayVal;

            if ((thresh > 255) || (thresh < 0) || (img == null))
               // falscher Schwellwert, oder kein Eingangsbild
               return null;
            System.Drawing.Imaging.PixelFormat pixformat = img.PixelFormat;
            //Bitmap bmp = new Bitmap(wImg, hImg, PixelFormat.Format1bppIndexed);
            Bitmap newBmp = img.Clone(new Rectangle(0, 0, wImg, hImg), PixelFormat.Format24bppRgb);
            // Binarisierungs-Alg:
            for (int z = 0; z < hImg; z++) {
               for (int s = 0; s < wImg; s++) {
                  Color c = img.GetPixel(s, z);
                  newGrayVal = (c.R + c.G + c.B) / 3;
                  if (newGrayVal >= tbBinThresh.Value) {
                     newBmp.SetPixel(s, z, Color.White);
                  }
                  else {
                     newBmp.SetPixel(s, z, Color.Black);
                  }
               }
            }
            return newBmp;
         }
         catch (Exception e) {
            MessageBox.Show("Error in BitmapTo1Bpp()" + e.Message);
            return null;
         }

      }
      /// <summary>liefert vom uebergebenen Farbbild das GW Bild zurueck </summary>
      /// <param name="oldImg">Farbbild</param>
      /// <returns>GWbild, oder im Fehlerfall: 'null'</returns>
      private Bitmap colorToGray(Bitmap oldImg) {
         if (oldImg == null)
            // kein Eingangsbild
            return null;
         Bitmap newImg = new Bitmap(oldImg);
         Graphics g = Graphics.FromImage(newImg);

         ColorMatrix cm = new ColorMatrix(new float[][]{
                                  new float[]{0.3f,0.3f,0.3f,0,0},
                                  new float[]{0.59f,0.59f,0.59f,0,0},
                                  new float[]{0.11f,0.11f,0.11f,0,0},
                                  new float[]{0,0,0,1,0,0},
                                  new float[]{0,0,0,0,1,0},
                                  new float[]{0,0,0,0,0,1}});

         ImageAttributes ia = new ImageAttributes();
         ia.SetColorMatrix(cm);
         try {
            g.DrawImage(newImg, new Rectangle(0, 0, newImg.Width, newImg.Height), 0, 0,
                        newImg.Width, newImg.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
         }
         catch {
            return null;
         }
         return newImg;
      } // colorToGray
      /// <summary>
      /// liest den Schwellwert aus GUI und wandelt ihn in den Bereich 0.0 bis 1.0 um
      /// </summary>
      /// <returns>im Fehlerfall: - 1.0, sonst Schwellwert: zw. 0.0 und 1.0</returns>
      private double getBinThresh() {
         double retVal = -1.0;
         int tbVal = tbBinThresh.Value;
         // Umrechnung auf Skala 0.0 - 1.0
         retVal = tbVal / 100.0;
         return retVal;
      }
      /// <summary> getBinInImg
      /// binarisiert das Eingangsbild
      /// </summary>
      /// <returns>binarisiertes bild</returns>
      private Bitmap getBinInImg() {
         // Auslesen des in Gui eingestellten Schwellwertes:
         double thresh = getBinThresh();
         // binaerbild erzeugen und als Eingangsbild setzen:
         Bitmap img = BitmapTo1Bpp(inImg, thresh);
         return img;
      }

      //***********************************************************************
      private void btLoadImg_Click(object sender, EventArgs e) {
         if (loadImg()) {
            showInImg();
            outImg = null;
            showOutImg();
         }
         else
            MessageBox.Show("Fehler beim Laden des Bildes");
      }
      private void btClose_Click(object sender, EventArgs e) {
         Close();
      }
      private void File_SaveResImg_Click(object sender, EventArgs e) {
         if (!saveImg(outImg))
            MessageBox.Show("Fehler beim Speichern des Bildes!");
      }
      private void File_Close_Click(object sender, EventArgs e) {
         Close();
      }
      private void btCalcEdgeFilter_Click(object sender, EventArgs e) {
         if (!calcAndShowEdgeImg())
            MessageBox.Show("Fehler bei der Berechnung des Bildes!");
      }
      private void btCalcSmoothFilter_Click(object sender, EventArgs e) {
         if (!calcAndShowSmoothImg())
            MessageBox.Show("Fehler bei der Berechnung des Bildes!");
      }

      private void picBoxInImg_Click(object sender, EventArgs e) {
      }

      private void tbBinThresh_Scroll(object sender, EventArgs e) {
         if (cbBinInImg.Checked) {
            Bitmap img = getBinInImg();
            if (img == null)
               MessageBox.Show("Fehler beim Binarisieren des Eingangsbildes!");
            else {
               outImg = img;
               showOutImg();
            }
         }
         else {
            inImg = orgImg;
            showInImg();
         }
      }

      private void fMain_Load(object sender, EventArgs e) {

      }

      private void statusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {


      }

      private void cbBinInImg_CheckedChanged(object sender, EventArgs e) {
         if (cbBinInImg.Checked) {
            Bitmap img = getBinInImg();
            if (img == null)
               MessageBox.Show("Fehler beim Binarisieren des Eingangsbildes!");
            else {
               outImg = img;
               showOutImg();
            }
         }
         else {
            inImg = orgImg;
            showInImg();
         }
      }
   }
}
