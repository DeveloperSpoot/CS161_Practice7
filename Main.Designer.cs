namespace CS161_Practice7
{
    partial class Main
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
            salesAnalysisButton = new Button();
            SuspendLayout();
            // 
            // salesAnalysisButton
            // 
            salesAnalysisButton.Location = new Point(15, 13);
            salesAnalysisButton.Name = "salesAnalysisButton";
            salesAnalysisButton.Size = new Size(149, 23);
            salesAnalysisButton.TabIndex = 0;
            salesAnalysisButton.Text = "Sales Analysis";
            salesAnalysisButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(185, 450);
            Controls.Add(salesAnalysisButton);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button salesAnalysisButton;
    }
}
