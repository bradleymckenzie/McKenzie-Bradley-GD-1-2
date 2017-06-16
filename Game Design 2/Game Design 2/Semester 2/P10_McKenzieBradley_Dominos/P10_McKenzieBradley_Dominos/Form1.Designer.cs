namespace P10_McKenzieBradley_Dominos
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
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.tmrRight0 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight1 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight2 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight3 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight4 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight5 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft0 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft1 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft2 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft3 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft4 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft5 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.Color.Lime;
            this.lbl0.Location = new System.Drawing.Point(36, 13);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(15, 25);
            this.lbl0.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Lime;
            this.lbl1.Location = new System.Drawing.Point(70, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(15, 25);
            this.lbl1.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Lime;
            this.lbl2.Location = new System.Drawing.Point(104, 13);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(15, 25);
            this.lbl2.TabIndex = 2;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Lime;
            this.lbl5.Location = new System.Drawing.Point(212, 13);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(15, 25);
            this.lbl5.TabIndex = 5;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Lime;
            this.lbl4.Location = new System.Drawing.Point(176, 13);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(15, 25);
            this.lbl4.TabIndex = 4;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Lime;
            this.lbl3.Location = new System.Drawing.Point(140, 13);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(15, 25);
            this.lbl3.TabIndex = 3;
            // 
            // btnRight
            // 
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.Yellow;
            this.btnRight.Location = new System.Drawing.Point(202, 52);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 20);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnPause
            // 
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Yellow;
            this.btnPause.Location = new System.Drawing.Point(103, 52);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(58, 20);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.Yellow;
            this.btnLeft.Location = new System.Drawing.Point(4, 52);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(58, 20);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // tmrRight0
            // 
            this.tmrRight0.Tick += new System.EventHandler(this.tmrRight0_Tick);
            // 
            // tmrRight1
            // 
            this.tmrRight1.Tick += new System.EventHandler(this.tmrRight1_Tick);
            // 
            // tmrRight2
            // 
            this.tmrRight2.Tick += new System.EventHandler(this.tmrRight2_Tick);
            // 
            // tmrRight3
            // 
            this.tmrRight3.Tick += new System.EventHandler(this.tmrRight3_Tick);
            // 
            // tmrRight4
            // 
            this.tmrRight4.Tick += new System.EventHandler(this.tmrRight4_Tick);
            // 
            // tmrRight5
            // 
            this.tmrRight5.Tick += new System.EventHandler(this.tmrRight5_Tick);
            // 
            // tmrLeft0
            // 
            this.tmrLeft0.Tick += new System.EventHandler(this.tmrLeft0_Tick);
            // 
            // tmrLeft1
            // 
            this.tmrLeft1.Tick += new System.EventHandler(this.tmrLeft1_Tick);
            // 
            // tmrLeft2
            // 
            this.tmrLeft2.Tick += new System.EventHandler(this.tmrLeft2_Tick);
            // 
            // tmrLeft3
            // 
            this.tmrLeft3.Tick += new System.EventHandler(this.tmrLeft3_Tick);
            // 
            // tmrLeft4
            // 
            this.tmrLeft4.Tick += new System.EventHandler(this.tmrLeft4_Tick);
            // 
            // tmrLeft5
            // 
            this.tmrLeft5.Tick += new System.EventHandler(this.tmrLeft5_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 25);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(248, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 25);
            this.label2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(264, 76);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bradley McKenzie - Dominos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Timer tmrRight0;
        private System.Windows.Forms.Timer tmrRight1;
        private System.Windows.Forms.Timer tmrRight2;
        private System.Windows.Forms.Timer tmrRight3;
        private System.Windows.Forms.Timer tmrRight4;
        private System.Windows.Forms.Timer tmrRight5;
        private System.Windows.Forms.Timer tmrLeft0;
        private System.Windows.Forms.Timer tmrLeft1;
        private System.Windows.Forms.Timer tmrLeft2;
        private System.Windows.Forms.Timer tmrLeft3;
        private System.Windows.Forms.Timer tmrLeft4;
        private System.Windows.Forms.Timer tmrLeft5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

