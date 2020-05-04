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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.attack = new System.Windows.Forms.Panel();
            this.defens = new System.Windows.Forms.Panel();
            this.färdig = new System.Windows.Forms.Button();
            this.Playerturn = new System.Windows.Forms.Label();
            this.antalSkepp = new System.Windows.Forms.TextBox();
            this.skeppAllowed = new System.Windows.Forms.Label();
            this.vinnare1 = new System.Windows.Forms.PictureBox();
            this.vinnare2 = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vinnare1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinnare2)).BeginInit();
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
            // antalSkepp
            // 
            this.antalSkepp.Location = new System.Drawing.Point(1190, 592);
            this.antalSkepp.Name = "antalSkepp";
            this.antalSkepp.Size = new System.Drawing.Size(33, 20);
            this.antalSkepp.TabIndex = 6;
            this.antalSkepp.Text = "5";
            this.antalSkepp.TextChanged += new System.EventHandler(this.antalSkepp_TextChanged);
            // 
            // skeppAllowed
            // 
            this.skeppAllowed.AutoSize = true;
            this.skeppAllowed.Location = new System.Drawing.Point(1004, 595);
            this.skeppAllowed.Name = "skeppAllowed";
            this.skeppAllowed.Size = new System.Drawing.Size(180, 13);
            this.skeppAllowed.TabIndex = 7;
            this.skeppAllowed.Text = "Antal båtar som man ska skjutas ner:";
            this.skeppAllowed.Click += new System.EventHandler(this.label1_Click);
            // 
            // vinnare1
            // 
            this.vinnare1.Image = ((System.Drawing.Image)(resources.GetObject("vinnare1.Image")));
            this.vinnare1.Location = new System.Drawing.Point(273, 46);
            this.vinnare1.Name = "vinnare1";
            this.vinnare1.Size = new System.Drawing.Size(800, 800);
            this.vinnare1.TabIndex = 0;
            this.vinnare1.TabStop = false;
            this.vinnare1.Visible = false;
            // 
            // vinnare2
            // 
            this.vinnare2.Image = ((System.Drawing.Image)(resources.GetObject("vinnare2.Image")));
            this.vinnare2.Location = new System.Drawing.Point(293, 46);
            this.vinnare2.Name = "vinnare2";
            this.vinnare2.Size = new System.Drawing.Size(843, 822);
            this.vinnare2.TabIndex = 8;
            this.vinnare2.TabStop = false;
            this.vinnare2.Visible = false;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(1225, 873);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 9;
            this.restart.Text = "restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 961);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.vinnare2);
            this.Controls.Add(this.vinnare1);
            this.Controls.Add(this.skeppAllowed);
            this.Controls.Add(this.antalSkepp);
            this.Controls.Add(this.Playerturn);
            this.Controls.Add(this.färdig);
            this.Controls.Add(this.defens);
            this.Controls.Add(this.attack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vinnare1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinnare2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel attack;
        private System.Windows.Forms.Panel defens;
        private System.Windows.Forms.Button färdig;
        private System.Windows.Forms.Label Playerturn;
        private System.Windows.Forms.TextBox antalSkepp;
        private System.Windows.Forms.Label skeppAllowed;
        private System.Windows.Forms.PictureBox vinnare1;
        private System.Windows.Forms.PictureBox vinnare2;
        private System.Windows.Forms.Button restart;
    }
}

