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
        bool valtfärdigt = false;
        

        List<(int, int)> defensXYP1 = new List<(int, int)>();

        List<(int, int)> defensXYP2 = new List<(int, int)>();

        List<(int, int)> attackXYP1miss = new List<(int, int)>();

        List<(int, int)> attackXYP2miss = new List<(int, int)>();

        List<(int, int)> attackXYP1Hit = new List<(int, int)>();

        List<(int, int)> attackXYP2Hit = new List<(int, int)>();

        SolidBrush körgrön = new SolidBrush(Color.LightGreen);

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
            SolidBrush väntaröd = new SolidBrush(Color.OrangeRed);

            SolidBrush miss = mörkareblå;

            //måla attack-rutorna blåa
            for (int k = 0; k < 8; k++)
            {

                for (int i = 0; i < 8; i++)
                {

                    g.FillRectangle(ljusBlå, (110 * i)+ 10, (110 * k) + 10, 100, 100);

                }
            }

            if (!valtfärdigt)
            {
                g.FillRectangle(väntaröd, 297, 297, 297 ,297);
            }
            else
            {
                if (spelarbyte)
                {
                    g.FillRectangle(körgrön, 297, 297, 297, 297);

                }
                else
                {
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
            }

        }

        private void attack_MouseClick(object sender, MouseEventArgs e)
        {
            if (valtfärdigt)
            {
                if (spelarbyte)
                {
                    spelarbyte = false;
                    attack.Invalidate();
                }
                else
                {
                    if (turn == 1)
                    {
                        if ((attackXYP1Hit.Count + attackXYP1miss.Count) < runda)
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

                    }


                    else
                    {

                        if ((attackXYP2Hit.Count + attackXYP2miss.Count +1) < runda)
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
                }
            }
            //p1 vinner
            if (attackXYP1Hit.Count == defensXYP2.Count)
            {

                attack.Visible = false;
                defens.Visible = false;
                Playerturn.Visible = false;
                färdig.Visible = false;
                vinnare1.Visible = true;
            }
            //p2 vinner
            if (attackXYP2Hit.Count == defensXYP1.Count)
            {

                attack.Visible = false;
                defens.Visible = false;
                Playerturn.Visible = false;
                färdig.Visible = false;
                vinnare2.Visible = true;
            }
        }

        private void defens_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush ljusBlå = new SolidBrush(Color.DodgerBlue);
            SolidBrush mörkblå = new SolidBrush(Color.Blue);
            SolidBrush gråaktig = new SolidBrush(Color.DarkSlateGray);
            SolidBrush färdigröd = new SolidBrush(Color.OrangeRed);



            //måla defens-rutorna blåa
            for (int k = 0; k < 8; k++)
            {

                for (int i = 0; i < 8; i++)
                {

                    g.FillRectangle(ljusBlå, (50 * i) + 5, (50 * k) + 5, 45, 45);

                }
            }
            if (valtfärdigt)
            {
                g.FillRectangle(färdigröd, 0, 0, 410, 410);
            }
            else
            {

                if (runda < 2)
                {
                    //måla sina båtar
                    if (spelarbyte)
                    {
                        g.FillRectangle(körgrön, 105, 105, 195, 195);

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
                else
                {
                    valtfärdigt = true;
                    defens.Invalidate();
                }
            }

                
        }

        private void defens_MouseClick(object sender, MouseEventArgs e)
        {

            antalSkepp.Visible = false;
            skeppAllowed.Visible = false;

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
                        if (defensXYP1.Count < int.Parse(antalSkepp.Text))
                        {
                            defensXYP1.Add((e.X / 50, e.Y / 50));
                        }
                        defens.Invalidate();
                    }

                }
                else
                {
                    if (!defensXYP2.Contains((e.X / 50, e.Y / 50)))
                    {
                        if (defensXYP2.Count < int.Parse(antalSkepp.Text))
                        {
                            defensXYP2.Add((e.X / 50, e.Y / 50));
                        }
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
            runda++;
            defens.Invalidate();
            attack.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Playerturn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void antalSkepp_TextChanged(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            defensXYP1.Clear();
            defensXYP2.Clear();

            attackXYP1Hit.Clear();
            attackXYP1miss.Clear();

            attackXYP2Hit.Clear();
            attackXYP2miss.Clear();

            turn = 1;
            runda = 0;
            spelarbyte = true;
            valtfärdigt = false;

            attack.Visible = true;
            defens.Visible = true;
            Playerturn.Visible = true;
            färdig.Visible = true;
            vinnare2.Visible = false;
            vinnare1.Visible = false;

            attack.Invalidate();
            defens.Invalidate();
        }
    }
}
