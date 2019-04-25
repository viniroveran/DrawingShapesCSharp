using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shapes
{
    interface IShapes
    {
        double CalculateArea();
        double CalculatePerimeter();
        void Draw(PaintEventArgs e);
        void Fill(PaintEventArgs e);
    }
}
