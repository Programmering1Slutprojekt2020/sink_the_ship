using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sänka_Skepp
{
    public partial class Form1 : Form
    {




        int turn = 1;
        int runda = 0;
        bool spelarbyte = true;
        List<(int, int)> defensXYP1 = new List<(int, int)>();

        List<(int, int)> defensXYP2 = new List<(int, int)>();

        List<(int, int)> attackXYP1miss = new List<(int, int)>();

        List<(int, int)> attackXYP2miss = new List<(int, int)>();

        List<(int, int)> attackXYP1Hit = new List<(int, int)>();

        List<(int, int)> attackXYP2Hit = new List<(int, int)>();

        public Form1()
        {
            InitializeComponent();


        }



        private void attack_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush ljusBlå = new SolidBrush(Color.DodgerBlue);
            SolidBrush mörkblå = new SolidBrush(Color.Blue);
            SolidBrush svart = new SolidBrush(Color.Black);
            SolidBrush mörkareblå = new SolidBrush(Color.DarkBlue);

            SolidBrush miss = mörkareblå;

            //måla attack-rutorna blåa
            for (int k = 0; k < 8; k++)
            {

                for (int i = 0; i < 8; i++)
                {

                    g.FillRectangle(ljusBlå, (110 * i)+ 10, (110 * k) + 10, 100, 100);

                }
            }



            if (turn == 1)
            {
                foreach ((int x, int y) in attackXYP1miss)
                {
                    g.FillEllipse(miss, (110 * x) + 20, (110 * y) + 20, 80, 80);

                }

                foreach ((int x, int y) in attackXYP1Hit)
                {
                    g.FillRectangle(svart, (110 * x) + 20, (110 * y) + 20, 80, 80);

                }
                //turn = 2;
            }
            else
            {
                foreach ((int x, int y) in attackXYP2miss)
                {
                    g.FillEllipse(miss, (110 * x) + 20, (110 * y) + 20, 80, 80);

                }

                foreach ((int x, int y) in attackXYP2Hit)
                {
                    g.FillRectangle(svart, (110 * x) + 20, (110 * y) + 20, 80, 80);

                }
                //turn = 1;
            }

        }

        private void attack_MouseClick(object sender, MouseEventArgs e)
        {
            if (turn == 1)
            {
                if (defensXYP2.Contains((e.X / 110, e.Y / 110)))
                {
                    attackXYP1Hit.Add((e.X / 110, e.Y / 110));
                    attack.Invalidate();
                }
                else
                {
                    attackXYP1miss.Add((e.X / 110, e.Y / 110));
                    attack.Invalidate();
                }
                
            }

            else
            {
                if (defensXYP1.Contains((e.X / 110, e.Y / 110)))
                {
                    attackXYP2Hit.Add((e.X / 110, e.Y / 110));
                    attack.Invalidate();
                }
                else
                {
                    attackXYP2miss.Add((e.X / 110, e.Y / 110));
                    attack.Invalidate();
                }
                
            }
        }

        private void defens_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush ljusBlå = new SolidBrush(Color.DodgerBlue);
            SolidBrush mörkblå = new SolidBrush(Color.Blue);
            SolidBrush gråaktig = new SolidBrush(Color.DarkSlateGray);
            SolidBrush körgrön = new SolidBrush(Color.LightGreen);


            //måla defens-rutorna blåa
            for (int k = 0; k < 8; k++)
            {

                for (int i = 0; i < 8; i++)
                {

                    g.FillRectangle(ljusBlå, (50 * i) + 5, (50 * k) + 5, 45, 45);

                }
            }

            //måla sina båtar
            if (spelarbyte)
            {
                g.FillRectangle(körgrön, 105, 105, 195, 195);
                runda++;
            }

            else
            {
                if (turn == 1)
                {
                    foreach ((int x, int y) in defensXYP1)
                    {
                        g.FillRectangle(gråaktig, x * 50 + 5, y * 50 + 5, 45, 45);

                    }

                }
                else
                {
                    foreach ((int x, int y) in defensXYP2)
                    {
                        g.FillRectangle(gråaktig, x * 50 + 5, y * 50 + 5, 45, 45);
                    }

                }
            }

                
        }

        private void defens_MouseClick(object sender, MouseEventArgs e)
        {
            if (spelarbyte)
            {
                spelarbyte = false;
                defens.Invalidate();
            }

            else
            {
                if (turn == 1)
                {
                    if (!defensXYP1.Contains((e.X / 50, e.Y / 50)))
                    {
                        defensXYP1.Add((e.X / 50, e.Y / 50));
                        defens.Invalidate();
                    }

                }
                else
                {
                    if (!defensXYP2.Contains((e.X / 50, e.Y / 50)))
                    {
                        defensXYP2.Add((e.X / 50, e.Y / 50));
                        defens.Invalidate();
                    }


                }
            }


        }

        private void färdig_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                turn = 2;
            }
            else
            {
                turn = 1;
            }
            Playerturn.Text = "Playerturn: " + turn;
            spelarbyte = true;
            defens.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Playerturn_Click(object sender, EventArgs e)
        {

        }
    }
}
