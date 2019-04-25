using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shapes
{
    public class Circle : Point
    {
        private int radius;

        public int Radius { get => radius; set => radius = value; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public Circle()
        {
            this.radius = 1;
        }
        public override double CalculateArea() {
            double pi = Math.PI;
            return pi * (radius * radius);
        }

        public override double CalculatePerimeter() {
            double pi = Math.PI;
            return 2 * (pi * radius);
        }

        public override  String ToString()
        {
            double perimeter = this.CalculatePerimeter();
            double area = this.CalculateArea();
            // \r means carriage return
            String description = "Radius = "+ this.radius + "\r\n"; 
            description += "Perimeter = " + Math.Round(perimeter)+ "\r\n";
            description += "Area = " + Math.Round(area) + "\r\n";

            return description;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Yellow, 2);

            e.Graphics.DrawEllipse(myPen, new System.Drawing.Rectangle(this.X, this.Y, this.radius, this.radius));

            myPen.Dispose();
            e.Graphics.Dispose();
        }
        public override void Fill(PaintEventArgs e)
        {
            Brush myBrush = new SolidBrush(Color.DarkOrange);
            e.Graphics.FillEllipse(myBrush, new System.Drawing.Rectangle(this.X, this.Y, this.radius, this.radius));

            myBrush.Dispose();
        }
    }
}
