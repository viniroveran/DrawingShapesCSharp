namespace Shapes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMoveDownRight = new System.Windows.Forms.Button();
            this.buttonMoveDownLeft = new System.Windows.Forms.Button();
            this.buttonMoveUpRight = new System.Windows.Forms.Button();
            this.buttonMoveUpLeft = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(421, 19);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(46, 20);
            this.textBoxHeight.TabIndex = 0;
            this.textBoxHeight.Text = "5";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(421, 45);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(46, 20);
            this.textBoxWidth.TabIndex = 1;
            this.textBoxWidth.Text = "5";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(374, 48);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(374, 22);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Height";
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(294, 75);
            this.textBoxDisplay.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(173, 172);
            this.textBoxDisplay.TabIndex = 8;
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(12, 16);
            this.radioButtonRectangle.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRectangle.TabIndex = 13;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(334, 262);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(133, 20);
            this.buttonDraw.TabIndex = 14;
            this.buttonDraw.Text = "Draw It";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // panelDrawing
            // 
            this.panelDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawing.Location = new System.Drawing.Point(25, 75);
            this.panelDrawing.Margin = new System.Windows.Forms.Padding(1);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(213, 172);
            this.panelDrawing.TabIndex = 15;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawing_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEllipse);
            this.groupBox1.Controls.Add(this.radioButtonCircle);
            this.groupBox1.Controls.Add(this.radioButtonSquare);
            this.groupBox1.Controls.Add(this.radioButtonRectangle);
            this.groupBox1.Location = new System.Drawing.Point(25, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(213, 59);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a shape";
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(88, 35);
            this.radioButtonEllipse.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(53, 17);
            this.radioButtonEllipse.TabIndex = 16;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Elipse";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonEllipse_CheckedChanged);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(12, 35);
            this.radioButtonCircle.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCircle.TabIndex = 15;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            this.radioButtonCircle.CheckedChanged += new System.EventHandler(this.radioButtonCircle_CheckedChanged);
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(88, 16);
            this.radioButtonSquare.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSquare.TabIndex = 14;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = "Square";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            this.radioButtonSquare.CheckedChanged += new System.EventHandler(this.radioButtonSquare_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(585, 163);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(630, 163);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown2.TabIndex = 23;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "dX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "dY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Y";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(315, 45);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(46, 20);
            this.textBoxY.TabIndex = 27;
            this.textBoxY.Text = "0";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(315, 19);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(46, 20);
            this.textBoxX.TabIndex = 26;
            this.textBoxX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(549, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "Move your Drawing";
            // 
            // buttonMoveDownRight
            // 
            this.buttonMoveDownRight.BackgroundImage = global::DrawingShapes.Properties.Resources.arrow_down_right;
            this.buttonMoveDownRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMoveDownRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveDownRight.Location = new System.Drawing.Point(675, 203);
            this.buttonMoveDownRight.Name = "buttonMoveDownRight";
            this.buttonMoveDownRight.Size = new System.Drawing.Size(75, 70);
            this.buttonMoveDownRight.TabIndex = 38;
            this.buttonMoveDownRight.UseVisualStyleBackColor = true;
            // 
            // buttonMoveDownLeft
            // 
            this.buttonMoveDownLeft.BackgroundImage = global::DrawingShapes.Properties.Resources.arrow_down_left;
            this.buttonMoveDownLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMoveDownLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveDownLeft.Location = new System.Drawing.Point(504, 203);
            this.buttonMoveDownLeft.Name = "buttonMoveDownLeft";
            this.buttonMoveDownLeft.Size = new System.Drawing.Size(75, 70);
            this.buttonMoveDownLeft.TabIndex = 37;
            this.buttonMoveDownLeft.UseVisualStyleBackColor = true;
            // 
            // buttonMoveUpRight
            // 
            this.buttonMoveUpRight.BackgroundImage = global::DrawingShapes.Properties.Resources.arrow_up_right;
            this.buttonMoveUpRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMoveUpRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveUpRight.Location = new System.Drawing.Point(675, 62);
            this.buttonMoveUpRight.Name = "buttonMoveUpRight";
            this.buttonMoveUpRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMoveUpRight.Size = new System.Drawing.Size(75, 70);
            this.buttonMoveUpRight.TabIndex = 36;
            this.buttonMoveUpRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMoveUpRight.UseVisualStyleBackColor = true;
            // 
            // buttonMoveUpLeft
            // 
            this.buttonMoveUpLeft.BackgroundImage = global::DrawingShapes.Properties.Resources.arrow_up_left;
            this.buttonMoveUpLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMoveUpLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveUpLeft.Location = new System.Drawing.Point(504, 62);
            this.buttonMoveUpLeft.Name = "buttonMoveUpLeft";
            this.buttonMoveUpLeft.Size = new System.Drawing.Size(75, 70);
            this.buttonMoveUpLeft.TabIndex = 35;
            this.buttonMoveUpLeft.UseVisualStyleBackColor = true;
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.BackgroundImage = global::DrawingShapes.Properties.Resources.arrow_down;
            this.buttonMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveDown.Location = new System.Drawing.Point(601, 203);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(52, 70);
            this.buttonMoveDown.TabIndex = 34;
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMoveRight.BackgroundImage")));
            this.buttonMoveRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveRight.Location = new System.Drawing.Point(675, 147);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(75, 43);
            this.buttonMoveRight.TabIndex = 33;
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.BackgroundImage = global::DrawingShapes.Properties.Resources.arrow_left;
            this.buttonMoveLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveLeft.Location = new System.Drawing.Point(504, 147);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(75, 43);
            this.buttonMoveLeft.TabIndex = 32;
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.BackgroundImage = global::DrawingShapes.Properties.Resources.arrow_up;
            this.buttonMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveUp.Location = new System.Drawing.Point(601, 62);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(52, 70);
            this.buttonMoveUp.TabIndex = 30;
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 292);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonMoveDownRight);
            this.Controls.Add(this.buttonMoveDownLeft);
            this.Controls.Add(this.buttonMoveUpRight);
            this.Controls.Add(this.buttonMoveUpLeft);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Name = "Form1";
            this.Text = "Drawing Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveUpLeft;
        private System.Windows.Forms.Button buttonMoveUpRight;
        private System.Windows.Forms.Button buttonMoveDownLeft;
        private System.Windows.Forms.Button buttonMoveDownRight;
        private System.Windows.Forms.Label label7;
    }
}

