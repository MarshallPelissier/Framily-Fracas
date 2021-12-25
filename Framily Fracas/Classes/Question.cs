using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framily_Fracas
{
    public class Question
    {
        public string text;
        public int points;
        public List<Answer> answers;
        public bool used = false;
        public int maxPoint;

        public Question()
        {
            text = "";
            points = 0;
            answers = new List<Answer>();
            maxPoint = 0;
        }


        public Question(Question q)
        {
            text = q.text;
            maxPoint = q.points;
            answers = q.answers;
            SortAnswers();
        }

        public Question(string t, int p, List<Answer> a)
        {
            text = t;
            maxPoint = p;
            answers = a;
            SortAnswers();
        }

        public void SortAnswers()
        {
            answers = answers.OrderByDescending(an => an.points).ToList();
        }

        public void ToggleAnswer(int i)
        {
            answers[i].revealed = !answers[i].revealed;
            countPoints();
        }

        private void countPoints()
        {
            points = 0;
            foreach (Answer a in answers)
            {
                if (a.revealed)
                {
                    points += a.points;
                }
            }
        }
    }
}
