using Framily_Fracas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framily_Fracas.UserControls
{
    public partial class FastMoneyAnswer : UserControl
    {
        private Question question;
        private int points;
        private string text;
        public int place;
        private FMAnswer fma = new FMAnswer();
        public FastMoneyAnswer()
        {
            InitializeComponent();
        }
        
        public void ShowButton(bool s)
        {
            btn_FMAF.Visible = s;
            panel3.Visible = s;
        }

        public void SetQuestion(Question q)
        {
            question = q;
        }

        public void SetValues(int p, String t)
        {
            fma.points = p;
            fma.text = t;
            lbl_Points.Text = fma.points.ToString();
            txt_Answer.Text = fma.text;
        }

        public void SetValues(FMAnswer f)
        {
            fma = f;
            lbl_Points.Text = fma.points.ToString();
            txt_Answer.Text = fma.text;
        }

        public void SetPlace(int pl)
        {
            fma.place = pl;
            place = pl;
        }
        private void ResizeControls()
        {
            txt_Answer.Size = new Size(panel2.Width - 100, txt_Answer.Size.Height);
            lbl_Points.Left = txt_Answer.Left + txt_Answer.Size.Width + 15;

            Program.CenterControl(txt_Answer, false, true);
            Program.CenterControl(lbl_Points, false, true);
            Program.CenterControl(btn_FMAF, false, true);
        }

        private void FastMoneyAnswer_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void btn_FMAF_Click(object sender, EventArgs e)
        {
            fma.text = txt_Answer.Text;
            FastMoneyAnswers fmas = new FastMoneyAnswers(question,fma);
            fmas.Show();
        }

        public void ClearAnswer()
        {
            lbl_Points.Text = "";
            txt_Answer.Text = "";
            fma = new FMAnswer();
        }
    }
}
