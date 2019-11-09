using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace picture
{
    class MyVagonSand : MyVagon
    {
        MyVagon vagon = new MyVagon(0, 0, 0, 0);

        public MyVagonSand(int x, int y, int widht, int height) : base(x, y, widht,  height)
        {
            //vagon.X = x;
            //vagon.Y = y;
            //vagon.Width = widht;
            //vagon.Height = height;  
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            SolidBrush br = new SolidBrush(Color.Yellow);
            g.FillRectangle(br, X + 10, Y - 10, Width - 20, 10);
            Point p1 = new Point(X,Y);
            Point p2 = new Point(X+Width/2, Y-40);
            Point p3 = new Point(X + Width, Y);          
            g.FillPolygon(br,new PointF[] { p1, p2, p3 });
        }

        public override bool isPointInside(int x, int y)
        {
            bool move = false;
            if (x >= X && x <= (X + Width) && y >= Y && y <= (Y + Height))
            {
                move = true;                              /////проверка нажатия на прямоуг.
            }
            return move;
        }

        public override void Move(int x, int y)
        {
            base.Move(x, y);
        }
    }
}
