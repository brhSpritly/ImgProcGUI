/****************************************************************************** 
** @Filename: 	CMaskFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** CMaskFilter ist eine abstrakte Klasse fuer Filter, die eine gewichtete Maske
** zur Faltung benutzen.
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace imgProc {
   /// <summary> abstracte Filter-Klasse, nur zum Ableiten </summary>
   public abstract class CMaskFilter : CFilter {
      protected int[,] mask; // Filtermaske
      protected int normFactor; // zum normalisieren, falls benoetigt
      /// <summary> checkRange
      /// Es wird ueberprueft, ob der uebergebene Wert im Bereich 0..255
      /// liegt.
      /// </summary>
      /// <param name="val">zu pruefender wert</param>
      /// <returns>Der Wert im Bereich, anderenfalls 0 oder 255</returns>
      private int checkRange(int val) {
         return val > 255 ? 255 : (val < 0 ? 0 : val);
      }
      /// <summary> Konstruktoren
      /// *die Masken werden initialisiert u. ggf. mit den entsprechenden 
      ///  Werten gefuellt
      /// *der Normalisierungswert wird festgelegt
      /// </summary>
      public CMaskFilter() {
         mask = null;
         this.normFactor = 1;
         this.initMask();
      }
      public CMaskFilter(int filterSizeZ, int filterSizeS) {
         this.mask = new int[filterSizeZ, filterSizeS];
         this.normFactor = 1;
         this.initMask();
      }
      public CMaskFilter(int size) : this(size, size) { }
      /// <summary>initMask
      /// in dieser Fkt werden die Maskenelemente definiert
      /// initMask muss von allen abgeleiteten Klassen implementiert werden!      /// 
      /// </summary>
      /// <returns>true(maske kann verwendet werde)/false</returns> 
      abstract protected bool initMask();
      /// <summary> Run 
      /// Diese Fkt fuehrt die Filterung des Bildes mit der Maske durch </summary>
      /// <param name="inImg">Bild, das gefiltert werden soll</param>
      /// <returns>gefiltertes Bild oder 'null' im Fehlerfall</returns>
      override public Bitmap Run(Bitmap inImg) {
         if (inImg == null)
            return null;
         Bitmap outImg = new Bitmap(inImg.Width, inImg.Height);
         int maskSizeZ = mask.GetLength(0);
         int maskSizeS = mask.GetLength(1);
         Color colVal; // akt. Pixelwert
         int mz, ms,
             sumR = 0, sumG = 0, sumB = 0; // summe der rot/gruen u. Blauwerte
                                           // unterhalb der Maske
         if (maskSizeS == 0 || maskSizeZ == 0 || inImg == null)
            // Fehler: keine Filtermaske festgelegt
            return null;
         try {
            for (int z = maskSizeZ / 2; z < inImg.Height - maskSizeZ / 2; z++) {
               for (int s = maskSizeS / 2; s < inImg.Width - maskSizeS / 2; s++) {
                  // Maske ueber das akt. Pixel legen und durch Faltung
                  // den Wert des Pixels im neuen Bild ermitteln
                  mz = 0;
                  for (int k = -(maskSizeZ / 2); k <= maskSizeZ / 2; k++) {
                     ms = 0;
                     for (int p = -(maskSizeS / 2); p <= maskSizeS / 2; p++) {
                        if (mask[mz, ms] == 0) {
                           // aus zeitgruenden..
                           ms++;
                           continue;
                        }
                        colVal = inImg.GetPixel(s + p, z + k);
                        sumR += colVal.R * mask[mz, ms];
                        sumG += colVal.G * mask[mz, ms];
                        sumB += colVal.B * mask[mz, ms];
                        ms++;
                     }
                     mz++;
                  }
                  sumR = checkRange(sumR / this.normFactor);
                  sumG = checkRange(sumG / this.normFactor);
                  sumB = checkRange(sumB / this.normFactor);
                  colVal = Color.FromArgb(sumR, sumG, sumB);
                  outImg.SetPixel(s, z, colVal); // Pixelwert im neuen Bild
                  sumR = sumG = sumB = 0;
               }
            } // for zeilen
         }
         catch {
            return null;
         }
         return outImg;
      } // Run
      public override string ToString() {
         string maskStr = "";
         try {
            foreach (int val in this.mask)
               maskStr += val + ";";

         }
         catch {
            return null;
         }
         return maskStr;
      }
      public int[,] Mask {
         get {
            return this.mask;
         }
         set {
            this.mask = value;
         }
      }//get, set Mask
      public int NormFactor {
         get {
            return this.normFactor;
         }
         set {
            this.normFactor = value;
         }
      }
   }
}
