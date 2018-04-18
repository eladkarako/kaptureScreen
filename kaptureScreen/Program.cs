using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace kaptureScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenCapture sc = new ScreenCapture();

            // capture entire screen, and save it to a file
            string sFileName = string.Format("screenshot-{0:hh-mm-ss_dd-MM-yyyy}.jpg",DateTime.Now);
            sc.CaptureScreenToFile(@"C:\wamp\www\screenshots\" + sFileName, ImageFormat.Jpeg);
        }
    }
}
