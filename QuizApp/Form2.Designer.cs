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
            label1.Location = new Point(63, 65);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 0;
            label1.Text = "Ism Familiya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 152);
            label2.Name = "label2";
            label2.Size = new Size(46, 30);
            label2.TabIndex = 1;
            label2.Text = "Fan";
            // 
            // fio
            // 
            fio.Location = new Point(212, 65);
            fio.Multiline = true;
            fio.Name = "fio";
            fio.Size = new Size(227, 34);
            fio.TabIndex = 2;
            // 
            // courses
            // 
            courses.FormattingEnabled = true;
            courses.Items.AddRange(new object[] { "Dasturlash Asoslari", "Web Dasturlash", "Mobil Dasturlash", "Sun'iy Intellekt" });
            courses.Location = new Point(212, 152);
            courses.Name = "courses";
            courses.Size = new Size(227, 28);
            courses.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 237);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 4;
            label3.Text = "Testlar soni";
            // 
            // numbersOfQuiz
            // 
            numbersOfQuiz.Location = new Point(212, 240);
            numbersOfQuiz.Name = "numbersOfQuiz";
            numbersOfQuiz.Size = new Size(227, 27);
            numbersOfQuiz.TabIndex = 5;
            // 
            // start_quiz
            // 
            start_quiz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            start_quiz.Location = new Point(278, 323);
            start_quiz.Name = "start_quiz";
            start_quiz.Size = new Size(161, 42);
            start_quiz.TabIndex = 6;
            start_quiz.Text = "Testni boshlash";
            start_quiz.UseVisualStyleBackColor = true;
            start_quiz.Click += start_quiz_Click;
            // 
            // startQuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(start_quiz);
            Controls.Add(numbersOfQuiz);
            Controls.Add(label3);
            Controls.Add(courses);
            Controls.Add(fio);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "startQuizForm";
            Text = "Testni boshlash";
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