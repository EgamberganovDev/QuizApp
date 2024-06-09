namespace QuizApp
{
    partial class QuizApp
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
            Work_quiz = new Button();
            Load_quiz = new Button();
            Score_table = new Button();
            about = new Button();
            SuspendLayout();
            // 
            // Work_quiz
            // 
            Work_quiz.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Work_quiz.Location = new Point(287, 61);
            Work_quiz.Name = "Work_quiz";
            Work_quiz.Size = new Size(205, 56);
            Work_quiz.TabIndex = 0;
            Work_quiz.Text = "Test Ishlash";
            Work_quiz.UseVisualStyleBackColor = true;
            Work_quiz.Click += Work_quiz_Click;
            // 
            // Load_quiz
            // 
            Load_quiz.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Load_quiz.Location = new Point(287, 148);
            Load_quiz.Name = "Load_quiz";
            Load_quiz.Size = new Size(205, 56);
            Load_quiz.TabIndex = 1;
            Load_quiz.Text = "Test Yuklash";
            Load_quiz.UseVisualStyleBackColor = true;
            Load_quiz.Click += Load_quiz_Click;
            // 
            // Score_table
            // 
            Score_table.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Score_table.Location = new Point(287, 235);
            Score_table.Name = "Score_table";
            Score_table.Size = new Size(205, 56);
            Score_table.TabIndex = 2;
            Score_table.Text = "Natijalar";
            Score_table.UseVisualStyleBackColor = true;
            Score_table.Click += Score_table_Click;
            // 
            // about
            // 
            about.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            about.Location = new Point(287, 327);
            about.Name = "about";
            about.Size = new Size(205, 56);
            about.TabIndex = 3;
            about.Text = "About";
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // QuizApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(about);
            Controls.Add(Score_table);
            Controls.Add(Load_quiz);
            Controls.Add(Work_quiz);
            Name = "QuizApp";
            Text = "QuizApp";
            ResumeLayout(false);
        }

        #endregion

        private Button Work_quiz;
        private Button Load_quiz;
        private Button Score_table;
        private Button about;
    }
}