using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace picture
{
    class MyVagon: MyRectangle
    {
        MyCircle wheel1 = new MyCircle(0, 0, 0);
        MyCircle wheel2 = new MyCircle(0, 0, 0);


        public MyVagon(int x, int y, int widht, int height) : base (x, y, x + widht, y + height)
        {
            X = x;
            Y = y;
            Width = widht;
            Height = height;

            int radCirc = Width / 10;

            int xCirc1 = X + radCirc;
            int xCirc2 = X + radCirc+ 3 * Width / 5;
            int yCirc = Y + Height;           

            wheel1.X = xCirc1;
            wheel1.Y = yCirc;
            wheel1.Radius = radCirc;

            wheel2.X = xCirc2;
            wheel2.Y = yCirc;
            wheel2.Radius = radCirc;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            wheel1.Draw(g);
            wheel2.Draw(g);
        }

        public override bool isPointInside(int x, int y)
        {         
            bool move = false;
            if (x >= this.X && x <= (this.X + this.Width) && y >= this.Y && y <= (this.Y + this.Height))
            {
                move = true;                              /////проверка нажатия на прямоуг.
            } 
            
            //else
            //{
            //    int xZentr1 = X + wheel1.Radius;         /////проверка нажатия на 1 колесо
            //    int yZentr1 = Y + wheel1.Radius;

            //    int xNowrad1 = Math.Abs(xZentr1 - x);
            //    int yNowrad1 = Math.Abs(yZentr1 - y);
            //    int Nowrad1 = (int)Math.Sqrt(Math.Pow(xNowrad1, 2) + Math.Pow(yNowrad1, 2));

            //    if (Nowrad1 <= wheel1.Radius) move = true;


            //    int xZentr2 = X + wheel1.Radius;           /////проверка нажатия на 2 колесо
            //    int yZentr2 = Y + wheel1.Radius;

            //    int xNowrad2 = Math.Abs(xZentr2 - x);
            //    int yNowrad2 = Math.Abs(yZentr2 - y);
            //    int Nowrad2 = (int)Math.Sqrt(Math.Pow(xNowrad2, 2) + Math.Pow(yNowrad2, 2));

            //    if (Nowrad2 <= wheel2.Radius) move = true;
            //}

            return move;
        }

    }
}
