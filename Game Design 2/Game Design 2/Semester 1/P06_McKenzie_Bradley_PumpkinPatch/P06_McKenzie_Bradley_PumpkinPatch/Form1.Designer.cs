namespace P06_McKenzie_Bradley_PumpkinPatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.pic0 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblBegin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrLeft
            // 
            this.tmrLeft.Interval = 10;
            this.tmrLeft.Tick += new System.EventHandler(this.tmrLeft_Tick);
            // 
            // tmrRight
            // 
            this.tmrRight.Interval = 10;
            this.tmrRight.Tick += new System.EventHandler(this.tmrRight_Tick);
            // 
            // tmrUp
            // 
            this.tmrUp.Interval = 10;
            this.tmrUp.Tick += new System.EventHandler(this.tmrUp_Tick);
            // 
            // tmrDown
            // 
            this.tmrDown.Interval = 10;
            this.tmrDown.Tick += new System.EventHandler(this.tmrDown_Tick);
            // 
            // picGhost
            // 
            this.picGhost.BackColor = System.Drawing.Color.Transparent;
            this.picGhost.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.fatghost4;
            this.picGhost.Location = new System.Drawing.Point(178, 180);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(25, 25);
            this.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGhost.TabIndex = 0;
            this.picGhost.TabStop = false;
            // 
            // pic0
            // 
            this.pic0.BackColor = System.Drawing.Color.Transparent;
            this.pic0.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic0.Location = new System.Drawing.Point(46, 38);
            this.pic0.Name = "pic0";
            this.pic0.Size = new System.Drawing.Size(20, 20);
            this.pic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic0.TabIndex = 1;
            this.pic0.TabStop = false;
            this.pic0.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(176, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(22, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "0.0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic1.Location = new System.Drawing.Point(21, 297);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(20, 20);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            this.pic1.Visible = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic2.Location = new System.Drawing.Point(245, 81);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(20, 20);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic2.TabIndex = 4;
            this.pic2.TabStop = false;
            this.pic2.Visible = false;
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.Transparent;
            this.pic3.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic3.Location = new System.Drawing.Point(176, 285);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(20, 20);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic3.TabIndex = 5;
            this.pic3.TabStop = false;
            this.pic3.Visible = false;
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.Transparent;
            this.pic4.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic4.Location = new System.Drawing.Point(12, 164);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(20, 20);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic4.TabIndex = 6;
            this.pic4.TabStop = false;
            this.pic4.Visible = false;
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.Transparent;
            this.pic5.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic5.Location = new System.Drawing.Point(301, 318);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(20, 20);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic5.TabIndex = 7;
            this.pic5.TabStop = false;
            this.pic5.Visible = false;
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.Color.Transparent;
            this.pic6.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic6.Location = new System.Drawing.Point(143, 101);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(20, 20);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic6.TabIndex = 8;
            this.pic6.TabStop = false;
            this.pic6.Visible = false;
            // 
            // pic7
            // 
            this.pic7.BackColor = System.Drawing.Color.Transparent;
            this.pic7.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic7.Location = new System.Drawing.Point(319, 208);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(20, 20);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic7.TabIndex = 9;
            this.pic7.TabStop = false;
            this.pic7.Visible = false;
            // 
            // pic8
            // 
            this.pic8.BackColor = System.Drawing.Color.Transparent;
            this.pic8.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic8.Location = new System.Drawing.Point(85, 213);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(20, 20);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic8.TabIndex = 10;
            this.pic8.TabStop = false;
            this.pic8.Visible = false;
            // 
            // pic9
            // 
            this.pic9.BackColor = System.Drawing.Color.Transparent;
            this.pic9.Image = global::P06_McKenzie_Bradley_PumpkinPatch.Properties.Resources.pumpkin2;
            this.pic9.Location = new System.Drawing.Point(335, 81);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(20, 20);
            this.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic9.TabIndex = 11;
            this.pic9.TabStop = false;
            this.pic9.Visible = false;
            // 
            // tmrTime
            // 
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.BackColor = System.Drawing.Color.Black;
            this.lblBegin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBegin.Location = new System.Drawing.Point(129, 162);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(125, 13);
            this.lblBegin.TabIndex = 12;
            this.lblBegin.Text = "Click Spacebar To Begin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic0);
            this.Controls.Add(this.lblBegin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "McKenzie Bradley - Pumpkin Patch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrDown;
        private System.Windows.Forms.PictureBox pic0;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblBegin;
    }
}

