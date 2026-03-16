using System.Diagnostics;

namespace PythonOpeningTool
{
    public partial class PythonOpeningTool : Form
    {
        private string file;
        private string vsPath;
        public PythonOpeningTool(string fileArg, string vsPathArg)
        {
            InitializeComponent();
            this.file = fileArg;
            this.vsPath = vsPathArg;
        }

        private void vsCodeButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo vsCodePSI = new ProcessStartInfo
            {
                FileName = "code",
                Arguments = $"\"{this.file}\"",
                UseShellExecute = true
            };

            Process.Start(vsCodePSI);
            this.Close();
        }

        private void vsButton_Click(object sender, EventArgs e)
        {
            Process.Start(vsPath, this.file);
            this.Close();
        }

        private void pythonButton_Click(object sender, EventArgs e)
        {
            Process.Start("python", this.file);
            this.Close();
        }
    }
}
