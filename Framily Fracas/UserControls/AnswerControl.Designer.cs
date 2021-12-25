
namespace Framily_Fracas
{
    partial class AnswerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.pnl_Answer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Points = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_Answer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_Answer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 132);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Answer_MouseClick);
            this.panel1.MouseEnter += new System.EventHandler(this.pnl_Answer_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.pnl_Answer_MouseLeave);
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Answer.Location = new System.Drawing.Point(48, 54);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(175, 34);
            this.lbl_Answer.TabIndex = 0;
            this.lbl_Answer.Text = "Good Answer";
            this.lbl_Answer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Answer_MouseClick);
            this.lbl_Answer.MouseEnter += new System.EventHandler(this.pnl_Answer_MouseEnter);
            this.lbl_Answer.MouseLeave += new System.EventHandler(this.pnl_Answer_MouseLeave);
            // 
            // pnl_Answer
            // 
            this.pnl_Answer.BackColor = System.Drawing.Color.White;
            this.pnl_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Answer.Controls.Add(this.panel1);
            this.pnl_Answer.Controls.Add(this.panel2);
            this.pnl_Answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Answer.Location = new System.Drawing.Point(5, 5);
            this.pnl_Answer.Name = "pnl_Answer";
            this.pnl_Answer.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_Answer.Size = new System.Drawing.Size(390, 140);
            this.pnl_Answer.TabIndex = 1;
            this.pnl_Answer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Answer_MouseClick);
            this.pnl_Answer.MouseEnter += new System.EventHandler(this.pnl_Answer_MouseEnter);
            this.pnl_Answer.MouseLeave += new System.EventHandler(this.pnl_Answer_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lbl_Points);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(285, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 132);
            this.panel2.TabIndex = 1;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Answer_MouseClick);
            this.panel2.MouseEnter += new System.EventHandler(this.pnl_Answer_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.pnl_Answer_MouseLeave);
            // 
            // lbl_Points
            // 
            this.lbl_Points.AutoSize = true;
            this.lbl_Points.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Points.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Points.Location = new System.Drawing.Point(21, 49);
            this.lbl_Points.Name = "lbl_Points";
            this.lbl_Points.Size = new System.Drawing.Size(58, 45);
            this.lbl_Points.TabIndex = 1;
            this.lbl_Points.Text = "00";
            this.lbl_Points.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Answer_MouseClick);
            this.lbl_Points.MouseEnter += new System.EventHandler(this.pnl_Answer_MouseEnter);
            this.lbl_Points.MouseLeave += new System.EventHandler(this.pnl_Answer_MouseLeave);
            // 
            // AnswerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pnl_Answer);
            this.Name = "AnswerControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(400, 150);
            this.Click += new System.EventHandler(this.AnswerControl_Click);
            this.Resize += new System.EventHandler(this.AnswerControl_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Answer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Panel pnl_Answer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Points;
    }
}
