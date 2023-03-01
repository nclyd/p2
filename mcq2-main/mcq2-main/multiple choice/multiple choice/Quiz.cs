using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace multiple_choice
{
    class Quiz
    {
        private static string currentTopic, currentDifficulty;

        private Quiz()
        {

        }

        public static string CurrentTopic { get => currentTopic; set => currentTopic = value; }
        public static string CurrentDifficulty { get => currentDifficulty; set => currentDifficulty = value; }

        public static List<MultipleChoice> GetMCQs()
        {
            List<MultipleChoice> question = new List<MultipleChoice>();
           
            

            string path = "MultipleChoiceQuestions.csv";
            string[] questions = new string[File.ReadAllLines(path).Length];
            int questionNo = questions.Length;
            string[,] mcqs = new string[questionNo, 8];

            string[] temp = new string[8];

            for(int i = 0; i < questionNo; i++)
            {
                temp = questions[i].Split(',');
                for(int j=0; j<8; j++)
                {
                    mcqs[i, j] = temp[j];
                }
            }
            

            for(int i = 0; i <mcqs.GetLength(0); i++)
            {
                MultipleChoice n = new MultipleChoice();
                if (mcqs[i, 6] == currentTopic && mcqs[i, 7] == currentDifficulty)
                {
                    n.QuestionText = mcqs[i, 0];
                    n.possibleAns[0] = mcqs[i, 1];
                    n.possibleAns[1] = mcqs[i, 2];
                    n.possibleAns[2] = mcqs[i, 3];
                    n.possibleAns[3] = mcqs[i, 4];
                    n.answers = mcqs[i, 5];
                    question.Add(n);
                }
            }
            return question;
        }
    }
}
