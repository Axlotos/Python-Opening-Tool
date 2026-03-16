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

            string file = args[0];


            // Get the Folder Fhere this .exe is Located
            string exeFolder = AppContext.BaseDirectory;

            // Combine the Folder Path With the File Name for the Visual Studio Path
            string vsPathFilePath = Path.Combine(exeFolder, "visualStudioPath.txt");

            // Combine the Folder Path With the File Name for the Theme
            string themeTxtPath = Path.Combine(exeFolder, "theme.txt");

            // Read the Visual Studio Path Text File and Save it as a Variable
            string vsPath = File.ReadAllText(vsPathFilePath);

            // Read the Theme Text File and Save it as a Variable
            string theme = File.ReadAllText(themeTxtPath);

            // Start the Main Script
            ApplicationConfiguration.Initialize();
            Application.Run(new PythonOpeningTool(file, vsPath, theme, themeTxtPath));
        }
    }
}