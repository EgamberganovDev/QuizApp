using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.models
{
    internal class questionModel
    {
        public int id { get; }
        public string course_name { get; }
        public string question { get; }
        public string optionA { get; }
        public string optionB { get; }
        public string optionC { get; }
        public string optionD { get; }
        public string correctOption { get; }

        public questionModel(string course_name, string question, string optionA, string optionB, string optionC, string optionD, string correctOption)
        {
            this.course_name = course_name;
            this.question = question;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            this.correctOption = correctOption;
        }
    }
}
