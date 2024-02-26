namespace CS161_Practice7.Problems
{
    partial class Charge_Account_Validation
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
            accountNumberTextBox = new TextBox();
            checkButton = new Button();
            groupBox2 = new GroupBox();
            validationStatusLabel = new Label();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(accountNumberTextBox);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 56);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Charge Account Number";
            // 
            // accountNumberTextBox
            // 
            accountNumberTextBox.Location = new Point(15, 22);
            accountNumberTextBox.Name = "accountNumberTextBox";
            accountNumberTextBox.Size = new Size(239, 23);
            accountNumberTextBox.TabIndex = 0;
            accountNumberTextBox.TextChanged += accountNumberTextBox_TextChanged;
            // 
            // checkButton
            // 
            checkButton.BackColor = SystemColors.ActiveCaption;
            checkButton.ForeColor = SystemColors.Control;
            checkButton.Location = new Point(289, 19);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(101, 48);
            checkButton.TabIndex = 1;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = false;
            checkButton.Click += checkButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(validationStatusLabel);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(11, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 69);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Validation Status";
            // 
            // validationStatusLabel
            // 
            validationStatusLabel.BackColor = Color.DarkGoldenrod;
            validationStatusLabel.ForeColor = SystemColors.Control;
            validationStatusLabel.Location = new Point(13, 21);
            validationStatusLabel.Name = "validationStatusLabel";
            validationStatusLabel.Size = new Size(354, 34);
            validationStatusLabel.TabIndex = 0;
            validationStatusLabel.Text = "Enter Charge Account Number.";
            validationStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(11, 162);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(379, 33);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Charge_Account_Validation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 206);
            Controls.Add(exitButton);
            Controls.Add(groupBox2);
            Controls.Add(checkButton);
            Controls.Add(groupBox1);
            Name = "Charge_Account_Validation";
            Text = "Charge_Account_Validation";
            Load += Charge_Account_Validation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox accountNumberTextBox;
        private Button checkButton;
        private GroupBox groupBox2;
        private Label validationStatusLabel;
        private Button exitButton;
    }
}