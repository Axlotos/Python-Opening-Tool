using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PythonOpeningTool
{
    public partial class PythonOpeningTool : Form
    {
        private string file;
        private string vsPath;
        private string theme;
        private string themeTxtPath;
        private string customApp;
        private string customAppTxtPath;
        public PythonOpeningTool(string fileArg, string vsPathArg, string themeArg, string themeTxtPathArg, string customAppArg, string customAppTxtPathArg)
        {
            InitializeComponent();

            // Create variables based on arguments
            this.file = fileArg;
            this.vsPath = vsPathArg;
            this.theme = themeArg;
            this.themeTxtPath = themeTxtPathArg;
            this.customApp = customAppArg;
            this.customAppTxtPath = customAppTxtPathArg;

            // Set text on the custom app text box
            customAppTextBox.Text = this.customApp;

            // Button and custom app text box borders
            vsCodeButton.FlatStyle = FlatStyle.Flat;
            vsCodeButton.FlatAppearance.BorderColor = Color.Gray;
            vsButton.FlatStyle = FlatStyle.Flat;
            vsButton.FlatAppearance.BorderColor = Color.Gray;
            pythonButton.FlatStyle = FlatStyle.Flat;
            pythonButton.FlatAppearance.BorderColor = Color.Gray;
            customAppButton.FlatStyle = FlatStyle.Flat;
            customAppButton.FlatAppearance.BorderColor = Color.Gray;

            // Set theme based on variable
            if (this.theme == "dark")
            {
                this.BackColor = Color.Black; // Window
                label.ForeColor = Color.White; // Main Label
                customAppLabel.ForeColor = Color.White; // Custom App Label
                vsCodeButton.BackColor = Color.Black; vsCodeButton.ForeColor = Color.White; // VS Code Button
                vsButton.BackColor = Color.Black; vsButton.ForeColor = Color.White; // Visual Studio Button
                pythonButton.BackColor = Color.Black; pythonButton.ForeColor = Color.White; // Run Button
                customAppButton.BackColor = Color.Black; customAppButton.ForeColor = Color.White; // Custom App Button
                themeToggle.BackColor = Color.Black; themeToggle.ForeColor = Color.White; // Theme Domain Up Down
                customAppTextBox.BackColor = Color.Black; customAppTextBox.ForeColor = Color.White; // Custom App Text Box
            }

            else
            {
                this.BackColor = Color.White; // Window
                label.ForeColor = Color.Black;  // Label
                customAppLabel.ForeColor = Color.Black; // Custom App Label
                vsCodeButton.BackColor = Color.White; vsCodeButton.ForeColor = Color.Black; // VS Code Button
                vsButton.BackColor = Color.White; vsButton.ForeColor = Color.Black; // Visual Studio Button
                pythonButton.BackColor = Color.White; pythonButton.ForeColor = Color.Black; // Run Button
                customAppButton.BackColor = Color.White; customAppButton.ForeColor = Color.Black; // Custom App Button
                themeToggle.BackColor = Color.White; themeToggle.ForeColor = Color.Black; // Theme Domain Up Down
                customAppTextBox.BackColor = Color.White; customAppTextBox.ForeColor = Color.Black; // Custom App Text Box
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
            // Update colours
            if (themeToggle.Text == "Dark")
            {
                File.WriteAllText(themeTxtPath, "dark");

                this.BackColor = Color.Black; // Window
                label.ForeColor = Color.White; // Main Label
                customAppLabel.ForeColor = Color.White; // Custom App Label
                vsCodeButton.BackColor = Color.Black; vsCodeButton.ForeColor = Color.White; // VS Code Button
                vsButton.BackColor = Color.Black; vsButton.ForeColor = Color.White; // Visual Studio Button
                pythonButton.BackColor = Color.Black; pythonButton.ForeColor = Color.White; // Run Button
                customAppButton.BackColor = Color.Black; customAppButton.ForeColor = Color.White; // Custom App Button
                themeToggle.BackColor = Color.Black; themeToggle.ForeColor = Color.White; // Theme Domain Up Down
                customAppTextBox.BackColor = Color.Black; customAppTextBox.ForeColor = Color.White; // Custom App Text Box
            }

            else
            {
                File.WriteAllText(themeTxtPath, "light");

                this.BackColor = Color.White; // Window
                label.ForeColor = Color.Black;  // Label
                customAppLabel.ForeColor = Color.Black; // Custom App Label
                vsCodeButton.BackColor = Color.White; vsCodeButton.ForeColor = Color.Black; // VS Code Button
                vsButton.BackColor = Color.White; vsButton.ForeColor = Color.Black; // Visual Studio Button
                pythonButton.BackColor = Color.White; pythonButton.ForeColor = Color.Black; // Run Button
                customAppButton.BackColor = Color.White; customAppButton.ForeColor = Color.Black; // Custom App Button
                themeToggle.BackColor = Color.White; themeToggle.ForeColor = Color.Black; // Theme Domain Up Down
                customAppTextBox.BackColor = Color.White; customAppTextBox.ForeColor = Color.Black; // Custom App Text Box
            }
        }

        private void customAppButton_Click(object sender, EventArgs e)
        {
            if (customAppTextBox.Text == "")
            {
                MessageBox.Show("You have not specified an app to open this file in");
                return;
            }

            Process.Start(customApp, file);
            this.Close();
        }

        private void customAppTextBox_TextChanged(object sender, EventArgs e)
        {
            customApp = customAppTextBox.Text;
            File.WriteAllText(customAppTxtPath, customAppTextBox.Text);
        }

        private void customAppTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key they just pressed was the Enter key
            if (e.KeyCode == Keys.Enter)
            {
                // Stop the key press from adding to the text box
                e.SuppressKeyPress = true;

                // Clear the text
                customAppTextBox.Text = "";
            }
        }
    }
}