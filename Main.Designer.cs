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
            chargeValidationButton = new Button();
            driversTestButton = new Button();
            worldSeriesButton = new Button();
            nameSearchButton = new Button();
            populationDataButton = new Button();
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
            salesAnalysisButton.Click += salesAnalysisButton_Click;
            // 
            // chargeValidationButton
            // 
            chargeValidationButton.Location = new Point(15, 52);
            chargeValidationButton.Name = "chargeValidationButton";
            chargeValidationButton.Size = new Size(149, 40);
            chargeValidationButton.TabIndex = 1;
            chargeValidationButton.Text = "Charge Account Validation";
            chargeValidationButton.UseVisualStyleBackColor = true;
            chargeValidationButton.Click += chargeValidationButton_Click;
            // 
            // driversTestButton
            // 
            driversTestButton.Location = new Point(15, 108);
            driversTestButton.Name = "driversTestButton";
            driversTestButton.Size = new Size(149, 23);
            driversTestButton.TabIndex = 2;
            driversTestButton.Text = "Drivers Test";
            driversTestButton.UseVisualStyleBackColor = true;
            driversTestButton.Click += driversTestButton_Click;
            // 
            // worldSeriesButton
            // 
            worldSeriesButton.Location = new Point(15, 149);
            worldSeriesButton.Name = "worldSeriesButton";
            worldSeriesButton.Size = new Size(149, 23);
            worldSeriesButton.TabIndex = 3;
            worldSeriesButton.Text = "World Series";
            worldSeriesButton.UseVisualStyleBackColor = true;
            worldSeriesButton.Click += worldSeriesButton_Click;
            // 
            // nameSearchButton
            // 
            nameSearchButton.Location = new Point(15, 188);
            nameSearchButton.Name = "nameSearchButton";
            nameSearchButton.Size = new Size(149, 23);
            nameSearchButton.TabIndex = 4;
            nameSearchButton.Text = "Name Search";
            nameSearchButton.UseVisualStyleBackColor = true;
            // 
            // populationDataButton
            // 
            populationDataButton.Location = new Point(15, 230);
            populationDataButton.Name = "populationDataButton";
            populationDataButton.Size = new Size(149, 23);
            populationDataButton.TabIndex = 5;
            populationDataButton.Text = "Population Data";
            populationDataButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(185, 273);
            Controls.Add(populationDataButton);
            Controls.Add(nameSearchButton);
            Controls.Add(worldSeriesButton);
            Controls.Add(driversTestButton);
            Controls.Add(chargeValidationButton);
            Controls.Add(salesAnalysisButton);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button salesAnalysisButton;
        private Button chargeValidationButton;
        private Button driversTestButton;
        private Button worldSeriesButton;
        private Button nameSearchButton;
        private Button populationDataButton;
    }
}
