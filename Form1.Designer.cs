namespace Sänka_Skepp
{
    partial class Form1
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
            this.attack = new System.Windows.Forms.Panel();
            this.defens = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(36, 35);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(800, 800);
            this.attack.TabIndex = 0;
            this.attack.Paint += new System.Windows.Forms.PaintEventHandler(this.attack_Paint);
            // 
            // defens
            // 
            this.defens.Location = new System.Drawing.Point(923, 35);
            this.defens.Name = "defens";
            this.defens.Size = new System.Drawing.Size(400, 400);
            this.defens.TabIndex = 1;
            this.defens.Paint += new System.Windows.Forms.PaintEventHandler(this.defens_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 961);
            this.Controls.Add(this.defens);
            this.Controls.Add(this.attack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attack;
        private System.Windows.Forms.Panel defens;
    }
}

