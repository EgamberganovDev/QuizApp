namespace QuizApp
{
    partial class Result
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label1.Location = new Point(37, 69);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 0;
            label1.Text = "Ism , familiyasi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label2.Location = new Point(37, 152);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 1;
            label2.Text = "Fan nomi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label3.Location = new Point(37, 231);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 2;
            label3.Text = "Testlar soni :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label4.Location = new Point(37, 287);
            label4.Name = "label4";
            label4.Size = new Size(147, 17);
            label4.TabIndex = 3;
            label4.Text = "To'g'ri javoblar soni :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label5.Location = new Point(37, 399);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 4;
            label5.Text = "Foizi (%) :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label6.Location = new Point(209, 399);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 5;
            label6.Text = "Bahosi :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(241, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 6;
            button1.Text = "Asosiy Sahifa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label7.Location = new Point(37, 338);
            label7.Name = "label7";
            label7.Size = new Size(147, 17);
            label7.TabIndex = 7;
            label7.Text = "To'g'ri javoblar soni :";
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(365, 451);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Result";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Natija";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
    }
}