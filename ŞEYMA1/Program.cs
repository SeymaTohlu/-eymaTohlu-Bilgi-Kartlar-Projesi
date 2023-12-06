using System;
using System.IO;
using OfficeOpenXml;

namespace ŞEYMA1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}


