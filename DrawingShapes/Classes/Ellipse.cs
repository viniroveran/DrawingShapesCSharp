using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shapes
{
    public class Ellipse : Shape
    {
        private int radius_1;
        private int radius_2;

        public int Radius_1 { get => radius_1; set => radius_1 = value; }
        public int Radius_2 { get => radius_2; set => radius_2 = value; }

        public Ellipse(int x, int y, int radius_1, int radius_2) : base(x, y)
        {
            this.radius_1 = radius_1;
            this.radius_2 = radius_2;
        }
        public Ellipse(int radius_1, int radius_2) : base()
        {
            this.radius_1 = radius_1;
            this.radius_2 = radius_2;
        }
        public Ellipse() : base()
        {
            this.radius_1 = 1;
            this.radius_2 = 3;
        }
        public override double CalculateArea() {
            double pi = Math.PI;
            return pi * (radius_1 * radius_2);
        }

        public override double CalculatePerimeter() {
            double pi = Math.PI;
            return 2 * pi * Math.Sqrt(((radius_1 * radius_1) + (radius_2 * radius_2))/2);
        }

        public override  String ToString()
        {
            double perimeter = this.CalculatePerimeter();
            double area = this.CalculateArea();
            // \r means carriage return
            String description = "Radius 1 = "+ this.radius_1 + "\r\n"; 
            description += "Radius 2 = "+ this.radius_2 + "\r\n"; 
            description += "Perimeter = " + Math.Round(perimeter)+ "\r\n";
            description += "Area = " + Math.Round(area) + "\r\n";

            return description;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.LightGreen, 2);

            e.Graphics.DrawEllipse(myPen, new System.Drawing.Rectangle(this.X, this.Y, this.radius_1, this.radius_2));

            myPen.Dispose();
            e.Graphics.Dispose();
        }
        public override void Fill(PaintEventArgs e)
        {
            Brush myBrush = new SolidBrush(Color.DarkGreen);
            e.Graphics.FillEllipse(myBrush, new System.Drawing.Rectangle(this.X, this.Y, this.radius_1, this.radius_2));

            myBrush.Dispose();
        }
    }
}
