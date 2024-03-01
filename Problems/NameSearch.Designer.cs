namespace CS161_Practice7.Problems
{
    partial class NameSearch
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
            inputTextBox = new TextBox();
            searchButton = new Button();
            groupBox2 = new GroupBox();
            resaultLabel = new Label();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inputTextBox);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 57);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter a Name to Search.";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(9, 23);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(306, 23);
            inputTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.CornflowerBlue;
            searchButton.ForeColor = SystemColors.Control;
            searchButton.Location = new Point(347, 23);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(90, 50);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resaultLabel);
            groupBox2.Location = new Point(16, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 71);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resault";
            // 
            // resaultLabel
            // 
            resaultLabel.BackColor = SystemColors.ControlLight;
            resaultLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resaultLabel.Location = new Point(14, 24);
            resaultLabel.Name = "resaultLabel";
            resaultLabel.Size = new Size(392, 31);
            resaultLabel.TabIndex = 0;
            resaultLabel.Text = "A Name To Search.";
            resaultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(16, 156);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(421, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // NameSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 203);
            Controls.Add(exitButton);
            Controls.Add(groupBox2);
            Controls.Add(searchButton);
            Controls.Add(groupBox1);
            Name = "NameSearch";
            Text = "NameSearch";
            Load += NameSearch_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox inputTextBox;
        private Button searchButton;
        private GroupBox groupBox2;
        private Label resaultLabel;
        private Button exitButton;
    }
}