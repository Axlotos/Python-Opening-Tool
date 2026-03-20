namespace PythonOpeningTool
{
    partial class PythonOpeningTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PythonOpeningTool));
            label = new Label();
            vsCodeButton = new Button();
            vsButton = new Button();
            pythonButton = new Button();
            themeToggle = new DomainUpDown();
            customAppButton = new Button();
            customAppTextBox = new TextBox();
            customAppLabel = new Label();
            customAppTextBoxBorder = new Panel();
            customAppTextBoxBorder.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(54, 9);
            label.Name = "label";
            label.Size = new Size(167, 30);
            label.TabIndex = 0;
            label.Text = "Select what you would like to\r\ndo with this Python source file";
            // 
            // vsCodeButton
            // 
            vsCodeButton.Location = new Point(54, 53);
            vsCodeButton.Name = "vsCodeButton";
            vsCodeButton.Size = new Size(164, 25);
            vsCodeButton.TabIndex = 1;
            vsCodeButton.Text = "Open in VS Code";
            vsCodeButton.UseVisualStyleBackColor = true;
            vsCodeButton.Click += vsCodeButton_Click;
            // 
            // vsButton
            // 
            vsButton.Location = new Point(54, 84);
            vsButton.Name = "vsButton";
            vsButton.Size = new Size(164, 25);
            vsButton.TabIndex = 2;
            vsButton.Text = "Open in Visual Studio";
            vsButton.UseVisualStyleBackColor = true;
            vsButton.Click += vsButton_Click;
            // 
            // pythonButton
            // 
            pythonButton.Location = new Point(54, 115);
            pythonButton.Name = "pythonButton";
            pythonButton.Size = new Size(164, 25);
            pythonButton.TabIndex = 3;
            pythonButton.Text = "Run";
            pythonButton.UseVisualStyleBackColor = true;
            pythonButton.Click += pythonButton_Click;
            // 
            // themeToggle
            // 
            themeToggle.BackColor = SystemColors.Control;
            themeToggle.Items.Add("Light");
            themeToggle.Items.Add("Dark");
            themeToggle.Location = new Point(107, 181);
            themeToggle.Name = "themeToggle";
            themeToggle.ReadOnly = true;
            themeToggle.Size = new Size(58, 23);
            themeToggle.TabIndex = 1;
            themeToggle.Text = "Theme";
            themeToggle.SelectedItemChanged += themeToggle_SelectedItemChanged;
            // 
            // customAppButton
            // 
            customAppButton.Location = new Point(54, 146);
            customAppButton.Name = "customAppButton";
            customAppButton.Size = new Size(78, 23);
            customAppButton.TabIndex = 4;
            customAppButton.Text = "Custom";
            customAppButton.UseVisualStyleBackColor = true;
            customAppButton.Click += customAppButton_Click;
            // 
            // customAppTextBox
            // 
            customAppTextBox.BackColor = Color.White;
            customAppTextBox.BorderStyle = BorderStyle.None;
            customAppTextBox.Dock = DockStyle.Fill;
            customAppTextBox.Font = new Font("Segoe UI", 9F);
            customAppTextBox.Location = new Point(1, 1);
            customAppTextBox.Multiline = true;
            customAppTextBox.Name = "customAppTextBox";
            customAppTextBox.Size = new Size(78, 21);
            customAppTextBox.TabIndex = 5;
            customAppTextBox.TextChanged += customAppTextBox_TextChanged;
            customAppTextBox.KeyDown += customAppTextBox_KeyDown;
            // 
            // customAppLabel
            // 
            customAppLabel.AutoSize = true;
            customAppLabel.Location = new Point(224, 149);
            customAppLabel.Name = "customAppLabel";
            customAppLabel.Size = new Size(53, 30);
            customAppLabel.TabIndex = 6;
            customAppLabel.Text = "<- select\r\n      app";
            // 
            // customAppTextBoxBorder
            // 
            customAppTextBoxBorder.BackColor = Color.Gray;
            customAppTextBoxBorder.Controls.Add(customAppTextBox);
            customAppTextBoxBorder.Location = new Point(138, 146);
            customAppTextBoxBorder.Name = "customAppTextBoxBorder";
            customAppTextBoxBorder.Padding = new Padding(1);
            customAppTextBoxBorder.Size = new Size(80, 23);
            customAppTextBoxBorder.TabIndex = 7;
            // 
            // PythonOpeningTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(284, 236);
            Controls.Add(customAppTextBoxBorder);
            Controls.Add(customAppLabel);
            Controls.Add(customAppButton);
            Controls.Add(themeToggle);
            Controls.Add(pythonButton);
            Controls.Add(vsButton);
            Controls.Add(vsCodeButton);
            Controls.Add(label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PythonOpeningTool";
            ShowInTaskbar = false;
            Text = "Python Opening Tool";
            customAppTextBoxBorder.ResumeLayout(false);
            customAppTextBoxBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button vsCodeButton;
        private Button vsButton;
        private Button pythonButton;
        private DomainUpDown themeToggle;
        private Button customAppButton;
        private TextBox customAppTextBox;
        private Label customAppLabel;
        private Panel customAppTextBoxBorder;
    }
}
