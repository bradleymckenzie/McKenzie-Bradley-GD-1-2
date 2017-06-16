namespace P18_McKenzieBradley_Crane
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRope1 = new System.Windows.Forms.Label();
            this.lblRope2 = new System.Windows.Forms.Label();
            this.lblHoist = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrLift = new System.Windows.Forms.Timer(this.components);
            this.lblHook = new System.Windows.Forms.Label();
            this.picCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "American Crane Inc.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRope1
            // 
            this.lblRope1.BackColor = System.Drawing.Color.Silver;
            this.lblRope1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRope1.Location = new System.Drawing.Point(330, 30);
            this.lblRope1.Name = "lblRope1";
            this.lblRope1.Size = new System.Drawing.Size(10, 50);
            this.lblRope1.TabIndex = 1;
            // 
            // lblRope2
            // 
            this.lblRope2.BackColor = System.Drawing.Color.Silver;
            this.lblRope2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRope2.Location = new System.Drawing.Point(360, 30);
            this.lblRope2.Name = "lblRope2";
            this.lblRope2.Size = new System.Drawing.Size(10, 50);
            this.lblRope2.TabIndex = 2;
            // 
            // lblHoist
            // 
            this.lblHoist.BackColor = System.Drawing.Color.Gold;
            this.lblHoist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoist.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoist.Location = new System.Drawing.Point(305, 80);
            this.lblHoist.Name = "lblHoist";
            this.lblHoist.Size = new System.Drawing.Size(90, 20);
            this.lblHoist.TabIndex = 3;
            this.lblHoist.Text = "10 Tons";
            this.lblHoist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttachment
            // 
            this.lblAttachment.BackColor = System.Drawing.Color.Silver;
            this.lblAttachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttachment.Location = new System.Drawing.Point(340, 100);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(20, 20);
            this.lblAttachment.TabIndex = 4;
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
            // tmrLift
            // 
            this.tmrLift.Enabled = true;
            this.tmrLift.Interval = 10;
            this.tmrLift.Tick += new System.EventHandler(this.tmrLift_Tick);
            // 
            // lblHook
            // 
            this.lblHook.BackColor = System.Drawing.Color.Gold;
            this.lblHook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHook.Location = new System.Drawing.Point(310, 120);
            this.lblHook.Name = "lblHook";
            this.lblHook.Size = new System.Drawing.Size(80, 15);
            this.lblHook.TabIndex = 5;
            // 
            // picCar
            // 
            this.picCar.BackColor = System.Drawing.Color.Transparent;
            this.picCar.Image = global::P18_McKenzieBradley_Crane.Properties.Resources.container;
            this.picCar.Location = new System.Drawing.Point(300, 600);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(100, 35);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 6;
            this.picCar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 637);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.lblHook);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.lblHoist);
            this.Controls.Add(this.lblRope2);
            this.Controls.Add(this.lblRope1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bradley McKenzie - Crane";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRope1;
        private System.Windows.Forms.Label lblRope2;
        private System.Windows.Forms.Label lblHoist;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrDown;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrLift;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Label lblHook;
    }
}

