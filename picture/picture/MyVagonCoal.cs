using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace picture
{
    class MyVagonCoal : MyVagon
    {
        MyVagon vagon = new MyVagon(0, 0, 0, 0);

        public MyVagonCoal(int x, int y, int widht, int height) : base(x, y, widht,height)
        {
            vagon.X = x;
            vagon.Y = y;
            vagon.Width = widht;
            vagon.Height = height;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);           
            SolidBrush br = new SolidBrush(Color.Black);
            g.FillRectangle(br, X + 10, Y - 15, Width - 20, 10);

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
