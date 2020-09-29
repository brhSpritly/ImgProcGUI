/****************************************************************************** 
** @Filename: 	CGaussFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** Abbildung des Gauss Filter (Tiefpassfilter) zur Bildglaettung (Beseitigung
** von Stoerungen im Bild wie zB Rauschen). 
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imgProc
{
   class CGaussFilter :CMaskFilter {
      /// <summary> Konstruktoren  /// </summary>
      /// <param name="size">Filtermaskengroesse</param>
      public CGaussFilter(int size) : base( size ) { }
      public CGaussFilter() : base() { }
      /// <summary>initMask
      /// Initialisierung der Filtermaske mit Werten
      /// </summary>
      /// <returns>true(Maske kann verwendet werden)</returns>
      override protected bool initMask() {
         this.mask = new int[3, 3];
         // Gauss maske:
         // 1 2 1
         // 2 4 2
         // 1 2 1
         try {
            this.mask[0, 0] = 1;
            this.mask[0, 1] = 2;
            this.mask[0, 2] = 1;
            this.mask[1, 0] = 2;
            this.mask[1, 1] = 4;
            this.mask[1, 2] = 2;
            this.mask[2, 0] = 1;
            this.mask[2, 1] = 2;
            this.mask[2, 2] = 1;
         } catch {
            return false;
         }
         // zum normalisieren:
         int sum = 0;
         foreach( int val in this.mask)
            sum += val;
         this.NormFactor = sum;
         return true;
      }
   }
}
