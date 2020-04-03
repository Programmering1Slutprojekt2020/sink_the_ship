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


        List<(int, int)> defensXY = new List<(int, int)>();



        public Form1()
        {
            InitializeComponent();


        }



        private void attack_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush ljusBlå = new SolidBrush(Color.DodgerBlue);
            SolidBrush mörkblå = new SolidBrush(Color.Blue);


            //måla attack-rutorna blåa
             for (int k = 0; k < 8; k++)
            {

                for (int i = 0; i < 8; i++)
                {

                    g.FillRectangle(ljusBlå, (110 * i)+ 10, (110 * k) + 10, 100, 100);

                }
            }
        }



        private void defens_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush ljusBlå = new SolidBrush(Color.DodgerBlue);
            SolidBrush mörkblå = new SolidBrush(Color.Blue);
            SolidBrush gråaktig = new SolidBrush(Color.DarkSlateGray);


            //måla defens-rutorna blåa
            for (int k = 0; k < 8; k++)
            {

                for (int i = 0; i < 8; i++)
                {

                    g.FillRectangle(ljusBlå, (50 * i) + 5, (50 * k) + 5, 45, 45);

                }
            }

            //måla sina båtar
            foreach( (int x, int y)  in defensXY)
            {
                g.FillRectangle(gråaktig, x * 50 +5, y * 50 +5, 45, 45);
            }

                
        }

        private void defens_MouseClick(object sender, MouseEventArgs e)
        {
            defensXY.Add((e.X/50, e.Y/50));
            defens.Invalidate();
        }
    }
}
