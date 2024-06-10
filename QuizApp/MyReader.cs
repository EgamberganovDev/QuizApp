using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class MyReader
    {
        public string Name(string name)
        {
            int counter = 1;
            string newName = name;
            string userDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string quizAppPath = Path.Combine(userDocumentsPath, "QuizApp");
            string packagePath1 = Path.Combine(quizAppPath, "Natijalar");
            string path = Path.Combine(packagePath1, $"{newName}.txt");

            if(File.Exists(path))
            {
                newName += counter.ToString();
                counter++;
            }

            return newName;
        }

        public List<string> userNames()
        {
            List<string> names = new List<string>();

            string userDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string quizAppPath = Path.Combine(userDocumentsPath, "QuizApp");
            string packagePath1 = Path.Combine(quizAppPath, "Results");
            string path1 = Path.Combine(packagePath1, "trueResults.txt");
            string path2 = Path.Combine(packagePath1, "falseResults.txt");

            StreamReader reader1 = new StreamReader(path1);
            StreamReader reader2 = new StreamReader(path2);

            string[] list = reader1.ReadToEnd().Split("====================");
            for (int i = 0; i < list.Length; i++)
            {
                string[] list1 = list[i].Split('\n');
                for (int j = 0; j < list1.Length; i++)
                {
                    string[] list2 = list1[j].Split(':', ',', '.');
                    names.Add(list2[1]);
                }
            }

            return names;
        }
    }
}
