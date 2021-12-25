
namespace Framily_Fracas
{
    partial class Controller
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
            this.controllerNewQuestion1 = new Framily_Fracas.ControllerNewQuestion();
            this.SuspendLayout();
            // 
            // controllerNewQuestion1
            // 
            this.controllerNewQuestion1.BackColor = System.Drawing.SystemColors.Control;
            this.controllerNewQuestion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerNewQuestion1.Location = new System.Drawing.Point(5, 5);
            this.controllerNewQuestion1.Name = "controllerNewQuestion1";
            this.controllerNewQuestion1.Size = new System.Drawing.Size(874, 951);
            this.controllerNewQuestion1.TabIndex = 0;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(884, 961);
            this.Controls.Add(this.controllerNewQuestion1);
            this.Name = "Controller";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private ControllerNewQuestion controllerNewQuestion1;
    }
}