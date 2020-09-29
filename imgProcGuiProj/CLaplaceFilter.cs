/****************************************************************************** 
** @Filename: 	CLaplaceFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** Abbildung des Laplace Filter (Hochpassfilter) zur Kantendetektion. 
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imgProc
{
   class CLaplaceFilter : CMaskFilter{
      public CLaplaceFilter(int size) : base( size ) {
         //base.normFactor = 9; // Divisor fuer die Maske
      }
      public CLaplaceFilter() : base() { }
      override protected bool initMask() {
         this.mask = new int[3, 3];
         //base.normFactor = 9;
         // Laplacemaske:
         // -1  -2  -1
         // -2  12  -2
         // -1  -2  -1
         try {
            this.mask[0, 0] = -1;
            this.mask[0, 1] = -2;
            this.mask[0, 2] = -1;
            this.mask[1, 0] = -2;
            this.mask[1, 1] = 12;
            this.mask[1, 2] = -2;
            this.mask[2, 0] = -1;
            this.mask[2, 1] = -2;
            this.mask[2, 2] = -1;
         } catch {
            return false;
         }
         return true;
      }
   }
}
