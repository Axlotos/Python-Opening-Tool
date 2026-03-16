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


            // Get the folder where this .exe is located
            string exeFolder = AppContext.BaseDirectory;
            
            // Safely combine the folder path with the file name
            string txtFilePath = Path.Combine(exeFolder, "visualStudioPath.txt");
            
            // Read the text file from that specific location
            string vsPath = File.ReadAllText(txtFilePath);

            ApplicationConfiguration.Initialize();
            Application.Run(new PythonOpeningTool(file, vsPath));
        }
    }
}