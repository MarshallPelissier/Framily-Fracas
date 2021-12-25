using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framily_Fracas
{
    public class SurveyData
    {
        //private int totalAnswers;
        [JsonProperty]
        private List<Question> questions = new List<Question>();

        public Question GetNewQuestion(bool fastMoney = false)
        {
            bool found = false;
            Question q;
            Random rnd = new Random();
            int i = 0;
            bool fm = true;
            int p = 0;
            

            do
            {
                i = rnd.Next(questions.Count);
                q = questions[i];
                p = q.answers[0].points;

                if (fastMoney)
                {
                    fm = ((q.text.Length < 150) && (p < 56) && (p > 24));
                }

                if (!q.used && fm)
                {
                    questions[i].used = true;
                    found = true;
                }

            } while (!found);

            return q;
        }

        public void AddNewQuestion(Question question)
        {
            questions.Add(question);
        }
    }
}
