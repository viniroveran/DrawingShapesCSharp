using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shapes
{
    public class Square : Shape
    {
        private int width;
        public int Width { get => width; set => width = value; }
        public Square(int x, int y, int width) : base(x, y)
        {
            this.width = width;
        }
        public Square(int width) : base()
        {
            this.width = width;
        }
        public Square() : base()
        {
            this.width = 1;
        }
        public override double CalculateArea() {
            return this.width * this.width;
        }

        public override double CalculatePerimeter() {
            return 2 * (this.width + this.width);
        }

        public override String ToString()
        {
            double perimeter = this.CalculatePerimeter();
            double area = this.CalculateArea();
            String description = "Width = "+ this.width + "\r\n"; 
            description += "Perimeter = " + Math.Round(perimeter)+ "\r\n";
            description += "Area = " + Math.Round(area) + "\r\n";

            return description;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Blue, 2);
           
            e.Graphics.DrawRectangle(myPen, new System.Drawing.Rectangle(this.X, this.Y, this.width, this.width));

            myPen.Dispose();
            e.Graphics.Dispose();
        }
        public override void Fill(PaintEventArgs e)
        {
            Brush myBrush = new SolidBrush(Color.Red);
            e.Graphics.FillRectangle(myBrush, new System.Drawing.Rectangle(this.X, this.Y, this.width, this.width));

            myBrush.Dispose();
            e.Graphics.Dispose();
        }
    }
}
