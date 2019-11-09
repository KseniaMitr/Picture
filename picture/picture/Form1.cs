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
        
        int startX = 0;
        int startY = 0;       
        bool move = false;
        int count = 1;
        MyFigure currentMoveFigure;

        enum buttonAction { rectangle, circle, vagon, vagonCoal, vagonSand, train, move};
        buttonAction currentAction;

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

        public void DrawVagonCoal (int x, int y, int wid, int heig)
        {
            Graphics g = CreateGraphics();
            MyVagonCoal vagC = new MyVagonCoal(x, y, wid, heig);
            figure.Add(vagC);
        }

        public void DrawVagonSand(int x, int y, int wid, int heig)
        {
            Graphics g = CreateGraphics();
            MyVagonSand vagS = new MyVagonSand(x, y, wid, heig);
            figure.Add(vagS);
        }

        public void DrawTrain(int x, int y, int wid, int heig)
        {
            Graphics g = CreateGraphics();
            MyTrain train = new MyTrain(x, y, wid, heig,count);
            figure.Add(train);
        }

        private void RectBut_Click(object sender, EventArgs e)
        {
            currentAction = buttonAction.rectangle;
            move = false;
        }

        private void CirclBut_Click(object sender, EventArgs e)
        {
            currentAction = buttonAction.circle;
            move = false;
        }        

        private void butVagon_Click(object sender, EventArgs e)
        {
            currentAction = buttonAction.vagon;
            move = false;
        }

        private void vagonCoal_Click(object sender, EventArgs e)
        {
            currentAction = buttonAction.vagonCoal;
            move = false;
        }

        private void vagonSand_Click(object sender, EventArgs e)
        {
            currentAction = buttonAction.vagonSand;
            move = false;
        }

        private void butMoving_Click(object sender, EventArgs e)
        {
            currentAction = buttonAction.move;
        }

        private void butTrain_Click(object sender, EventArgs e)
        {
            currentAction = buttonAction.train;
            count = Convert.ToInt32(countVag.Text);
        }

        private void drawing_machine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();

            foreach (MyFigure fig in figure)
            {
                fig.Draw(g);
            }
        }   
        
        private void drawing_machine_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.Location.X;
            startY = e.Location.Y;

            if (currentAction == buttonAction.move)
            {
                foreach (MyFigure fig in figure)
                {
                    if (fig.isPointInside(e.X, e.Y))
                    {
                        currentMoveFigure = fig;
                        move = true;
                    }
                }
            }
        }     

        private void drawing_machine_MouseUp(object sender, MouseEventArgs e)
        {           
            switch (currentAction)
            {
                case buttonAction.rectangle:
                    if (startX < e.Location.X && startY < e.Location.Y)
                        DrawRectangle(startX, startY, e.Location.X - startX, e.Location.Y - startY);

                    if (startX > e.Location.X && startY < e.Location.Y)
                        DrawRectangle(e.Location.X, startY, startX - e.Location.X, e.Location.Y - startY);

                    if (startX > e.Location.X && startY > e.Location.Y)
                        DrawRectangle(e.Location.X, e.Location.Y, startX - e.Location.X, startY - e.Location.Y);

                    if (startX < e.Location.X && startY > e.Location.Y)
                        DrawRectangle(startX, e.Location.Y, e.Location.X - startX, startY - e.Location.Y);
                    break;

                case buttonAction.circle:
                    int xrad = Math.Abs(startX - e.Location.X);
                    int yrad = Math.Abs(startY - e.Location.Y);
                    int rad = (int)Math.Sqrt(Math.Pow(xrad, 2) + Math.Pow(yrad, 2));
                    DrawCircle(startX - rad, startY - rad, rad);
                    break;

                case buttonAction.vagon:
                    if (startX < e.Location.X && startY < e.Location.Y)
                        DrawVagon(startX, startY, e.Location.X - startX, e.Location.Y - startY);

                    if (startX > e.Location.X && startY < e.Location.Y)
                        DrawVagon(e.Location.X, startY, startX - e.Location.X, e.Location.Y - startY);

                    if (startX > e.Location.X && startY > e.Location.Y)
                        DrawVagon(e.Location.X, e.Location.Y, startX - e.Location.X, startY - e.Location.Y);

                    if (startX < e.Location.X && startY > e.Location.Y)
                        DrawVagon(startX, e.Location.Y, e.Location.X - startX, startY - e.Location.Y);
                    break;

                case buttonAction.vagonCoal:
                    if (startX < e.Location.X && startY < e.Location.Y)
                        DrawVagonCoal(startX, startY, e.Location.X - startX, e.Location.Y - startY);

                    if (startX > e.Location.X && startY < e.Location.Y)
                        DrawVagonCoal(e.Location.X, startY, startX - e.Location.X, e.Location.Y - startY);

                    if (startX > e.Location.X && startY > e.Location.Y)
                        DrawVagonCoal(e.Location.X, e.Location.Y, startX - e.Location.X, startY - e.Location.Y);

                    if (startX < e.Location.X && startY > e.Location.Y)
                        DrawVagonCoal(startX, e.Location.Y, e.Location.X - startX, startY - e.Location.Y);
                    break;

                case buttonAction.vagonSand:
                    if (startX < e.Location.X && startY < e.Location.Y)
                        DrawVagonSand(startX, startY, e.Location.X - startX, e.Location.Y - startY);

                    if (startX > e.Location.X && startY < e.Location.Y)
                        DrawVagonSand(e.Location.X, startY, startX - e.Location.X, e.Location.Y - startY);

                    if (startX > e.Location.X && startY > e.Location.Y)
                        DrawVagonSand(e.Location.X, e.Location.Y, startX - e.Location.X, startY - e.Location.Y);

                    if (startX < e.Location.X && startY > e.Location.Y)
                        DrawVagonSand(startX, e.Location.Y, e.Location.X - startX, startY - e.Location.Y);
                    break;

                case buttonAction.train:
                    if (startX < e.Location.X && startY < e.Location.Y)
                        DrawTrain(startX, startY, e.Location.X - startX, e.Location.Y - startY);

                    if (startX > e.Location.X && startY < e.Location.Y)
                        DrawTrain(e.Location.X, startY, startX - e.Location.X, e.Location.Y - startY);

                    if (startX > e.Location.X && startY > e.Location.Y)
                        DrawTrain(e.Location.X, e.Location.Y, startX - e.Location.X, startY - e.Location.Y);

                    if (startX < e.Location.X && startY > e.Location.Y)
                        DrawTrain(startX, e.Location.Y, e.Location.X - startX, startY - e.Location.Y);
                    break;
            }

            if (move)    
                currentMoveFigure.Move(e.Location.X, e.Location.Y);
            
            Refresh();
        }

        private void countVag_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
