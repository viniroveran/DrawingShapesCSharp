using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shapes
{
    public abstract class Point : IShapes2D
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public Point() {
            this.x = 0;
            this.y = 0;
        }
        public virtual double CalculateArea()
        {
            return 0.00;
        }

        public virtual double CalculatePerimeter()
        {
            return 0.00;
        }

        public abstract void Draw(PaintEventArgs e);
        public abstract void Fill(PaintEventArgs e);
    }
}
