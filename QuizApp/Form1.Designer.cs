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
            button1 = new Button();
            SuspendLayout();
            // 
            // Work_quiz
            // 
            Work_quiz.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Work_quiz.Location = new Point(251, 46);
            Work_quiz.Margin = new Padding(3, 2, 3, 2);
            Work_quiz.Name = "Work_quiz";
            Work_quiz.Size = new Size(179, 42);
            Work_quiz.TabIndex = 0;
            Work_quiz.Text = "Test Ishlash";
            Work_quiz.UseVisualStyleBackColor = true;
            Work_quiz.Click += Work_quiz_Click;
            // 
            // Load_quiz
            // 
            Load_quiz.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Load_quiz.Location = new Point(251, 111);
            Load_quiz.Margin = new Padding(3, 2, 3, 2);
            Load_quiz.Name = "Load_quiz";
            Load_quiz.Size = new Size(179, 42);
            Load_quiz.TabIndex = 1;
            Load_quiz.Text = "Test Yuklash";
            Load_quiz.UseVisualStyleBackColor = true;
            // 
            // Score_table
            // 
            Score_table.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Score_table.Location = new Point(251, 176);
            Score_table.Margin = new Padding(3, 2, 3, 2);
            Score_table.Name = "Score_table";
            Score_table.Size = new Size(179, 42);
            Score_table.TabIndex = 2;
            Score_table.Text = "Natijalar";
            Score_table.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(251, 245);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(179, 42);
            button1.TabIndex = 3;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = true;
            // 
            // QuizApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(Score_table);
            Controls.Add(Load_quiz);
            Controls.Add(Work_quiz);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuizApp";
            Text = "QuizApp";
            ResumeLayout(false);
        }

        #endregion

        private Button Work_quiz;
        private Button Load_quiz;
        private Button Score_table;
        private Button button1;
    }
}