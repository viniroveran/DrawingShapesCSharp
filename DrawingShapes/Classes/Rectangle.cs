using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public Rectangle(int x, int y, int height, int width) : base(x, y) {
            this.height = height;
            this.width = width;
        }
        public Rectangle(int height, int width) : base()
        {
            this.height = height;
            this.width = width;
        }
        public Rectangle() : base()
        {
            this.height = 1;
            this.width = 1;
        }
        public override double CalculateArea() {
            return this.height * this.width;
        }

        public override double CalculatePerimeter() {
            return 2 * (this.height + this.width);
        }

        public override String ToString()
        {
            double perimeter = this.CalculatePerimeter();
            double area = this.CalculateArea();
            String description = "Height = "+ this.height + "\r\n"; 
            description += "Width  = " + this.width+ "\r\n";
            description += "Perimeter = " + Math.Round(perimeter)+ "\r\n";
            description += "Area = " + Math.Round(area) + "\r\n";

            return description;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 2);
            e.Graphics.DrawRectangle(myPen, new System.Drawing.Rectangle(this.X, this.Y, this.width, this.height));

            myPen.Dispose();
            e.Graphics.Dispose();
        }
        public override void Fill(PaintEventArgs e)
        {
            Brush myBrush = new SolidBrush(Color.DarkRed);
            e.Graphics.FillRectangle(myBrush, new System.Drawing.Rectangle(this.X, this.Y, this.width, this.height));

            myBrush.Dispose();
        }
    }
}
