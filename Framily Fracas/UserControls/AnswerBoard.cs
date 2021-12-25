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
    public partial class AnswerBoard : UserControl
    {
        private bool controlView;
        private List<AnswerControl> answerControls = new List<AnswerControl>();
        private Question question;
        public AnswerBoard()
        {
            InitializeComponent();
            answerControls.Add(ac0);
            answerControls.Add(ac1);
            answerControls.Add(ac2);
            answerControls.Add(ac3);
            answerControls.Add(ac4);
            answerControls.Add(ac5);
            answerControls.Add(ac6);
            answerControls.Add(ac7);
        }

        public void NewQuestion(Question q)
        {
            clearAnswerControls();
            question = new Question();
            question = q;

            int i = 0;
            foreach (Answer a in question.answers)
            {
                answerControls[i].SetAnswer(a, i + 1, controlView);
                i++;
            }

            if (controlView)
            {
                lbl_BoardPoints.Text = question.maxPoint.ToString();
            }
            else
            {
                lbl_BoardPoints.Text = "";
            }
        }

        public void UpdateAnswers(Answer ans)
        {

            int i = 0;
            int total = 0;
            if (!controlView)
            {
                foreach (Answer a in question.answers)
                {
                    if (ans.id != 0 && a.id == ans.id)
                    {
                        a.revealed = ans.revealed;
                        answerControls[i].SetAnswer(ans, i + 1, ans.revealed);
                    }
                    i++;

                    if (a.revealed)
                    {
                        total += a.points;
                    }
                }
            }
            question.points = total;
            lbl_BoardPoints.Text = question.points.ToString();
            Program.CenterControl(lbl_BoardPoints);
        }

        private void clearAnswerControls()
        {
            foreach (AnswerControl ac in answerControls)
            {
                ac.SetAnswer(new Answer(), 0, controlView);
            }
        }

        public void SetControlView(bool view)
        {
            controlView = view;
            if (controlView)
            {

            }
        }

        private void AnswerBoard_Resize(object sender, EventArgs e)
        {
            int splitter = spl_container1.Width - spl_container1.SplitterWidth;
            if (splitter > 0)
            {
                spl_container1.SplitterDistance = splitter / 2;
                scalePanelItems(spl_container1.Panel1);
                scalePanelItems(spl_container1.Panel2);

                pnl_BoardPoints.Height = pnl_BoardPoints.Parent.Height - 6;
                Program.CenterControl(lbl_BoardPoints);
                Program.CenterControl(pnl_BoardPoints);
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

        public int GetSelectedPoints()
        {
            int p = 0;

            foreach(AnswerControl a in answerControls)
            {
                if (a.answer.revealed)
                {
                    p = a.answer.points;
                }
            }

            return p;
        }

        public void HideAllAnswers()
        {
            foreach(AnswerControl a in answerControls)
            {
                a.answer.revealed = false;
            }
        }
    }
}
