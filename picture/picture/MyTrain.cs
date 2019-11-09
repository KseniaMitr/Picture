using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace picture
{
    class MyTrain : MyFigure
    {
        List<MyVagon> vagons = new List<MyVagon>();
        private int width;
        private int height;
        private int countVagons;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int CountVagons
        {
            get { return countVagons; }
            set { countVagons = value; }
        }

        public MyTrain (int x, int y, int widht, int height, int count)
        {
            CountVagons = count;

            int widVag = widht / count -1;
            int heigVag = height;

            for (int i=0; i < CountVagons; i++)
            {
                MyVagon vag = new MyVagon(x + i * widVag, y, widVag-14, heigVag);
                vagons.Add(vag);
            }
        }

        public override void Draw(Graphics g)
        {
            foreach (MyVagon v in vagons)
            {
               v.Draw(g);
            }
        }

        public override bool isPointInside(int x, int y)
        {
            bool move = false;
            if (x >= X && x <= (X + Width) && y >= Y && y <= (Y + Height))
            {
                move = true;                              
            }
            return move;
        }

        public override void Move(int x, int y)
        {           
            base.Move(x, y);
        }
    }
}
