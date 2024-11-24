namespace QuizApp
{
    partial class About
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(15, 15);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 0;
            button1.Text = "Asosiy Sahifa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 85);
            label1.Name = "label1";
            label1.Size = new Size(342, 26);
            label1.TabIndex = 1;
            label1.Text = "Ushbu dastur Urganch davlat universiteti";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 110);
            label2.Name = "label2";
            label2.Size = new Size(449, 26);
            label2.TabIndex = 2;
            label2.Text = "Fizika-Matematika fakulteti 222-KIDT guruhi talabasi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(150, 135);
            label3.Name = "label3";
            label3.Size = new Size(446, 26);
            label3.TabIndex = 3;
            label3.Text = "Egamberganov Bobomurod tomonidan ishlab chiqildi.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseCompatibleTextRendering = true;
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 392);
            label4.Name = "label4";
            label4.Size = new Size(260, 22);
            label4.TabIndex = 4;
            label4.Text = "Tuzuvchi: Egamberganov Bobomurod";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseCompatibleTextRendering = true;
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 412);
            label5.Name = "label5";
            label5.Size = new Size(96, 22);
            label5.TabIndex = 5;
            label5.Text = "Versiya: 1.0.0";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseCompatibleTextRendering = true;
            label5.Visible = false;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biz Haqimizda";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}