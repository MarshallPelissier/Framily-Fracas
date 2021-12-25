
namespace Framily_Fracas.Classes
{
    partial class FastMoneyAnswers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ab_fma = new Framily_Fracas.AnswerBoard();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_Text = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.pnl_Controls.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_Text.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ab_fma
            // 
            this.ab_fma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ab_fma.Location = new System.Drawing.Point(0, 100);
            this.ab_fma.Margin = new System.Windows.Forms.Padding(10);
            this.ab_fma.Name = "ab_fma";
            this.ab_fma.Size = new System.Drawing.Size(884, 461);
            this.ab_fma.TabIndex = 0;
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.pnl_Buttons);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 561);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(884, 100);
            this.pnl_Controls.TabIndex = 1;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.btn_Done);
            this.pnl_Buttons.Controls.Add(this.btn_Back);
            this.pnl_Buttons.Location = new System.Drawing.Point(133, 9);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(618, 82);
            this.pnl_Buttons.TabIndex = 11;
            // 
            // btn_Done
            // 
            this.btn_Done.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Done.Location = new System.Drawing.Point(332, 21);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(75, 40);
            this.btn_Done.TabIndex = 9;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back.Location = new System.Drawing.Point(212, 21);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 40);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_Text
            // 
            this.pnl_Text.Controls.Add(this.panel4);
            this.pnl_Text.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Text.Location = new System.Drawing.Point(0, 0);
            this.pnl_Text.Name = "pnl_Text";
            this.pnl_Text.Size = new System.Drawing.Size(884, 100);
            this.pnl_Text.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_Answer);
            this.panel4.Controls.Add(this.lbl_Question);
            this.panel4.Location = new System.Drawing.Point(12, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 82);
            this.panel4.TabIndex = 11;
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.Location = new System.Drawing.Point(336, 50);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(189, 27);
            this.lbl_Answer.TabIndex = 3;
            this.lbl_Answer.Text = "_________ Seven";
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(336, 6);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(189, 27);
            this.lbl_Question.TabIndex = 2;
            this.lbl_Question.Text = "_________ Seven";
            // 
            // FastMoneyAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.ab_fma);
            this.Controls.Add(this.pnl_Text);
            this.Controls.Add(this.pnl_Controls);
            this.Name = "FastMoneyAnswers";
            this.Text = "FastMoneyAnswer";
            this.Resize += new System.EventHandler(this.FastMoneyAnswers_Resize);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_Text.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AnswerBoard ab_fma;
        private System.Windows.Forms.Panel pnl_Controls;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_Text;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Label lbl_Question;
    }
}