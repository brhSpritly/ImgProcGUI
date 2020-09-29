using System;
using Xunit;
using imgProc;
using System.Drawing;

namespace ImgProcGUI.test {
   public class UnitTestSobel {
      imgProc.CSobelFilter filter = new imgProc.CSobelFilter();
      [Fact]
      public void TestRunFkt() {
         Bitmap inImg = new Bitmap("d:/eigene_daten_2020/programmieren/cSharp/UnitTest/sobeltest/leiterplatteGW_inImg.bmp");
         Assert.NotNull(inImg);
         Bitmap outImg = null;
         outImg = filter.Run(inImg);
         Assert.NotNull(outImg);
         Assert.Equal(inImg.Width, outImg.Width);
         Assert.Equal(inImg.Height, outImg.Height);
      }
   }
}
