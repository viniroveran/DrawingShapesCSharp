using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        Rectangle myRectangle;
        Square mySquare;
        Circle myCircle;
        Ellipse myEllipse;
        bool fill;

        public Form1()
        {
            InitializeComponent();
        }

        private static void Validate_Int(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Must be a digit only. \n");
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
            this.textBoxX.Enabled = false;
            this.textBoxY.Enabled = false;
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
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                int height = Convert.ToInt32(this.textBoxHeight.Text);
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                
                myRectangle = new Rectangle(x, y, height, width);

                // fill or draw?
                fill = false;
              
                //txt_Display
                String info = myRectangle.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                
                mySquare = new Square(x, y, width);

                // fill or draw?
                fill = false;

                //txt_Display
                String info = mySquare.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                
                myCircle = new Circle(x, y, width);

                // fill or draw?
                fill = false;

                //txt_Display
                String info = myCircle.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                int height = Convert.ToInt32(this.textBoxHeight.Text);
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                
                myEllipse = new Ellipse(x, y, height, width);

                // fill or draw?
                fill = false;

                //txt_Display
                String info = myEllipse.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }

            this.panelDrawing.Invalidate(); // it causes the control to be redrawn
            this.panelDrawing.Update();
            this.Refresh();
        }
        //the class PaintEventArgs provides data for the object event Paint 
        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            // Fill before painting to have a lighter border
            // Rectangle
            if (this.radioButtonRectangle.Checked == true && myRectangle != null)
            {
                if (fill)
                    myRectangle.Fill(e);
                myRectangle.Draw(e);

                this.textBoxDisplay.Text = myRectangle.ToString();
            }
            // Square
            if (this.radioButtonSquare.Checked == true && mySquare != null)
            {
                if (fill)
                    mySquare.Fill(e);
                mySquare.Draw(e);

                this.textBoxDisplay.Text = mySquare.ToString();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true && myCircle != null)
            {
                if (fill)
                    myCircle.Fill(e);
                myCircle.Draw(e);

                this.textBoxDisplay.Text = myCircle.ToString();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true && myEllipse != null)
            {
                if (fill)
                    myEllipse.Fill(e);
                myEllipse.Draw(e);

                this.textBoxDisplay.Text = myEllipse.ToString();
            }
        }

        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSquare.Checked == true)
            {
                this.labelHeight.Text = "";
                this.labelWidth.Text = "Side";
                this.textBoxX.Enabled = true;
                this.textBoxY.Enabled = true;
                this.textBoxWidth.Enabled = true;
            }
            else
            {
                this.labelHeight.Text = "Height";
                this.labelWidth.Text = "Width";
                this.textBoxX.Enabled = false;
                this.textBoxY.Enabled = false;
                this.textBoxWidth.Enabled = false;
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {


        }

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonCircle.Checked == true)
            {
                this.labelHeight.Text = "";
                this.labelWidth.Text = "Radius";
                this.textBoxX.Enabled = true;
                this.textBoxY.Enabled = true;
                this.textBoxWidth.Enabled = true;
            }
            else
            {
                this.labelHeight.Text = "Height";
                this.labelWidth.Text = "Width";
                this.textBoxX.Enabled = false;
                this.textBoxY.Enabled = false;
                this.textBoxWidth.Enabled = false;
            }
        }

        private void radioButtonEllipse_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonEllipse.Checked == true)
            {
                this.labelHeight.Text = "Radius1";
                this.labelWidth.Text = "Radius2";
                this.textBoxX.Enabled = true;
                this.textBoxY.Enabled = true;
                this.textBoxHeight.Enabled = true;
                this.textBoxWidth.Enabled = true;
            }
            else
            {
                this.labelHeight.Text = "Height";
                this.labelWidth.Text = "Width";
                this.textBoxX.Enabled = false;
                this.textBoxY.Enabled = false;
                this.textBoxHeight.Enabled = false;
                this.textBoxWidth.Enabled = false;
            }
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int height = Convert.ToInt32(this.textBoxHeight.Text);
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                myRectangle = new Rectangle(x, y, height, width);

                // fill or draw?
                fill = true;

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

                // fill or draw?
                fill = true;

                //txt_Display
                String info = mySquare.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                myCircle = new Circle(x, y, width);

                // fill or draw?
                fill = true;

                //txt_Display
                String info = myCircle.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int height = Convert.ToInt32(this.textBoxHeight.Text);
                int width = Convert.ToInt32(this.textBoxWidth.Text);
                int x = Convert.ToInt32(this.textBoxX.Text);
                int y = Convert.ToInt32(this.textBoxY.Text);
                myEllipse = new Ellipse(x, y, height, width);

                // fill or draw?
                fill = true;

                //txt_Display
                String info = myEllipse.ToString();
                this.textBoxDisplay.Text = info;
                this.textBoxDisplay.Visible = true;
            }

            this.panelDrawing.Invalidate(); // it causes the control to be redrawn
            this.panelDrawing.Update();
            this.Refresh();
        }

        private void buttonMoveUp_Click_1(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int x = myRectangle.X;
                int y = myRectangle.Y;
                int height = myRectangle.Height;
                int width = myRectangle.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myRectangle = new Rectangle(x, y - dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = mySquare.X;
                int y = mySquare.Y;
                int width = mySquare.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                mySquare = new Square(x, y - dY, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = myCircle.X;
                int y = myCircle.Y;
                int radius = myCircle.Radius;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myCircle = new Circle(x, y - dY, radius);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = myEllipse.X;
                int y = myEllipse.Y;
                int height = myEllipse.Radius_1;
                int width = myEllipse.Radius_2;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myEllipse = new Ellipse(x, y - dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int x = myRectangle.X;
                int y = myRectangle.Y;
                int height = myRectangle.Height;
                int width = myRectangle.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myRectangle = new Rectangle(x, y + dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = mySquare.X;
                int y = mySquare.Y;
                int side = mySquare.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                mySquare = new Square(x, y + dY, side);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = myCircle.X;
                int y = myCircle.Y;
                int radius = myCircle.Radius;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myCircle = new Circle(x, y + dY, radius);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = myEllipse.X;
                int y = myEllipse.Y;
                int height = myEllipse.Radius_1;
                int width = myEllipse.Radius_2;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myEllipse = new Ellipse(x, y + dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            if (this.radioButtonRectangle.Checked == true)
            {
                // Rectangle
                int x = myRectangle.X;
                int y = myRectangle.Y;
                int height = myRectangle.Height;
                int width = myRectangle.Width;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myRectangle = new Rectangle(x - dX, y, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = mySquare.X;
                int y = mySquare.Y;
                int side = mySquare.Width;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                mySquare = new Square(x - dX, y, side);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = myCircle.X;
                int y = myCircle.Y;
                int radius = myCircle.Radius;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myCircle = new Circle(x - dX, y, radius);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = myEllipse.X;
                int y = myEllipse.Y;
                int height = myEllipse.Radius_1;
                int width = myEllipse.Radius_2;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myEllipse = new Ellipse(x - dX, y, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int x = myRectangle.X;
                int y = myRectangle.Y;
                int height = myRectangle.Height;
                int width = myRectangle.Width;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myRectangle = new Rectangle(x + dX, y, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = mySquare.X;
                int y = mySquare.Y;
                int side = mySquare.Width;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                mySquare = new Square(x + dX, y, side);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = myCircle.X;
                int y = myCircle.Y;
                int radius = myCircle.Radius;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myCircle = new Circle(x + dX, y, radius);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = myEllipse.X;
                int y = myEllipse.Y;
                int height = myEllipse.Radius_1;
                int width = myEllipse.Radius_2;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myEllipse = new Ellipse(x + dX, y, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
        }

        private void buttonMoveUpLeft_Click(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int x = myRectangle.X;
                int y = myRectangle.Y;
                int height = myRectangle.Height;
                int width = myRectangle.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myRectangle = new Rectangle(x - dX, y - dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = mySquare.X;
                int y = mySquare.Y;
                int side = mySquare.Width;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                mySquare = new Square(x - dX, y - dY, side);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = myCircle.X;
                int y = myCircle.Y;
                int radius = myCircle.Radius;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myCircle = new Circle(x - dX, y - dY, radius);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = myEllipse.X;
                int y = myEllipse.Y;
                int height = myEllipse.Radius_1;
                int width = myEllipse.Radius_2;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myEllipse = new Ellipse(x - dX, y - dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
        }

        private void buttonMoveUpRight_Click(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int x = myRectangle.X;
                int y = myRectangle.Y;
                int height = myRectangle.Height;
                int width = myRectangle.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myRectangle = new Rectangle(x + dX, y - dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = mySquare.X;
                int y = mySquare.Y;
                int side = mySquare.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                mySquare = new Square(x + dX, y - dY, side);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = myCircle.X;
                int y = myCircle.Y;
                int radius = myCircle.Radius;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myCircle = new Circle(x + dX, y - dY, radius);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = myEllipse.X;
                int y = myEllipse.Y;
                int height = myEllipse.Radius_1;
                int width = myEllipse.Radius_2;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myEllipse = new Ellipse(x + dX, y - dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
        }

        private void buttonMoveDownLeft_Click(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int x = myRectangle.X;
                int y = myRectangle.Y;
                int height = myRectangle.Height;
                int width = myRectangle.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myRectangle = new Rectangle(x - dX, y + dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = mySquare.X;
                int y = mySquare.Y;
                int side = mySquare.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                mySquare = new Square(x - dX, y + dY, side);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = myCircle.X;
                int y = myCircle.Y;
                int radius = myCircle.Radius;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myCircle = new Circle(x - dX, y + dY, radius);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = myEllipse.X;
                int y = myEllipse.Y;
                int height = myEllipse.Radius_1;
                int width = myEllipse.Radius_2;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myEllipse = new Ellipse(x - dX, y + dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
        }

        private void buttonMoveDownRight_Click(object sender, EventArgs e)
        {
            // Rectangle
            if (this.radioButtonRectangle.Checked == true)
            {
                int x = myRectangle.X;
                int y = myRectangle.Y;
                int height = myRectangle.Height;
                int width = myRectangle.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                myRectangle = new Rectangle(x + dX, y + dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Square
            if (this.radioButtonSquare.Checked == true)
            {
                int x = mySquare.X;
                int y = mySquare.Y;
                int side = mySquare.Width;

                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                mySquare = new Square(x + dX, y + dY, side);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Circle
            if (this.radioButtonCircle.Checked == true)
            {
                int x = myCircle.X;
                int y = myCircle.Y;
                int radius = myCircle.Radius;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myCircle = new Circle(x + dX, y + dY, radius);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
            // Ellipse
            if (this.radioButtonEllipse.Checked == true)
            {
                int x = myEllipse.X;
                int y = myEllipse.Y;
                int height = myEllipse.Radius_1;
                int width = myEllipse.Radius_2;

                int dX = Convert.ToInt32(this.numericUpDowndX.Value);
                int dY = Convert.ToInt32(this.numericUpDowndY.Value);
                myEllipse = new Ellipse(x + dX, y + dY, height, width);

                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
                this.Refresh();
            }
        }

        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate_Int(e);
        }

        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate_Int(e);
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate_Int(e);
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate_Int(e);
        }
    }
}
