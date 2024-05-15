namespace WinFormsApp2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtDisplay = new TextBox();
            btnDisplay = new Button();
            btnClear = new Button();
            btnExit = new Button();
            btnText = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(238, 57);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(266, 27);
            txtDisplay.TabIndex = 0;
            toolTip1.SetToolTip(txtDisplay, "con cac");
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            txtDisplay.KeyPress += txtDisplay_KeyPress;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(166, 129);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 1;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(311, 129);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(451, 129);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnText
            // 
            btnText.Location = new Point(577, 284);
            btnText.Name = "btnText";
            btnText.Size = new Size(94, 29);
            btnText.TabIndex = 4;
            btnText.Text = "text";
            btnText.UseVisualStyleBackColor = true;
            btnText.Click += btnText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnText);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "bai 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnExit;
        private Button btnText;
        private ToolTip toolTip1;
    }
}
