using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;

namespace TextEditor
{
    class MultiSDIApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        static MultiSDIApplication application;
        internal static MultiSDIApplication Application
        {
            get
            {
                if (application == null)
                {
                    application = new MultiSDIApplication();
                }
                return application;
            }
        }
        public MultiSDIApplication()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        protected override void OnCreateMainForm()
        {
             this.MainForm = this.CreateTopLevelWindow(this.CommandLineArgs);
        }

        mainForm CreateTopLevelWindow(ReadOnlyCollection<string> args)
        {
            string fileName = (args.Count > 0 ? args[0] : null);
            return mainForm.CreateTopLevelWindow(fileName);
        }

    }
}
