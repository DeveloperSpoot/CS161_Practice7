namespace CS161_Practice7.Problems
{
    partial class Drivers_License_Exam
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
            loadFileButton = new Button();
            groupBox1 = new GroupBox();
            outcomeLabel = new Label();
            groupBox2 = new GroupBox();
            totalLabel = new Label();
            groupBox3 = new GroupBox();
            incorrectListBox = new ListBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // loadFileButton
            // 
            loadFileButton.BackColor = Color.SteelBlue;
            loadFileButton.ForeColor = SystemColors.Control;
            loadFileButton.Location = new Point(12, 12);
            loadFileButton.Name = "loadFileButton";
            loadFileButton.Size = new Size(257, 33);
            loadFileButton.TabIndex = 2;
            loadFileButton.Text = "Load Student's Test";
            loadFileButton.UseVisualStyleBackColor = false;
            loadFileButton.Click += loadFileButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(outcomeLabel);
            groupBox1.Location = new Point(14, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 57);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Passed/Failed";
            // 
            // outcomeLabel
            // 
            outcomeLabel.BackColor = SystemColors.ControlLightLight;
            outcomeLabel.ForeColor = SystemColors.Control;
            outcomeLabel.Location = new Point(11, 21);
            outcomeLabel.Name = "outcomeLabel";
            outcomeLabel.Size = new Size(234, 23);
            outcomeLabel.TabIndex = 0;
            outcomeLabel.Text = "Don't go.";
            outcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(totalLabel);
            groupBox2.Location = new Point(14, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 57);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total";
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.ControlLightLight;
            totalLabel.Location = new Point(11, 21);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(234, 23);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "0 / 0";
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(incorrectListBox);
            groupBox3.Location = new Point(14, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(255, 176);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Incorrect Answers";
            // 
            // incorrectListBox
            // 
            incorrectListBox.FormattingEnabled = true;
            incorrectListBox.ItemHeight = 15;
            incorrectListBox.Location = new Point(11, 24);
            incorrectListBox.Name = "incorrectListBox";
            incorrectListBox.Size = new Size(234, 139);
            incorrectListBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(14, 364);
            button1.Name = "button1";
            button1.Size = new Size(257, 33);
            button1.TabIndex = 6;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Drivers_License_Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 405);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(loadFileButton);
            Name = "Drivers_License_Exam";
            Text = "Drivers_License_Exam";
            Load += Drivers_License_Exam_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button loadFileButton;
        private GroupBox groupBox1;
        private Label outcomeLabel;
        private GroupBox groupBox2;
        private Label totalLabel;
        private GroupBox groupBox3;
        private ListBox incorrectListBox;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}