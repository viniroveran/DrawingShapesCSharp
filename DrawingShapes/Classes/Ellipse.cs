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
        private int height;
        private int width;

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public Ellipse(int x, int y, int height, int width) : base(x, y)
        {
            this.height = height;
            this.width = width;
        }
        public Ellipse(int height, int width) : base()
        {
            this.height = height;
            this.width = width;
        }
        public Ellipse() : base()
        {
            this.height = 1;
            this.width = 1;
        }
        public override double CalculateArea() {
            return this.width * this.width;
        }

        public override double CalculatePerimeter() {
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
        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Green, 2);

            e.Graphics.DrawEllipse(myPen, new System.Drawing.Rectangle(this.X, this.Y, this.height, this.width));

            myPen.Dispose();
            e.Graphics.Dispose();
        }
        public override void Fill(PaintEventArgs e)
        {
            Brush myBrush = new SolidBrush(Color.Green);
            e.Graphics.FillEllipse(myBrush, new System.Drawing.Rectangle(this.X, this.Y, this.width, this.height));

            myBrush.Dispose();
            e.Graphics.Dispose();
        }
    }
}
