namespace marix
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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SumColumnsButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SumRowsButton = new System.Windows.Forms.Button();
            this.mintext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 114);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(94, 43);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Генерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SumColumnsButton
            // 
            this.SumColumnsButton.Location = new System.Drawing.Point(112, 114);
            this.SumColumnsButton.Name = "SumColumnsButton";
            this.SumColumnsButton.Size = new System.Drawing.Size(75, 43);
            this.SumColumnsButton.TabIndex = 1;
            this.SumColumnsButton.Text = "суммы по столбцам матрицы";
            this.SumColumnsButton.UseVisualStyleBackColor = true;
            this.SumColumnsButton.Click += new System.EventHandler(this.SumColumnsButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(175, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // SumRowsButton
            // 
            this.SumRowsButton.Location = new System.Drawing.Point(193, 114);
            this.SumRowsButton.Name = "SumRowsButton";
            this.SumRowsButton.Size = new System.Drawing.Size(75, 43);
            this.SumRowsButton.TabIndex = 3;
            this.SumRowsButton.Text = "суммы по строкам матрицы";
            this.SumRowsButton.UseVisualStyleBackColor = true;
            this.SumRowsButton.Click += new System.EventHandler(this.SumRowsButton_Click);
            // 
            // mintext
            // 
            this.mintext.Location = new System.Drawing.Point(199, 15);
            this.mintext.Name = "mintext";
            this.mintext.Size = new System.Drawing.Size(266, 23);
            this.mintext.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open consol lb 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open consol lb 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mintext);
            this.Controls.Add(this.SumRowsButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SumColumnsButton);
            this.Controls.Add(this.GenerateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button SumColumnsButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SumRowsButton;
        private System.Windows.Forms.TextBox mintext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
