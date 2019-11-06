using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture
{
    public partial class drawing_machine : Form
    {
        public drawing_machine()
        {
            InitializeComponent();
        }
        
        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        List<MyFigure> figure = new List<MyFigure>();
        int k = 0;
        int startX = 0;
        int startY = 0;
        int numF = -1;
        bool move = false;
        

        public void DrawRectangle(int x, int y, int width, int height)
        {
            Graphics g = CreateGraphics();
            MyRectangle rect = new MyRectangle(x, y, width, height);
            figure.Add(rect);
        }

        public void DrawCircle(int x, int y, int rad)
        {
            Graphics g = CreateGraphics();
            MyCircle circ = new MyCircle(x, y, rad);
            figure.Add(circ);
        }

        public void DrawVagon(int x, int y, int wid, int heig)
        {
            Graphics g = CreateGraphics();
            MyVagon vagon = new MyVagon(x, y, wid, heig);
            figure.Add(vagon);
        }


        private void RectBut_Click(object sender, EventArgs e)
        {
            k = 1;
        }

        private void CirclBut_Click(object sender, EventArgs e)
        {
            k = 2;
        }
        private void butMoving_Click(object sender, EventArgs e)
        {
            k = 3;
            numF = -1;
        }

        private void butVagon_Click(object sender, EventArgs e)
        {
            k = 4;
        }

        private void drawing_machine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();

            foreach (MyFigure rect in figure)
            {
                rect.Draw(g);
            }

            foreach (MyFigure circ in figure)
            {
                circ.Draw(g);
            }

            foreach (MyFigure vagon in figure)
            {
                vagon.Draw(g);
            }
        }   
        
        private void drawing_machine_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.Location.X;
            startY = e.Location.Y;

            if (k == 3)
            {
                for (int i = 0; i < figure.Count; i++)
                {
                    move = figure[i].isPointInside(e.Location.X, e.Location.Y);
                    if (move)
                    {
                        numF = i;                        
                        break;
                    }
                }
            }
        }          
       

        private void drawing_machine_MouseUp(object sender, MouseEventArgs e)
        {
            switch (k)
            {
                case 1:
                    if (startX < e.Location.X && startY < e.Location.Y)
                        DrawRectangle(startX, startY, e.Location.X - startX, e.Location.Y - startY);

                    if (startX > e.Location.X && startY < e.Location.Y)
                        DrawRectangle(e.Location.X, startY, startX - e.Location.X, e.Location.Y - startY);

                    if (startX > e.Location.X && startY > e.Location.Y)
                        DrawRectangle(e.Location.X, e.Location.Y, startX - e.Location.X, startY - e.Location.Y);

                    if (startX < e.Location.X && startY > e.Location.Y)
                        DrawRectangle(startX, e.Location.Y, e.Location.X - startX, startY - e.Location.Y);
                    break;

                case 2:
                    int xrad = Math.Abs(startX - e.Location.X);
                    int yrad = Math.Abs(startY - e.Location.Y);
                    int rad = (int)Math.Sqrt(Math.Pow(xrad, 2) + Math.Pow(yrad, 2));
                    DrawCircle(startX - rad, startY - rad, rad);
                    break;

                case 4:
                    if (startX < e.Location.X && startY < e.Location.Y)
                        DrawVagon(startX, startY, e.Location.X - startX, e.Location.Y - startY);

                    if (startX > e.Location.X && startY < e.Location.Y)
                        DrawVagon(e.Location.X, startY, startX - e.Location.X, e.Location.Y - startY);

                    if (startX > e.Location.X && startY > e.Location.Y)
                        DrawVagon(e.Location.X, e.Location.Y, startX - e.Location.X, startY - e.Location.Y);

                    if (startX < e.Location.X && startY > e.Location.Y)
                        DrawVagon(startX, e.Location.Y, e.Location.X - startX, startY - e.Location.Y);
                    break;
            }

            if (move)
            {               
                figure[numF].X = e.Location.X;
                figure[numF].Y = e.Location.Y; 
            }

            Refresh();
        }
       
    }
}
