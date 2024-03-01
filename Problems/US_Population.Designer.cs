namespace CS161_Practice7.Problems
{
    partial class US_Population
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            averageLabel = new Label();
            groupBox2 = new GroupBox();
            highestChangeLabel = new Label();
            groupBox3 = new GroupBox();
            lowestChangeLabel = new Label();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(averageLabel);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 66);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Average Population Change";
            // 
            // averageLabel
            // 
            averageLabel.BackColor = SystemColors.ControlLight;
            averageLabel.Location = new Point(8, 21);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(261, 32);
            averageLabel.TabIndex = 0;
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(highestChangeLabel);
            groupBox2.Location = new Point(13, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 66);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Highest Population Chnage";
            // 
            // highestChangeLabel
            // 
            highestChangeLabel.BackColor = SystemColors.ControlLight;
            highestChangeLabel.Location = new Point(8, 21);
            highestChangeLabel.Name = "highestChangeLabel";
            highestChangeLabel.Size = new Size(261, 32);
            highestChangeLabel.TabIndex = 0;
            highestChangeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lowestChangeLabel);
            groupBox3.Location = new Point(13, 157);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(278, 66);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lowest Population Change";
            // 
            // lowestChangeLabel
            // 
            lowestChangeLabel.BackColor = SystemColors.ControlLight;
            lowestChangeLabel.Location = new Point(8, 21);
            lowestChangeLabel.Name = "lowestChangeLabel";
            lowestChangeLabel.Size = new Size(261, 32);
            lowestChangeLabel.TabIndex = 0;
            lowestChangeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(12, 229);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(279, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button1_Click;
            // 
            // US_Population
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 272);
            Controls.Add(exitButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "US_Population";
            Text = "US_Population";
            Load += US_Population_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label averageLabel;
        private GroupBox groupBox2;
        private Label highestChangeLabel;
        private GroupBox groupBox3;
        private Label lowestChangeLabel;
        private Button exitButton;
    }
}