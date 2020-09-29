/****************************************************************************** 
** @Filename: 	CFilter.cs
** @Project: 	"Bildbearbeitung"
** @author:    B.Hentzschel 
** @copyright: 2009-03-03
** 
** CFilter ist eine abstrakte Klasse, von der alle Filter erben.
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace imgProc {
  public abstract class CFilter {
    /// <summary> Run(..) wendet einen Filter auf das uebergebene Bild an </summary>
    /// <param name="inImg"> Bild, das gefiltert werden soll</param>
    /// <returns>gefiltertes Bild</returns>
    abstract public Bitmap Run(Bitmap inImg);
  }
}
