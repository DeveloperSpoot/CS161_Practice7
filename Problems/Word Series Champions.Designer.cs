namespace CS161_Practice7.Problems
{
    partial class Word_Series_Champions
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
            teamsListBox = new ListBox();
            groupBox2 = new GroupBox();
            totalLabel = new Label();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(teamsListBox);
            groupBox1.Location = new Point(11, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select A Team";
            // 
            // teamsListBox
            // 
            teamsListBox.BackColor = Color.WhiteSmoke;
            teamsListBox.FormattingEnabled = true;
            teamsListBox.ItemHeight = 15;
            teamsListBox.Location = new Point(11, 22);
            teamsListBox.Name = "teamsListBox";
            teamsListBox.Size = new Size(207, 244);
            teamsListBox.TabIndex = 0;
            teamsListBox.SelectedValueChanged += teamsListBox_SelectedItemChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(totalLabel);
            groupBox2.Location = new Point(11, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 64);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Number of World Championships Won";
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.ControlLight;
            totalLabel.Location = new Point(60, 26);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(100, 23);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(11, 369);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(229, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button1_Click;
            // 
            // Word_Series_Champions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 401);
            Controls.Add(exitButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Word_Series_Champions";
            Text = "Word_Series_Champions";
            Load += Word_Series_Champions_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox teamsListBox;
        private GroupBox groupBox2;
        private Label totalLabel;
        private Button exitButton;
    }
}