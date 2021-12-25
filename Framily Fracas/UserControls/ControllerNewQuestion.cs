using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framily_Fracas
{
    public partial class ControllerNewQuestion : UserControl
    {
        private GameController gc;

        private bool strike1 = false;
        private bool strike2 = false;
        private bool strike3 = false;

        int fram1c = 0;
        int fram2c = 0;

        List<Question> lq = new List<Question>();
        public ControllerNewQuestion()
        {
            InitializeComponent();
            lbl_Question.MaximumSize = new Size(pnl_Question.Width - 20, 0);
            ChangeGameMode(true);
            ab_Control.SetControlView(true);
            gc = Program.gc;


        }

        public void ChangeGameMode(bool faceOff)
        {
            if (gc != null)
            {
                lbl_fram1.Text = gc.framily1;
                lbl_fram2.Text = gc.framily2;
            }


            panel2.Visible = true;
            pnl_Question.Visible = true;
            if (faceOff)
            {

                if (gc != null)
                {
                    btn_fram1.Text = gc.fram1[fram1c];
                    btn_fram2.Text = gc.fram2[fram2c];

                    fram1c = ++fram1c % gc.fram1.Count;
                    fram2c = ++fram2c % gc.fram2.Count;
                }

                btn_NewQuestion.Visible = true;
                pnl_FaceOff.Visible = true;
                pnl_NormalRound.Visible = false;
            }
            else
            {
                btn_NewQuestion.Visible = false;
                pnl_FaceOff.Visible = false;
                pnl_NormalRound.Visible = true;
            }

            pnl_FastMoney.Visible = false;

            ResizeControls();
        }

        public void StartFastMoney()
        {
            pnl_FaceOff.Visible = false;
            pnl_NormalRound.Visible = false;
            panel2.Visible = false;
            pnl_Question.Visible = false;
            pnl_FastMoney.Visible = true;

            lq = gc.fastMoney;

            UpdateQuestionText(lbl_FMA1, lq[0].text);
            UpdateQuestionText(lbl_FMA2, lq[1].text);
            UpdateQuestionText(lbl_FMA3, lq[2].text);
            UpdateQuestionText(lbl_FMA4, lq[3].text);
            UpdateQuestionText(lbl_FMA5, lq[4].text);
            fma_control.UpdateQuestions(lq);

            ResizeControls();
        }

        public void UpdateQuestion(Question q)
        {
            ChangeGameMode(true);

            ab_Control.NewQuestion(q);
            UpdateQuestionText(lbl_Question, q.text);
            strike1 = false;
            strike2 = false;
            strike3 = false;

            strikeColor(btn_Strike1, false);
            strikeColor(btn_Strike2, false);
            strikeColor(btn_Strike3, false);
        }

        private void UpdateQuestionText(Control lable, string t)
        {
            lable.Text = t;
            lable.Left = (lable.Parent.Width - lable.Width) / 2;
        }

        private void pnl_Question_Resize(object sender, EventArgs e)
        {
            lbl_Question.MaximumSize = new Size(pnl_Question.Width - 20, 0);
        }

        private void ControllerNewQuestion_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            Program.CenterControl(lbl_Question, true, false);
            Program.CenterControl(btn_NewQuestion, true, false);
            Program.CenterControl(pnl_FaceOffControls);
            Program.CenterControl(pnl_NormalRoundControls);
            Program.CenterControl(lbl_FMA1,true,false);
            Program.CenterControl(lbl_FMA2,true,false);
            Program.CenterControl(lbl_FMA3,true,false);
            Program.CenterControl(lbl_FMA4,true,false);
            Program.CenterControl(lbl_FMA5,true,false);
        }

        private void btn_NewQuestion_Click(object sender, EventArgs e)
        {
            gc.GetNewQuestion();
        }

        private void btn_play1_Click(object sender, EventArgs e)
        {
            gc.UpdateTeam(true);
            ChangeGameMode(false);
        }

        private void btn_play2_Click(object sender, EventArgs e)
        {
            gc.UpdateTeam(false);
            ChangeGameMode(false);
        }

        private void btn_Strike1_Click(object sender, EventArgs e)
        {
            strike1 = !strike1;
            strikeColor(btn_Strike1, strike1);
            gc.strikes = 1;
            gc.UpdateTeam(gc.turn);
        }

        private void btn_Strike2_Click(object sender, EventArgs e)
        {
            strike2 = !strike2;
            strikeColor(btn_Strike2, strike2);
            gc.strikes = 2;
            gc.UpdateTeam(gc.turn);
        }

        private void btn_Strike3_Click(object sender, EventArgs e)
        {
            strike3 = !strike3;
            strikeColor(btn_Strike3, strike3);
            gc.strikes = 3;
            gc.UpdateTeam(gc.turn);
        }

        private void strikeColor (Control c, bool s)
        {
            if (s)
            {
                playStrike();
                c.BackColor = Color.Red;
            }
            else
            {
                c.BackColor = Color.White;
            }
        }
        private void playStrike()
        {
            if (Program.gc.Strike.IsLoadCompleted) Program.gc.Strike.Play();
        }

        private void btn_Steal_Click(object sender, EventArgs e)
        {
            gc.UpdateTeam(!gc.turn);
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Add points?", "Are You Sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                gc.NextRound(gc.turn);
                //ChangeGameMode(true);
            }
        }

        private void getNewFastMoneyQuestion(int i, Control lable)
        {
            Question q = new Question();
            q = gc.FindFMQuestion();
            gc.fastMoney[i] = q;
            lq = gc.fastMoney;

            UpdateQuestionText(lable, lq[i].text);
            fma_control.UpdateQuestions(lq);

            ResizeControls();
        }

        private void btn_q1_Click(object sender, EventArgs e)
        {
            getNewFastMoneyQuestion(0, lbl_FMA1);
        }

        private void btn_q2_Click(object sender, EventArgs e)
        {
            getNewFastMoneyQuestion(1, lbl_FMA2);
        }

        private void btn_q3_Click(object sender, EventArgs e)
        {
            getNewFastMoneyQuestion(2, lbl_FMA3);
        }

        private void btn_q4_Click(object sender, EventArgs e)
        {
            getNewFastMoneyQuestion(3, lbl_FMA4);
        }

        private void btn_q5_Click(object sender, EventArgs e)
        {
            getNewFastMoneyQuestion(4, lbl_FMA5);
        }

        private void btn_fram1_Click(object sender, EventArgs e)
        {
            btn_fram1.Text = gc.fram1[fram1c];

            fram1c = ++fram1c % gc.fram1.Count;
        }

        private void lbl_fram1_Click(object sender, EventArgs e)
        {
            int temp = --fram1c - 1;
            if (fram1c < 0) fram1c = gc.fram1.Count - 1;
            if (temp < 0) temp = gc.fram1.Count + temp;

            btn_fram1.Text = gc.fram1[temp];
        }

        private void btn_fram2_Click(object sender, EventArgs e)
        {
            btn_fram2.Text = gc.fram2[fram2c];

            fram2c = ++fram2c % gc.fram2.Count;
        }

        private void lbl_fram2_Click(object sender, EventArgs e)
        {
            int temp = --fram2c - 1;
            if (fram2c < 0) fram2c = gc.fram2.Count - 1;
            if (temp < 0) temp = gc.fram2.Count + temp;

            btn_fram2.Text = gc.fram2[temp];
        }
    }
}
