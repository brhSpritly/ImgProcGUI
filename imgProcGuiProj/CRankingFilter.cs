/****************************************************************************** 
** @Filename: 	CRankingFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** CMaskFilter ist eine abstrakte Klasse fuer Rangordnungsfilter fuer
** ungewichtete quadratische Filtermasken
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace imgProc
{
   abstract class CRankingFilter :CFilter{
      protected int maskSize; // Maskengroesse (zb maskSize = 3 fuer 3x3 Maske)
      /// <summary>Run
      /// Diese Fkt fuehrt die Filterung des Bildes durch </summary>
      /// <param name="inImg">Bild, das gefiltert werden soll</param>
      /// <returns>gefiltertes Bild oder 'null' im Fehlerfall</returns>
      abstract override public Bitmap Run(Bitmap inImg);
      /// <summary> Konstruktor/// </summary>      
      /// <param name="size">Maskengroesse, nur ungerade werden akzeptiert</param>
      public CRankingFilter(int size) {
         if(size % 2 == 0)
            size += 1;
         this.maskSize = size;
      }
   }
}
