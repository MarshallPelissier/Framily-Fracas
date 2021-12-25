using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framily_Fracas
{
    public class Answer
    {
        public string text;
        public int points;
        public bool revealed = false;
        public int id = 0;

        public Answer()
        {
            text = "";
            points = 0;
        }

        public Answer(string t, int p, int idNum = 0)
        {
            text = t;
            points = p;
            id = idNum;
        }
    }
}
