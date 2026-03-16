using System.Diagnostics;
using System.IO;

namespace PythonOpeningTool
{
    public partial class PythonOpeningTool : Form
    {
        private string file;
        private string vsPath;
        private string theme;
        public PythonOpeningTool(string fileArg, string vsPathArg, string themeArg)
        {
            InitializeComponent();
            this.file = fileArg;
            this.vsPath = vsPathArg;
            this.theme = themeArg;

            // Colour Borders
            vsCodeButton.FlatStyle = FlatStyle.Flat;
            vsCodeButton.FlatAppearance.BorderColor = Color.Gray;
            vsButton.FlatStyle = FlatStyle.Flat;
            vsButton.FlatAppearance.BorderColor = Color.Gray;
            pythonButton.FlatStyle = FlatStyle.Flat;
            pythonButton.FlatAppearance.BorderColor = Color.Gray;

            // Set Theme Based on Variable
            if (this.theme == "dark")
            {
                this.BackColor = Color.Black;
                label.BackColor = Color.Black; label.ForeColor = Color.White; // Label
                vsCodeButton.BackColor = Color.Black; vsCodeButton.ForeColor = Color.White; // VS Code Button
                vsButton.BackColor = Color.Black; vsButton.ForeColor = Color.White; // Visual Studio Button
                pythonButton.BackColor = Color.Black; pythonButton.ForeColor = Color.White; // Run Button
                themeToggle.BackColor = Color.Black; themeToggle.ForeColor = Color.White; // Theme Domain Up Down
            }

            else
            {
                this.BackColor = Color.White;
                label.BackColor = Color.White; label.ForeColor = Color.Black;  // Label
                vsCodeButton.BackColor = Color.White; vsCodeButton.ForeColor = Color.Black; // VS Code Button
                vsButton.BackColor = Color.White; vsButton.ForeColor = Color.Black; // Visual Studio Button
                pythonButton.BackColor = Color.White; pythonButton.ForeColor = Color.Black; // Run Button
                themeToggle.BackColor = Color.White; themeToggle.ForeColor = Color.Black; // Theme Domain Up Down
            }
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

        private void themeToggle_SelectedItemChanged(object sender, EventArgs e)
        {
            // Update Colours
            if (themeToggle.Text == "Dark")
            {
                File.WriteAllText("theme.txt", "dark");
                this.BackColor = Color.Black;
                label.BackColor = Color.Black; label.ForeColor = Color.White; // Label
                vsCodeButton.BackColor = Color.Black; vsCodeButton.ForeColor = Color.White; // VS Code Button
                vsButton.BackColor = Color.Black; vsButton.ForeColor = Color.White; // Visual Studio Button
                pythonButton.BackColor = Color.Black; pythonButton.ForeColor = Color.White; // Run Button
                themeToggle.BackColor = Color.Black; themeToggle.ForeColor = Color.White; // Theme Domain Up Down
            }

            else
            {
                File.WriteAllText("theme.txt", "light");
                this.BackColor = Color.White;
                label.BackColor = Color.White; label.ForeColor = Color.Black;
                vsCodeButton.BackColor = Color.White; vsCodeButton.ForeColor = Color.Black;
                vsButton.BackColor = Color.White; vsButton.ForeColor = Color.Black;
                pythonButton.BackColor = Color.White; pythonButton.ForeColor = Color.Black;
                themeToggle.BackColor = Color.White; themeToggle.ForeColor = Color.Black;
            }
        }
    }
}