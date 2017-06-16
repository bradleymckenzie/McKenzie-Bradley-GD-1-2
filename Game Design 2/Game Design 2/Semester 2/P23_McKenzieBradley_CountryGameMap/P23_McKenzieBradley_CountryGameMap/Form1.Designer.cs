namespace P23_McKenzieBradley_CountryGameMap
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
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.lblJetLarge = new System.Windows.Forms.Label();
            this.lblJetSmall = new System.Windows.Forms.Label();
            this.picMapSmall = new System.Windows.Forms.PictureBox();
            this.picMapLarge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMapSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapLarge)).BeginInit();
            this.SuspendLayout();
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
            // lblJetLarge
            // 
            this.lblJetLarge.BackColor = System.Drawing.Color.Black;
            this.lblJetLarge.Location = new System.Drawing.Point(361, 246);
            this.lblJetLarge.Name = "lblJetLarge";
            this.lblJetLarge.Size = new System.Drawing.Size(15, 15);
            this.lblJetLarge.TabIndex = 3;
            // 
            // lblJetSmall
            // 
            this.lblJetSmall.BackColor = System.Drawing.Color.Black;
            this.lblJetSmall.Location = new System.Drawing.Point(472, 51);
            this.lblJetSmall.Name = "lblJetSmall";
            this.lblJetSmall.Size = new System.Drawing.Size(10, 10);
            this.lblJetSmall.TabIndex = 2;
            // 
            // picMapSmall
            // 
            this.picMapSmall.BackColor = System.Drawing.Color.White;
            this.picMapSmall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMapSmall.Image = global::P23_McKenzieBradley_CountryGameMap.Properties.Resources._1;
            this.picMapSmall.Location = new System.Drawing.Point(401, 2);
            this.picMapSmall.Name = "picMapSmall";
            this.picMapSmall.Size = new System.Drawing.Size(100, 100);
            this.picMapSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMapSmall.TabIndex = 1;
            this.picMapSmall.TabStop = false;
            // 
            // picMapLarge
            // 
            this.picMapLarge.BackColor = System.Drawing.Color.White;
            this.picMapLarge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMapLarge.Image = global::P23_McKenzieBradley_CountryGameMap.Properties.Resources._1;
            this.picMapLarge.Location = new System.Drawing.Point(1, 0);
            this.picMapLarge.Name = "picMapLarge";
            this.picMapLarge.Size = new System.Drawing.Size(502, 502);
            this.picMapLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMapLarge.TabIndex = 0;
            this.picMapLarge.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 503);
            this.Controls.Add(this.lblJetLarge);
            this.Controls.Add(this.lblJetSmall);
            this.Controls.Add(this.picMapSmall);
            this.Controls.Add(this.picMapLarge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bradley McKenzie - Country Game Map";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picMapSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapLarge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMapLarge;
        private System.Windows.Forms.PictureBox picMapSmall;
        private System.Windows.Forms.Label lblJetSmall;
        private System.Windows.Forms.Label lblJetLarge;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrDown;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Timer tmrRight;
    }
}

