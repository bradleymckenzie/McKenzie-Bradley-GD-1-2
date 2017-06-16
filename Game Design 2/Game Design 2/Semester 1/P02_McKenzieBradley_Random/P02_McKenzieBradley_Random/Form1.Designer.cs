namespace P02_McKenzieBradley_Random
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
            this.lblFace = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbrGame = new System.Windows.Forms.ProgressBar();
            this.tmrPlay = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFace
            // 
            this.lblFace.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblFace.ForeColor = System.Drawing.Color.Lime;
            this.lblFace.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFace.Location = new System.Drawing.Point(219, 211);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(25, 25);
            this.lblFace.TabIndex = 0;
            this.lblFace.Text = "L";
            this.lblFace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFace.Click += new System.EventHandler(this.lblFace_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Lime;
            this.lblScore.Location = new System.Drawing.Point(225, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(14, 15);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // pbrGame
            // 
            this.pbrGame.BackColor = System.Drawing.Color.Black;
            this.pbrGame.Location = new System.Drawing.Point(2, 450);
            this.pbrGame.Name = "pbrGame";
            this.pbrGame.Size = new System.Drawing.Size(480, 10);
            this.pbrGame.TabIndex = 2;
            this.pbrGame.Value = 100;
            // 
            // tmrPlay
            // 
            this.tmrPlay.Enabled = true;
            this.tmrPlay.Interval = 200;
            this.tmrPlay.Tick += new System.EventHandler(this.tmrPlay_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.pbrGame);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblFace);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random - Bradley McKenzie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar pbrGame;
        private System.Windows.Forms.Timer tmrPlay;
    }
}

