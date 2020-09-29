/****************************************************************************** 
** @Filename: 	CSobelFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** Abbildung des Sobel Filter (Hochpassfilter) zur Kantendetektion. 
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imgProc {
   public class CSobelFilter : CMaskFilter {
      public CSobelFilter(int size) : base(size) { }
      public CSobelFilter() : base() { }
      override protected bool initMask() {
         this.mask = new int[3, 3];
         // maske:
         // -1 0  1
         // -2 0  2
         // -1 0  1
         try {
            this.mask[0, 0] = -1;
            this.mask[0, 1] = 0;
            this.mask[0, 2] = 1;
            this.mask[1, 0] = -2;
            this.mask[1, 1] = 0;
            this.mask[1, 2] = 2;
            this.mask[2, 0] = -1;
            this.mask[2, 1] = 0;
            this.mask[2, 2] = 1;
         }
         catch {
            return false;
         }
         return true;
      }
   }
}
