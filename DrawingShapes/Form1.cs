using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//references
//https://www.c-sharpcorner.com/article/gdi-tutorial-for-beginners/
//https://msdn.microsoft.com/en-us/library/system.drawing.rectangle(v=vs.110).aspx

namespace Shapes
{
    public partial class Form1 : Form
    {
        Rectangle myRectangle;
        Square mySquare;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
            this.textBoxHeight.Enabled = false;
            this.textBoxWidth.Enabled = false;
        }

        public void reset() {
            this.textBoxDisplay.Clear();
            this.textBoxHeight.Clear();
            this.textBoxWidth.Clear();        
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonRectangle.Checked == true)
            {
                this.textBoxX.Enabled = true;
                this.textBoxY.Enabled = true;
                this.textBoxHeight.Enabled = true;
                this.textBoxWidth.Enabled  = true;
            }
            else
            {
                this.textBoxX.Enabled = false;
                this.textBoxY.Enabled = false;
                this.textBoxHeight.Enabled = false;
                this.textBoxWidth.Enabled  = false;
            }
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                int height = Convert.ToInt32(this.textBoxHeight.Text);
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                myRectangle = new Rectangle(x, y, height, width);
              
                //txt_Display
                String info = myRectangle.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                mySquare = new Square(x, y, width);

                //txt_Display
                String info = mySquare.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }
            //
            this.panelDrawing.Invalidate(); // it causes the control to be redrawn
            this.panelDrawing.Update();
            this.Refresh();                                                      
        }
        //the class PaintEventArgs provides data for the object event Paint 
        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {           
            if (this.radioButtonRectangle.Checked == true && myRectangle != null)
            {
                myRectangle.Draw(e);

                this.textBoxDisplay.Text = myRectangle.ToString();
            }

            if (this.radioButtonSquare.Checked == true && mySquare != null)
            {
                mySquare.Draw(e);

                this.textBoxDisplay.Text = mySquare.ToString();
            }
        }

        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSquare.Checked == true)
            {
                this.textBoxX.Enabled = true;
                this.textBoxY.Enabled = true;
                this.textBoxWidth.Enabled = true;
            }
            else
            {
                this.textBoxX.Enabled = false;
                this.textBoxY.Enabled = false;
                this.textBoxWidth.Enabled = false;
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {


        }
    }
}
