using System.IO;

namespace PythonOpeningTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                MessageBox.Show("This program is designed only to be used to open Python source files");
                return;
            }

            // Get the Folder Where this .exe is Located
            string exeFolder = AppContext.BaseDirectory;

            // Combine the Folder Path With the File Name for the Visual Studio Path
            string vsPathTxtPath = Path.Combine(exeFolder, "visualStudioPath.txt");

            // Combine the Folder Path With the File Name for the Theme
            string themeTxtPath = Path.Combine(exeFolder, "theme.txt");

            // Combine the Folder Path With the File Name for the Custom App Path
            string customAppTxtPath = Path.Combine(exeFolder, "customAppPath.txt");

            if (!File.Exists(vsPathTxtPath))
            {
                MessageBox.Show("There is no visualStudioPath.txt in the directrory of the Python Opening Tool executable");
                return;
            }

            if (!File.Exists(themeTxtPath))
            {
                MessageBox.Show("There is no theme.txt in the directrory of the Python Opening Tool executable");
                return;
            }

            if (!File.Exists(customAppTxtPath))
            {
                MessageBox.Show("There is no customAppPath.txt in the directrory of the Python Opening Tool executable");
                return;
            }

            // Read the Visual Studio Path Text File and Save it as a Variable
            string vsPath = File.ReadAllText(vsPathTxtPath);

            // Read the Theme Text File and Save it as a Variable
            string theme = File.ReadAllText(themeTxtPath);

            // Read the Custom App Text File and Save it as a Variable
            string customApp = File.ReadAllText(customAppTxtPath);


            string file = args[0];

            // Start the Main Script
            ApplicationConfiguration.Initialize();
            Application.Run(new PythonOpeningTool(file, vsPath, theme, themeTxtPath, customApp, customAppTxtPath));
        }
    }
}