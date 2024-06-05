namespace QuizApp
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
            button1 = new Button();
            Load_quiz = new Button();
            Score_table = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(287, 61);
            button1.Name = "button1";
            button1.Size = new Size(205, 56);
            button1.TabIndex = 0;
            button1.Text = "Test Ishlash";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // Score_table
            // 
            Score_table.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Score_table.Location = new Point(287, 234);
            Score_table.Name = "Score_table";
            Score_table.Size = new Size(205, 56);
            Score_table.TabIndex = 2;
            Score_table.Text = "Natijalar";
            Score_table.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Score_table);
            Controls.Add(Load_quiz);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button Load_quiz;
        private Button Score_table;
    }
}