using Framily_Fracas.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framily_Fracas
{
    public partial class FastMoneyBoard : UserControl
    {
        public int totalPoints;
        private bool controlView;
        private List<FastMoneyAnswer> answers = new List<FastMoneyAnswer>();
        private List<FastMoneyAnswer> answers2 = new List<FastMoneyAnswer>();
        //private List<Answer> ans1 = new List<Answer>();
        //private List<Answer> ans2 = new List<Answer>();
        public FastMoneyBoard()
        {
            InitializeComponent();
            answers.Add(fma1);
            answers.Add(fma2);
            answers.Add(fma3);
            answers.Add(fma4);
            answers.Add(fma5);
            answers.Add(fma6);
            answers.Add(fma7);
            answers.Add(fma8);
            answers.Add(fma9);
            answers.Add(fma10);

            int i = 1;
            foreach (FastMoneyAnswer f in answers)
            {
                f.SetPlace(i);
                i++;
            }
        }

        public void UpdateAnswers(FMAnswer ans)
        {
            //I think this is kinda dumb
            //answers[ans.place].SetValues(ans)
            foreach (FastMoneyAnswer f in answers)
            {
                if (ans.place != 0 && f.place == ans.place)
                {
                    f.SetValues(ans);
                    totalPoints += ans.points;
                }
            }

            lbl_BoardPoints.Text = totalPoints.ToString();
            Program.CenterControl(lbl_BoardPoints);
        }

        public void clearAnswerControls()
        {
            foreach (FastMoneyAnswer ac in answers)
            {
                ac.SetValues(new FMAnswer());
            }
        }
        private void scalePanelItems(Control pnl)
        {
            int c = pnl.Controls.Count;
            int h = pnl.Height / c;
            foreach (Control cntrl in pnl.Controls)
            {
                cntrl.Height = h;
            }
        }

        private void FastMoneyBoard_Resize(object sender, EventArgs e)
        {
            spl_container1.SplitterDistance = (spl_container1.Width - spl_container1.SplitterWidth) / 2;
            scalePanelItems(spl_container1.Panel1);
            scalePanelItems(spl_container1.Panel2);


            pnl_BoardPoints.Height = pnl_BoardPoints.Parent.Height - 6;
            Program.CenterControl(lbl_BoardPoints);
            Program.CenterControl(pnl_BoardPoints);
        }

        public void ShowButtons(bool b)
        {
            foreach (FastMoneyAnswer f in answers)
            {
                f.ShowButton(b);
            }
        }

        public void UpdateQuestions(List<Question> lq)
        {
            fma1.SetQuestion(lq[0]);
            fma2.SetQuestion(lq[1]);
            fma3.SetQuestion(lq[2]);
            fma4.SetQuestion(lq[3]);
            fma5.SetQuestion(lq[4]);
            fma6.SetQuestion(lq[0]);
            fma7.SetQuestion(lq[1]);
            fma8.SetQuestion(lq[2]);
            fma9.SetQuestion(lq[3]);
            fma10.SetQuestion(lq[4]);
        }

        public void ClearAnswers()
        {
            foreach(FastMoneyAnswer fma in answers)
            {
                fma.ClearAnswer();
            }
        }
    }
}
