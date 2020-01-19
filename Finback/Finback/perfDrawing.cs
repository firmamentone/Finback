//JAN 19 2020 T.I. Created this file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Finback
{
    class perfDrawing
    {

        public perfDrawing()
        {


        }
        public Bitmap drawingTest()
        {
            Bitmap DrawArea;
            Graphics g;
            DrawArea = new Bitmap(300, 300);


            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Black);

            g.DrawLine(mypen, 0, 0, 200, 150);

            return DrawArea;
        }
        public Bitmap draw24x30(int scale=10)
        {
            Bitmap DrawArea;
            Graphics g;
            DrawArea = new Bitmap(400, 400);
            int GridStartX = 0, GridStartY = 0;
            int GridEndX = 1* scale, GridEndY = 1* scale;
            int i = 0,j=0;

            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Black);

            for(i=0;i<30;i++)
            {
                for(j = 0; j < 24; j++)
                {
                    g.DrawRectangle(mypen, GridStartX, GridStartY, GridEndX, GridEndY);
                    GridStartX = GridStartX + GridEndX;
                }
                GridStartY = GridStartY+ GridEndY;
                GridStartX = 0;
            }
            

            return DrawArea;
        }
    }
}
