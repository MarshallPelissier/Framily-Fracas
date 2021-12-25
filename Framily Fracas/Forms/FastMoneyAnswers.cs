using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Framily_Fracas.Classes
{
    public partial class FastMoneyAnswers : Form
    {
        private Question question;
        private FMAnswer answer;
        public FastMoneyAnswers()
        {
            InitializeComponent();
        }

        public FastMoneyAnswers(Question q, FMAnswer a)
        {
            InitializeComponent();
            question = q;
            answer = a;

            lbl_Question.Text = q.text;
            lbl_Answer.Text = a.text;
            ab_fma.SetControlView(true);
            ab_fma.NewQuestion(q);
            ab_fma.HideAllAnswers();

            Program.CenterControl(lbl_Answer, true, false);
            Program.CenterControl(lbl_Question, true, false);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            Thread.Sleep(50);
            answer.points = ab_fma.GetSelectedPoints();

            Program.gc.UpdateAnswer(answer);
            this.Close();
        }

        private void FastMoneyAnswers_Resize(object sender, EventArgs e)
        {
            Program.CenterControl(lbl_Answer, true, false);
            Program.CenterControl(lbl_Question, true, false);
        }
    }
}
