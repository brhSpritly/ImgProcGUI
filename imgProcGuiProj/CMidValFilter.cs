/****************************************************************************** 
** @Filename: 	CMidValFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** Der Mittelwert-Operator (Tiefpassfilter) wird zur Bildglaettung (Beseitigung
** von Stoerungen im Bild wie zB Rauschen) verwendet. 
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace imgProc
{
   class CMidValFilter : CRankingFilter {
      public CMidValFilter(int size) : base( size ) { }
      /// <summary>Run
      /// Filterung des Bildes. Die Werte unterhalb der Maske werden addiert
      /// und die Summe durch die Anz der Maskenkoeffizienten dividiert
      /// </summary>
      /// <param name="inImg">zu filterndes Bild</param>
      /// <returns>kopie des Eingangsbildes, 
      /// auf dem der Filter angewandt wurde</returns>
      override public Bitmap Run(Bitmap inImg) {
         Bitmap outImg = new Bitmap( inImg.Width, inImg.Height );
         int midValR =0, midValG=0, midValB = 0; // mittelwerte
         Color colVal; // akt Pixelwert
         #region //Filterung
         try {
            for(int z = this.maskSize / 2; z < inImg.Height - this.maskSize / 2; z++) {
               for(int s = this.maskSize / 2; s < inImg.Width - this.maskSize / 2; s++) {
                  for(int mz = -(this.maskSize / 2); mz <= (this.maskSize / 2); mz++) {
                     for(int ms = -(this.maskSize / 2); ms <= (this.maskSize / 2); ms++) {
                        colVal = inImg.GetPixel( s + ms, z + mz );
                        midValR += colVal.R;
                        midValG += colVal.G;
                        midValB += colVal.B;
                     }
                  }
                  midValR = midValR / (maskSize * maskSize);
                  midValG = midValG / (maskSize * maskSize);
                  midValB = midValB / (maskSize * maskSize);

                  colVal = Color.FromArgb( midValR, midValG, midValB );
                  outImg.SetPixel( s, z, colVal );
                  midValR = midValG = midValB = 0;
               }
            } // for zeilen
         } catch {
            return null;
         }
         #endregion //Filterung
         return outImg;
      }
   }
}
