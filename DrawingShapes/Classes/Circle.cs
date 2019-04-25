using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        private int width;
        private int dx;
        private int dy;

        public int Width { get => width; set => width = value; }
        public int Dx { get => dx; set => dx = value; }
        public int Dy { get => dy; set => dy = value; }

        public Circle(int width)
        {
            this.width = width;
        }
        public Circle()
        {
            this.width = 1;
        }
        public double CalculateArea() {
            return this.width * this.width;
        }

        public double CalculatePerimeter() {
            return 2 * (this.width + this.width);
        }

        public override  String ToString()
        {
            double perimeter = this.CalculatePerimeter();
            double area = this.CalculateArea();
            // \r means carriage return
            String description = "Width = "+ this.width + "\r\n"; 
            description += "Perimeter = " + Math.Round(perimeter)+ "\r\n";
            description += "Area = " + Math.Round(area) + "\r\n";

            return description;
        }
        public void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Blue, 2);
            /* The point of the LeftTop panel is fixed to:
            *              LeftTopPoint(xPosition, yPosition) = LeftTopPoint(0,0)
            * but, you can change these values in the code, for example:
            *              LeftTopPont(xPosition, yPosition) = LeftTopPont(10,10)
            *  Or:
            *  you can derive the class Rectangle from the class Shape  
            *  and use the xCoordinate and yCoordinate          
            * *****************/
           
            e.Graphics.DrawRectangle(myPen, new System.Drawing.Rectangle(0, 0, this.width, this.width));

            myPen.Dispose();
            e.Graphics.Dispose();
        }

        public void MoveRight(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Blue, 2);

            e.Graphics.DrawRectangle(myPen, new System.Drawing.Rectangle(this.dx, 0, this.width, this.width));

            myPen.Dispose();
            e.Graphics.Dispose();
        }

        public void MoveDown(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Blue, 2);

            e.Graphics.DrawRectangle(myPen, new System.Drawing.Rectangle(0, this.dy, this.width, this.width));

            myPen.Dispose();
            e.Graphics.Dispose();
        }

        public void MoveUpRight(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Blue, 2);

            e.Graphics.DrawRectangle(myPen, new System.Drawing.Rectangle(this.dx, this.dy, this.width, this.width));

            myPen.Dispose();
            e.Graphics.Dispose();
        }
    }
}
