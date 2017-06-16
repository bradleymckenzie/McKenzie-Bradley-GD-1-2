namespace P11_McKenzieBradley_DominoStack
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmrRight4 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight5 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft5 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft2 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft4 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft3 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft1 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft0 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight2 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight3 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight0 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight1 = new System.Windows.Forms.Timer(this.components);
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(66, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 12;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.HotPink;
            this.lbl1.Location = new System.Drawing.Point(66, 65);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 15);
            this.lbl1.TabIndex = 11;
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.Color.HotPink;
            this.lbl0.Location = new System.Drawing.Point(66, 35);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(25, 15);
            this.lbl0.TabIndex = 10;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.HotPink;
            this.lbl4.Location = new System.Drawing.Point(66, 153);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(25, 15);
            this.lbl4.TabIndex = 15;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.HotPink;
            this.lbl3.Location = new System.Drawing.Point(66, 125);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(25, 15);
            this.lbl3.TabIndex = 14;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.HotPink;
            this.lbl2.Location = new System.Drawing.Point(66, 95);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 15);
            this.lbl2.TabIndex = 13;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.HotPink;
            this.lbl5.Location = new System.Drawing.Point(66, 183);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(25, 15);
            this.lbl5.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(66, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 17;
            // 
            // btnUp
            // 
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.Lime;
            this.btnUp.Location = new System.Drawing.Point(5, 232);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(44, 20);
            this.btnUp.TabIndex = 19;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Lime;
            this.btnExit.Location = new System.Drawing.Point(57, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 20);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "▋▋";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrRight4
            // 
            this.tmrRight4.Tick += new System.EventHandler(this.tmrRight4_Tick);
            // 
            // tmrRight5
            // 
            this.tmrRight5.Tick += new System.EventHandler(this.tmrRight5_Tick);
            // 
            // tmrLeft5
            // 
            this.tmrLeft5.Tick += new System.EventHandler(this.tmrLeft5_Tick);
            // 
            // tmrLeft2
            // 
            this.tmrLeft2.Tick += new System.EventHandler(this.tmrLeft2_Tick);
            // 
            // tmrLeft4
            // 
            this.tmrLeft4.Tick += new System.EventHandler(this.tmrLeft4_Tick);
            // 
            // tmrLeft3
            // 
            this.tmrLeft3.Tick += new System.EventHandler(this.tmrLeft3_Tick);
            // 
            // tmrLeft1
            // 
            this.tmrLeft1.Tick += new System.EventHandler(this.tmrLeft1_Tick);
            // 
            // tmrLeft0
            // 
            this.tmrLeft0.Tick += new System.EventHandler(this.tmrLeft0_Tick);
            // 
            // tmrRight2
            // 
            this.tmrRight2.Tick += new System.EventHandler(this.tmrRight2_Tick);
            // 
            // tmrRight3
            // 
            this.tmrRight3.Tick += new System.EventHandler(this.tmrRight3_Tick);
            // 
            // tmrRight0
            // 
            this.tmrRight0.Tick += new System.EventHandler(this.tmrRight0_Tick);
            // 
            // tmrRight1
            // 
            this.tmrRight1.Tick += new System.EventHandler(this.tmrRight1_Tick);
            // 
            // btnDown
            // 
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.Lime;
            this.btnDown.Location = new System.Drawing.Point(107, 232);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(43, 20);
            this.btnDown.TabIndex = 20;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(154, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bradley McKenzie - DominoStack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmrRight4;
        private System.Windows.Forms.Timer tmrRight5;
        private System.Windows.Forms.Timer tmrLeft5;
        private System.Windows.Forms.Timer tmrLeft2;
        private System.Windows.Forms.Timer tmrLeft4;
        private System.Windows.Forms.Timer tmrLeft3;
        private System.Windows.Forms.Timer tmrLeft1;
        private System.Windows.Forms.Timer tmrLeft0;
        private System.Windows.Forms.Timer tmrRight2;
        private System.Windows.Forms.Timer tmrRight3;
        private System.Windows.Forms.Timer tmrRight0;
        private System.Windows.Forms.Timer tmrRight1;
        private System.Windows.Forms.Button btnDown;
    }
}

