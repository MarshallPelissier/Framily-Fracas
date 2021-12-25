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
    public partial class SurveyBoard : Form
    {
        private GameController gc;

        private bool play = false;
        public SurveyBoard()
        {
            InitializeComponent();
            NewSetup();
            fma_Main.ShowButtons(false);
        }

        private void SurveyBoard_Resize(object sender, EventArgs e)
        {
            Program.CenterControl(pnl_Scores);
        }

        public void UpdateQuestion(Question q)
        {
            ab_Main.NewQuestion(q);
        }

        public void UpdateAnswers(Answer a)
        {
            ab_Main.UpdateAnswers(a);
        }

        public void UpdateAnswers(FMAnswer a)
        {
            fma_Main.UpdateAnswers(a);
        }

        public void UpdateNames()
        {
            lbl_Framily1.Text = gc.framily1;
            lbl_Framily2.Text = gc.framily2;
        }
        public void UpdateScores()
        {
            lbl_fram1val.Text = gc.FramPoints1.ToString();
            lbl_fram2val.Text = gc.FramPoints2.ToString();
            lbl_rndval.Text = (gc.round + 1).ToString();
        }

        public void UpdateTeam(bool visible = true)
        {
            if (visible)
            {
                if (gc.turn)
                {
                    lbl_fram1_indicator.Visible = true;
                    lbl_fram2_indicator.Visible = false;
                    if (gc.strikes > 0) lbl_fram1_indicator.Text = gc.strikes.ToString();
                    else lbl_fram1_indicator.Text = "";
                }
                else
                {
                    lbl_fram1_indicator.Visible = false;
                    lbl_fram2_indicator.Visible = true;
                    if (gc.strikes > 0) lbl_fram2_indicator.Text = gc.strikes.ToString();
                    else lbl_fram2_indicator.Text = "";
                }
            }
            else
            {
                lbl_fram1_indicator.Visible = false;
                lbl_fram2_indicator.Visible = false;
                lbl_fram2_indicator.Text = "";
                lbl_fram2_indicator.Text = "";
            }
        }

        public void StartFastMoney()
        {
            fma_Main.clearAnswerControls();
            fma_Main.Visible = true;
            ab_Main.Visible = false;
        }

        public void NewSetup()
        {
            Setup set = new Setup();
            set.Show();
            gc = Program.gc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.gc.Strike.IsLoadCompleted) Program.gc.Strike.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (play)
            {
                if (Program.gc.Theme.IsLoadCompleted) Program.gc.Theme.Stop();
            }
            else
            {
                if(Program.gc.Theme.IsLoadCompleted) Program.gc.Theme.Play();
            }
            play = !play;
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            NewSetup();
            gc.round = 0;
            gc.FramPoints1 = 0;
            gc.FramPoints2 = 0;
            fma_Main.Visible = false;
            ab_Main.Visible = true;
        }

        private void btn_FastMoney_Click(object sender, EventArgs e)
        {
            gc.StartFastMoney();
        }
    }
}
