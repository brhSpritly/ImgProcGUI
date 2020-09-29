/****************************************************************************** 
** @Filename: 	CMedianFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** Das Median Filter (Tiefpassfilter) wird zur Bildglaettung (Beseitigung
** von Stoerungen im Bild wie zB Rauschen) verwendet. 
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace imgProc
{
   class CMedianFilter : CRankingFilter {
      public CMedianFilter(int size) : base( size ) { }
      /// <summary>Run
      /// Filterung des Bildes. Die Werte unterhalb der Maske werden sortiert
      /// und der mittelste Wert wird als neuer Pixelwert verwendet
      /// </summary>
      /// <param name="inImg">zu filterndes Bild</param>
      /// <returns>kopie des Eingangsbildes, 
      /// auf dem der Filter angewandt wurde</returns>
      override public Bitmap Run(Bitmap inImg) {
         Bitmap outImg = new Bitmap( inImg.Width, inImg.Height);
         // Listen mit den Farbwerten unterhalb der Maske
         ArrayList arListR = new ArrayList(); 
         ArrayList arListG = new ArrayList(); 
         ArrayList arListB = new ArrayList();

         // mittlerer Wert der sortierten Maske (entsprechend der Farbe)
         byte midValR, midValG, midValB = 0; 
         Color colVal; // akt. Pixelwert
         #region //Filterung
         try {
            for(int z = this.maskSize / 2; z < inImg.Height - this.maskSize / 2; z++) {
               for(int s = this.maskSize / 2; s < inImg.Width - this.maskSize / 2; s++) {
                  for(int mz = -(this.maskSize / 2); mz <= (this.maskSize / 2); mz++) {
                     for(int ms = -(this.maskSize / 2); ms <= (this.maskSize / 2); ms++) {
                        colVal = inImg.GetPixel( s + ms, z + mz );
                        arListR.Add( colVal.R  );
                        arListG.Add( colVal.G );
                        arListB.Add( colVal.B );
                     }
                  }
                  arListR.Sort();
                  arListG.Sort();
                  arListB.Sort();
                  midValR = (byte)arListR[maskSize * maskSize / 2 + 1];
                  midValG = (byte)arListG[maskSize * maskSize / 2 + 1];
                  midValB = (byte)arListB[maskSize * maskSize / 2 + 1];
                  colVal = Color.FromArgb( midValR, midValG, midValB );
                  outImg.SetPixel( s, z, colVal );
                  arListR.Clear();
                  arListG.Clear();
                  arListB.Clear();
               }
            } // for zeilen
         } catch{
            return null;
         }
         #endregion //Filterung
         return outImg;
      }
   }
}
