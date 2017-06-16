namespace P16_McKenzieBradley_Snakes
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
            this.components = new System.ComponentModel.Container();
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.pic0 = new System.Windows.Forms.PictureBox();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.picTailLeft = new System.Windows.Forms.PictureBox();
            this.picTailUp = new System.Windows.Forms.PictureBox();
            this.picTailRight = new System.Windows.Forms.PictureBox();
            this.picTailDown = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.picHeadLeft = new System.Windows.Forms.PictureBox();
            this.picHeadDown = new System.Windows.Forms.PictureBox();
            this.picHeadRight = new System.Windows.Forms.PictureBox();
            this.picHeadUp = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic11 = new System.Windows.Forms.PictureBox();
            this.picBody = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTailLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTailUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTailRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTailDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBody)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrLeft
            // 
            this.tmrLeft.Interval = 200;
            this.tmrLeft.Tick += new System.EventHandler(this.tmrLeft_Tick);
            // 
            // tmrRight
            // 
            this.tmrRight.Interval = 200;
            this.tmrRight.Tick += new System.EventHandler(this.tmrRight_Tick);
            // 
            // tmrUp
            // 
            this.tmrUp.Interval = 200;
            this.tmrUp.Tick += new System.EventHandler(this.tmrUp_Tick);
            // 
            // tmrDown
            // 
            this.tmrDown.Interval = 200;
            this.tmrDown.Tick += new System.EventHandler(this.tmrDown_Tick);
            // 
            // pic0
            // 
            this.pic0.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Head02;
            this.pic0.Location = new System.Drawing.Point(300, 100);
            this.pic0.Name = "pic0";
            this.pic0.Size = new System.Drawing.Size(41, 41);
            this.pic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic0.TabIndex = 19;
            this.pic0.TabStop = false;
            // 
            // picFood
            // 
            this.picFood.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Cheeseburger21;
            this.picFood.Location = new System.Drawing.Point(600, 200);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(25, 25);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFood.TabIndex = 18;
            this.picFood.TabStop = false;
            // 
            // picTailLeft
            // 
            this.picTailLeft.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Tail3;
            this.picTailLeft.Location = new System.Drawing.Point(105, 288);
            this.picTailLeft.Name = "picTailLeft";
            this.picTailLeft.Size = new System.Drawing.Size(48, 48);
            this.picTailLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTailLeft.TabIndex = 17;
            this.picTailLeft.TabStop = false;
            this.picTailLeft.Visible = false;
            // 
            // picTailUp
            // 
            this.picTailUp.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Tail2;
            this.picTailUp.Location = new System.Drawing.Point(60, 241);
            this.picTailUp.Name = "picTailUp";
            this.picTailUp.Size = new System.Drawing.Size(48, 48);
            this.picTailUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTailUp.TabIndex = 16;
            this.picTailUp.TabStop = false;
            this.picTailUp.Visible = false;
            // 
            // picTailRight
            // 
            this.picTailRight.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Tail1;
            this.picTailRight.Location = new System.Drawing.Point(16, 288);
            this.picTailRight.Name = "picTailRight";
            this.picTailRight.Size = new System.Drawing.Size(48, 48);
            this.picTailRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTailRight.TabIndex = 15;
            this.picTailRight.TabStop = false;
            this.picTailRight.Visible = false;
            // 
            // picTailDown
            // 
            this.picTailDown.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Tail0;
            this.picTailDown.Location = new System.Drawing.Point(60, 335);
            this.picTailDown.Name = "picTailDown";
            this.picTailDown.Size = new System.Drawing.Size(48, 48);
            this.picTailDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTailDown.TabIndex = 14;
            this.picTailDown.TabStop = false;
            this.picTailDown.Visible = false;
            // 
            // pic10
            // 
            this.pic10.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic10.Location = new System.Drawing.Point(298, 574);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(48, 48);
            this.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic10.TabIndex = 13;
            this.pic10.TabStop = false;
            // 
            // pic9
            // 
            this.pic9.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic9.Location = new System.Drawing.Point(298, 526);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(48, 48);
            this.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic9.TabIndex = 12;
            this.pic9.TabStop = false;
            // 
            // pic8
            // 
            this.pic8.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic8.Location = new System.Drawing.Point(298, 478);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(48, 48);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic8.TabIndex = 11;
            this.pic8.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic7.Location = new System.Drawing.Point(298, 430);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(48, 48);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic7.TabIndex = 10;
            this.pic7.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic6.Location = new System.Drawing.Point(298, 382);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(48, 48);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic6.TabIndex = 9;
            this.pic6.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic5.Location = new System.Drawing.Point(298, 334);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(48, 48);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic5.TabIndex = 8;
            this.pic5.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic4.Location = new System.Drawing.Point(298, 286);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(48, 48);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic4.TabIndex = 7;
            this.pic4.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic3.Location = new System.Drawing.Point(298, 238);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(48, 48);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic3.TabIndex = 6;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic2.Location = new System.Drawing.Point(298, 190);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(48, 48);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // picHeadLeft
            // 
            this.picHeadLeft.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Head31;
            this.picHeadLeft.Location = new System.Drawing.Point(23, 147);
            this.picHeadLeft.Name = "picHeadLeft";
            this.picHeadLeft.Size = new System.Drawing.Size(41, 41);
            this.picHeadLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHeadLeft.TabIndex = 4;
            this.picHeadLeft.TabStop = false;
            this.picHeadLeft.Visible = false;
            // 
            // picHeadDown
            // 
            this.picHeadDown.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Head21;
            this.picHeadDown.Location = new System.Drawing.Point(64, 188);
            this.picHeadDown.Name = "picHeadDown";
            this.picHeadDown.Size = new System.Drawing.Size(41, 41);
            this.picHeadDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHeadDown.TabIndex = 3;
            this.picHeadDown.TabStop = false;
            this.picHeadDown.Visible = false;
            // 
            // picHeadRight
            // 
            this.picHeadRight.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Head11;
            this.picHeadRight.Location = new System.Drawing.Point(105, 147);
            this.picHeadRight.Name = "picHeadRight";
            this.picHeadRight.Size = new System.Drawing.Size(41, 41);
            this.picHeadRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHeadRight.TabIndex = 2;
            this.picHeadRight.TabStop = false;
            this.picHeadRight.Visible = false;
            // 
            // picHeadUp
            // 
            this.picHeadUp.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Head01;
            this.picHeadUp.Location = new System.Drawing.Point(65, 105);
            this.picHeadUp.Name = "picHeadUp";
            this.picHeadUp.Size = new System.Drawing.Size(41, 41);
            this.picHeadUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHeadUp.TabIndex = 1;
            this.picHeadUp.TabStop = false;
            this.picHeadUp.Visible = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.pic1.Location = new System.Drawing.Point(298, 142);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(48, 48);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic11
            // 
            this.pic11.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Tail0;
            this.pic11.Location = new System.Drawing.Point(298, 622);
            this.pic11.Name = "pic11";
            this.pic11.Size = new System.Drawing.Size(48, 48);
            this.pic11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic11.TabIndex = 20;
            this.pic11.TabStop = false;
            // 
            // picBody
            // 
            this.picBody.Image = global::P16_McKenzieBradley_Snakes.Properties.Resources.Body;
            this.picBody.Location = new System.Drawing.Point(60, 288);
            this.picBody.Name = "picBody";
            this.picBody.Size = new System.Drawing.Size(48, 48);
            this.picBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBody.TabIndex = 21;
            this.picBody.TabStop = false;
            this.picBody.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Sienna;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gold;
            this.lblScore.Location = new System.Drawing.Point(0, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(703, 48);
            this.lblScore.TabIndex = 22;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.BackColor = System.Drawing.Color.Sienna;
            this.lblBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegin.ForeColor = System.Drawing.Color.Gold;
            this.lblBegin.Location = new System.Drawing.Point(284, 18);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(164, 13);
            this.lblBegin.TabIndex = 23;
            this.lblBegin.Text = "Press Space Bar to Begin...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 699);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.picBody);
            this.Controls.Add(this.pic11);
            this.Controls.Add(this.pic0);
            this.Controls.Add(this.picTailLeft);
            this.Controls.Add(this.picTailUp);
            this.Controls.Add(this.picTailRight);
            this.Controls.Add(this.picTailDown);
            this.Controls.Add(this.pic10);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.picHeadLeft);
            this.Controls.Add(this.picHeadDown);
            this.Controls.Add(this.picHeadRight);
            this.Controls.Add(this.picHeadUp);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Bradley McKenzie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTailLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTailUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTailRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTailDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox picHeadUp;
        private System.Windows.Forms.PictureBox picHeadRight;
        private System.Windows.Forms.PictureBox picHeadDown;
        private System.Windows.Forms.PictureBox picHeadLeft;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.PictureBox pic10;
        private System.Windows.Forms.PictureBox picTailDown;
        private System.Windows.Forms.PictureBox picTailRight;
        private System.Windows.Forms.PictureBox picTailUp;
        private System.Windows.Forms.PictureBox picTailLeft;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrDown;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.PictureBox pic0;
        private System.Windows.Forms.PictureBox pic11;
        private System.Windows.Forms.PictureBox picBody;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblBegin;
    }
}

