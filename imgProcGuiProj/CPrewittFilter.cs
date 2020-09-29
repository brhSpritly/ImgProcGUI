/****************************************************************************** 
** @Filename: 	CPrewittFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** Abbildung des Prewitt Filter (Hochpassfilter) zur Kantendetektion. 
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imgProc
{
   class CPrewittFilter :CMaskFilter{
      public CPrewittFilter(int size) : base( size ) { }
      public CPrewittFilter() : base() { }
      override protected bool initMask() {
         this.mask = new int[3, 3];
         // Prewitt maske:
         // -1 0 1
         // -1 0 1
         // -1 0 1 
         try {
            this.mask[0, 0] = -1;
            this.mask[0, 1] = 0;
            this.mask[0, 2] = 1;
            this.mask[1, 0] = -1;
            this.mask[1, 1] = 0;
            this.mask[1, 2] = 1;
            this.mask[2, 0] = -1;
            this.mask[2, 1] = 0;
            this.mask[2, 2] = 1;
         } catch {
            return false;
         }
         return true;
      }
   }
}
