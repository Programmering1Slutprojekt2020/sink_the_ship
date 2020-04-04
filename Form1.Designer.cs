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
            this.färdig = new System.Windows.Forms.Button();
            this.Playerturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attack
            // 
            this.attack.BackColor = System.Drawing.Color.Blue;
            this.attack.Location = new System.Drawing.Point(27, 12);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(890, 890);
            this.attack.TabIndex = 0;
            this.attack.Paint += new System.Windows.Forms.PaintEventHandler(this.attack_Paint);
            this.attack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.attack_MouseClick);
            // 
            // defens
            // 
            this.defens.BackColor = System.Drawing.Color.Blue;
            this.defens.Location = new System.Drawing.Point(960, 22);
            this.defens.Name = "defens";
            this.defens.Size = new System.Drawing.Size(405, 405);
            this.defens.TabIndex = 1;
            this.defens.Paint += new System.Windows.Forms.PaintEventHandler(this.defens_Paint);
            this.defens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.defens_MouseClick);
            // 
            // färdig
            // 
            this.färdig.Location = new System.Drawing.Point(1190, 494);
            this.färdig.Name = "färdig";
            this.färdig.Size = new System.Drawing.Size(75, 23);
            this.färdig.TabIndex = 3;
            this.färdig.Text = "Färdig!";
            this.färdig.UseVisualStyleBackColor = true;
            this.färdig.Click += new System.EventHandler(this.färdig_Click);
            // 
            // Playerturn
            // 
            this.Playerturn.AutoSize = true;
            this.Playerturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playerturn.Location = new System.Drawing.Point(923, 724);
            this.Playerturn.Name = "Playerturn";
            this.Playerturn.Size = new System.Drawing.Size(411, 76);
            this.Playerturn.TabIndex = 5;
            this.Playerturn.Text = "Playerturn: 1";
            this.Playerturn.Click += new System.EventHandler(this.Playerturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 961);
            this.Controls.Add(this.Playerturn);
            this.Controls.Add(this.färdig);
            this.Controls.Add(this.defens);
            this.Controls.Add(this.attack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel attack;
        private System.Windows.Forms.Panel defens;
        private System.Windows.Forms.Button färdig;
        private System.Windows.Forms.Label Playerturn;
    }
}

