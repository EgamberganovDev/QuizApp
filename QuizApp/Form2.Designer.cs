namespace QuizApp
{
    partial class startQuizForm
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
            fio = new TextBox();
            courses = new ComboBox();
            label3 = new Label();
            numbersOfQuiz = new NumericUpDown();
            start_quiz = new Button();
            ((System.ComponentModel.ISupportInitialize)numbersOfQuiz).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 49);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Ism Familiya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 114);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 1;
            label2.Text = "Fan";
            // 
            // fio
            // 
            fio.Location = new Point(186, 49);
            fio.Margin = new Padding(3, 2, 3, 2);
            fio.Multiline = true;
            fio.Name = "fio";
            fio.Size = new Size(199, 26);
            fio.TabIndex = 2;
            // 
            // courses
            // 
            courses.FormattingEnabled = true;
            courses.Items.AddRange(new object[] { "Dasturlash Asoslari", "Web Dasturlash", "Mobil Dasturlash", "Sun'iy Intellekt" });
            courses.Location = new Point(186, 114);
            courses.Margin = new Padding(3, 2, 3, 2);
            courses.Name = "courses";
            courses.Size = new Size(199, 23);
            courses.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 178);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 4;
            label3.Text = "Testlar soni";
            // 
            // numbersOfQuiz
            // 
            numbersOfQuiz.Location = new Point(186, 180);
            numbersOfQuiz.Margin = new Padding(3, 2, 3, 2);
            numbersOfQuiz.Name = "numbersOfQuiz";
            numbersOfQuiz.Size = new Size(199, 23);
            numbersOfQuiz.TabIndex = 5;
            // 
            // start_quiz
            // 
            start_quiz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            start_quiz.Location = new Point(243, 242);
            start_quiz.Margin = new Padding(3, 2, 3, 2);
            start_quiz.Name = "start_quiz";
            start_quiz.Size = new Size(141, 32);
            start_quiz.TabIndex = 6;
            start_quiz.Text = "Testni boshlash";
            start_quiz.UseVisualStyleBackColor = true;
            start_quiz.Click += start_quiz_Click;
            // 
            // startQuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 338);
            Controls.Add(start_quiz);
            Controls.Add(numbersOfQuiz);
            Controls.Add(label3);
            Controls.Add(courses);
            Controls.Add(fio);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "startQuizForm";
            Text = "Testni boshlash";
            Load += startQuizForm_Load;
            ((System.ComponentModel.ISupportInitialize)numbersOfQuiz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox fio;
        private ComboBox courses;
        private Label label3;
        private NumericUpDown numbersOfQuiz;
        private Button start_quiz;
    }
}