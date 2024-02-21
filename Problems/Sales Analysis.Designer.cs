namespace CS161_Practice7.Problems
{
    partial class Sales_Analysis
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
            salesListBox = new ListBox();
            loadFileButton = new Button();
            groupBox2 = new GroupBox();
            totalLabel = new Label();
            exitButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox3 = new GroupBox();
            averageLabel = new Label();
            groupBox4 = new GroupBox();
            largestLabel = new Label();
            groupBox5 = new GroupBox();
            smallestLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(salesListBox);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(22, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales";
            // 
            // salesListBox
            // 
            salesListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salesListBox.FormattingEnabled = true;
            salesListBox.ItemHeight = 15;
            salesListBox.Location = new Point(13, 23);
            salesListBox.Name = "salesListBox";
            salesListBox.Size = new Size(229, 214);
            salesListBox.TabIndex = 0;
            // 
            // loadFileButton
            // 
            loadFileButton.BackColor = Color.SteelBlue;
            loadFileButton.ForeColor = SystemColors.Control;
            loadFileButton.Location = new Point(22, 14);
            loadFileButton.Name = "loadFileButton";
            loadFileButton.Size = new Size(257, 33);
            loadFileButton.TabIndex = 1;
            loadFileButton.Text = "Load Sales Files";
            loadFileButton.UseVisualStyleBackColor = false;
            loadFileButton.Click += loadFileButton_Method;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(totalLabel);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(299, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 66);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total";
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.ControlLight;
            totalLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(11, 21);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(231, 32);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "X marks the spot ";
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(22, 323);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(532, 33);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Method;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(averageLabel);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox3.Location = new Point(299, 86);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(255, 66);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Average";
            // 
            // averageLabel
            // 
            averageLabel.BackColor = SystemColors.ControlLight;
            averageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            averageLabel.Location = new Point(11, 21);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(231, 32);
            averageLabel.TabIndex = 0;
            averageLabel.Text = "where we fell apart";
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(largestLabel);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox4.Location = new Point(299, 158);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(255, 66);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Largest Value";
            // 
            // largestLabel
            // 
            largestLabel.BackColor = SystemColors.ControlLight;
            largestLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            largestLabel.Location = new Point(11, 21);
            largestLabel.Name = "largestLabel";
            largestLabel.Size = new Size(231, 32);
            largestLabel.TabIndex = 0;
            largestLabel.Text = " He poisoned the well,";
            largestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(smallestLabel);
            groupBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox5.Location = new Point(299, 239);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(255, 66);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Smallest Value";
            // 
            // smallestLabel
            // 
            smallestLabel.BackColor = SystemColors.ControlLight;
            smallestLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallestLabel.Location = new Point(11, 21);
            smallestLabel.Name = "smallestLabel";
            smallestLabel.Size = new Size(231, 32);
            smallestLabel.TabIndex = 0;
            smallestLabel.Text = "I was lyin' to myself";
            smallestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sales_Analysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 378);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(exitButton);
            Controls.Add(groupBox2);
            Controls.Add(loadFileButton);
            Controls.Add(groupBox1);
            Name = "Sales_Analysis";
            Text = "Sales Analysis";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox salesListBox;
        private Button loadFileButton;
        private GroupBox groupBox2;
        private Label totalLabel;
        private Button exitButton;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox3;
        private Label averageLabel;
        private GroupBox groupBox4;
        private Label largestLabel;
        private GroupBox groupBox5;
        private Label smallestLabel;
    }
}