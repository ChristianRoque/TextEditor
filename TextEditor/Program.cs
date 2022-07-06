using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace TextEditor
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            MultiSDIApplication.Application.Run(args);
        }
    }
}