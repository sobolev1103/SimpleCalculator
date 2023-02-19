namespace Calculator
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
            this.OutputWindow = new System.Windows.Forms.TextBox();
            this.sqrtx = new System.Windows.Forms.Button();
            this.sinx = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clearone = new System.Windows.Forms.Button();
            this.rangelabel = new System.Windows.Forms.Label();
            this.minlabel = new System.Windows.Forms.Label();
            this.maxlabel = new System.Windows.Forms.Label();
            this.mininput = new System.Windows.Forms.TextBox();
            this.secondoutput = new System.Windows.Forms.TextBox();
            this.maxinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutputWindow
            // 
            this.OutputWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputWindow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutputWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputWindow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputWindow.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.OutputWindow.Location = new System.Drawing.Point(12, 68);
            this.OutputWindow.Multiline = true;
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.ReadOnly = true;
            this.OutputWindow.Size = new System.Drawing.Size(425, 46);
            this.OutputWindow.TabIndex = 0;
            this.OutputWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OutputWindow.TextChanged += new System.EventHandler(this.OutputWindow_TextChanged);
            // 
            // sqrtx
            // 
            this.sqrtx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sqrtx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtx.Location = new System.Drawing.Point(13, 120);
            this.sqrtx.Name = "sqrtx";
            this.sqrtx.Size = new System.Drawing.Size(80, 80);
            this.sqrtx.TabIndex = 1;
            this.sqrtx.Text = "√x";
            this.sqrtx.UseVisualStyleBackColor = true;
            this.sqrtx.Click += new System.EventHandler(this.sqrtx_Click);
            // 
            // sinx
            // 
            this.sinx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sinx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinx.Location = new System.Drawing.Point(99, 120);
            this.sinx.Name = "sinx";
            this.sinx.Size = new System.Drawing.Size(80, 80);
            this.sinx.TabIndex = 2;
            this.sinx.Text = "sin(x)";
            this.sinx.UseVisualStyleBackColor = true;
            this.sinx.Click += new System.EventHandler(this.sinx_Click);
            // 
            // separator
            // 
            this.separator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separator.Location = new System.Drawing.Point(13, 464);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(80, 80);
            this.separator.TabIndex = 3;
            this.separator.Text = ",";
            this.separator.UseVisualStyleBackColor = true;
            this.separator.Click += new System.EventHandler(this.separator_Click);
            // 
            // num7
            // 
            this.num7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(13, 206);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(80, 80);
            this.num7.TabIndex = 4;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(99, 206);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(80, 80);
            this.num8.TabIndex = 5;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(185, 206);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(80, 80);
            this.num9.TabIndex = 6;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num4
            // 
            this.num4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(13, 292);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(80, 80);
            this.num4.TabIndex = 7;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(99, 292);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(80, 80);
            this.num5.TabIndex = 8;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(185, 292);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(80, 80);
            this.num6.TabIndex = 9;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num2
            // 
            this.num2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(99, 378);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(80, 80);
            this.num2.TabIndex = 11;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(185, 378);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(80, 80);
            this.num3.TabIndex = 12;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // equal
            // 
            this.equal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(185, 464);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(80, 80);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // num0
            // 
            this.num0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(99, 464);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(80, 80);
            this.num0.TabIndex = 14;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // reverse
            // 
            this.reverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverse.Location = new System.Drawing.Point(185, 120);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(80, 80);
            this.reverse.TabIndex = 15;
            this.reverse.Text = "1/x";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // clearall
            // 
            this.clearall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearall.Location = new System.Drawing.Point(271, 120);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(80, 80);
            this.clearall.TabIndex = 16;
            this.clearall.Text = "C";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // num1
            // 
            this.num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(13, 378);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(80, 80);
            this.num1.TabIndex = 18;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // plus
            // 
            this.plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(271, 292);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 80);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(357, 292);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(80, 80);
            this.minus.TabIndex = 20;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // mult
            // 
            this.mult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(271, 206);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(80, 80);
            this.mult.TabIndex = 21;
            this.mult.Text = "×";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(357, 206);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(80, 80);
            this.div.TabIndex = 22;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // clearone
            // 
            this.clearone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearone.Location = new System.Drawing.Point(357, 120);
            this.clearone.Name = "clearone";
            this.clearone.Size = new System.Drawing.Size(80, 80);
            this.clearone.TabIndex = 23;
            this.clearone.Text = "⌫";
            this.clearone.UseVisualStyleBackColor = true;
            this.clearone.Click += new System.EventHandler(this.clearone_Click);
            // 
            // rangelabel
            // 
            this.rangelabel.AutoSize = true;
            this.rangelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangelabel.Location = new System.Drawing.Point(293, 395);
            this.rangelabel.Name = "rangelabel";
            this.rangelabel.Size = new System.Drawing.Size(122, 36);
            this.rangelabel.TabIndex = 24;
            this.rangelabel.Text = "Range of input \r\nnumbers:";
            this.rangelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minlabel
            // 
            this.minlabel.AutoSize = true;
            this.minlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minlabel.Location = new System.Drawing.Point(293, 449);
            this.minlabel.Name = "minlabel";
            this.minlabel.Size = new System.Drawing.Size(36, 18);
            this.minlabel.TabIndex = 25;
            this.minlabel.Text = "min:";
            // 
            // maxlabel
            // 
            this.maxlabel.AutoSize = true;
            this.maxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxlabel.Location = new System.Drawing.Point(293, 494);
            this.maxlabel.Name = "maxlabel";
            this.maxlabel.Size = new System.Drawing.Size(40, 18);
            this.maxlabel.TabIndex = 26;
            this.maxlabel.Text = "max:";
            // 
            // mininput
            // 
            this.mininput.Location = new System.Drawing.Point(335, 448);
            this.mininput.Name = "mininput";
            this.mininput.Size = new System.Drawing.Size(80, 22);
            this.mininput.TabIndex = 27;
            this.mininput.Text = "-300000";
            this.mininput.TextChanged += new System.EventHandler(this.mininput_TextChanged);
            // 
            // secondoutput
            // 
            this.secondoutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secondoutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondoutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.secondoutput.Enabled = false;
            this.secondoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondoutput.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.secondoutput.Location = new System.Drawing.Point(13, 16);
            this.secondoutput.Multiline = true;
            this.secondoutput.Name = "secondoutput";
            this.secondoutput.Size = new System.Drawing.Size(425, 46);
            this.secondoutput.TabIndex = 29;
            this.secondoutput.Text = "Input your values:";
            this.secondoutput.TextChanged += new System.EventHandler(this.secondoutput_TextChanged);
            // 
            // maxinput
            // 
            this.maxinput.Location = new System.Drawing.Point(335, 493);
            this.maxinput.Name = "maxinput";
            this.maxinput.Size = new System.Drawing.Size(80, 22);
            this.maxinput.TabIndex = 30;
            this.maxinput.Text = "500000";
            this.maxinput.TextChanged += new System.EventHandler(this.maxinput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(449, 555);
            this.Controls.Add(this.maxinput);
            this.Controls.Add(this.secondoutput);
            this.Controls.Add(this.mininput);
            this.Controls.Add(this.maxlabel);
            this.Controls.Add(this.minlabel);
            this.Controls.Add(this.rangelabel);
            this.Controls.Add(this.clearone);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.sinx);
            this.Controls.Add(this.sqrtx);
            this.Controls.Add(this.OutputWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputWindow;
        private System.Windows.Forms.Button sqrtx;
        private System.Windows.Forms.Button sinx;
        private System.Windows.Forms.Button separator;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clearone;
        private System.Windows.Forms.Label rangelabel;
        private System.Windows.Forms.Label minlabel;
        private System.Windows.Forms.Label maxlabel;
        private System.Windows.Forms.TextBox mininput;
        private System.Windows.Forms.TextBox secondoutput;
        private System.Windows.Forms.TextBox maxinput;
    }
}

