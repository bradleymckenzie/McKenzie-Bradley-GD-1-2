namespace P07_McKenzieBradley_Chaos
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.shp8 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp9 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp7 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp0 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.tmrGo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbrPlay = new System.Windows.Forms.ProgressBar();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.shp8,
            this.shp9,
            this.shp4,
            this.shp5,
            this.shp7,
            this.shp6,
            this.shp2,
            this.shp3,
            this.shp1,
            this.shp0});
            this.shapeContainer1.Size = new System.Drawing.Size(502, 462);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // shp8
            // 
            this.shp8.FillColor = System.Drawing.Color.Pink;
            this.shp8.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp8.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp8.Location = new System.Drawing.Point(400, 25);
            this.shp8.Name = "shp8";
            this.shp8.Size = new System.Drawing.Size(50, 50);
            this.shp8.Visible = false;
            this.shp8.MouseEnter += new System.EventHandler(this.shp8_MouseEnter);
            // 
            // shp9
            // 
            this.shp9.FillColor = System.Drawing.Color.Pink;
            this.shp9.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp9.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp9.Location = new System.Drawing.Point(450, 25);
            this.shp9.Name = "shp9";
            this.shp9.Size = new System.Drawing.Size(50, 50);
            this.shp9.Visible = false;
            this.shp9.MouseEnter += new System.EventHandler(this.shp9_MouseEnter);
            // 
            // shp4
            // 
            this.shp4.FillColor = System.Drawing.Color.Pink;
            this.shp4.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp4.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp4.Location = new System.Drawing.Point(200, 25);
            this.shp4.Name = "shp4";
            this.shp4.Size = new System.Drawing.Size(50, 50);
            this.shp4.Visible = false;
            this.shp4.MouseEnter += new System.EventHandler(this.shp4_MouseEnter);
            // 
            // shp5
            // 
            this.shp5.FillColor = System.Drawing.Color.Pink;
            this.shp5.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp5.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp5.Location = new System.Drawing.Point(250, 25);
            this.shp5.Name = "shp5";
            this.shp5.Size = new System.Drawing.Size(50, 50);
            this.shp5.Visible = false;
            this.shp5.MouseEnter += new System.EventHandler(this.shp5_MouseEnter);
            // 
            // shp7
            // 
            this.shp7.FillColor = System.Drawing.Color.Pink;
            this.shp7.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp7.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp7.Location = new System.Drawing.Point(350, 25);
            this.shp7.Name = "shp7";
            this.shp7.Size = new System.Drawing.Size(50, 50);
            this.shp7.Visible = false;
            this.shp7.MouseEnter += new System.EventHandler(this.shp7_MouseEnter);
            // 
            // shp6
            // 
            this.shp6.FillColor = System.Drawing.Color.Pink;
            this.shp6.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp6.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp6.Location = new System.Drawing.Point(300, 25);
            this.shp6.Name = "shp6";
            this.shp6.Size = new System.Drawing.Size(50, 50);
            this.shp6.Visible = false;
            this.shp6.MouseEnter += new System.EventHandler(this.shp6_MouseEnter);
            // 
            // shp2
            // 
            this.shp2.FillColor = System.Drawing.Color.Pink;
            this.shp2.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp2.Location = new System.Drawing.Point(100, 25);
            this.shp2.Name = "shp2";
            this.shp2.Size = new System.Drawing.Size(50, 50);
            this.shp2.Visible = false;
            this.shp2.MouseEnter += new System.EventHandler(this.shp2_MouseEnter);
            // 
            // shp3
            // 
            this.shp3.FillColor = System.Drawing.Color.Pink;
            this.shp3.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp3.Location = new System.Drawing.Point(150, 25);
            this.shp3.Name = "shp3";
            this.shp3.Size = new System.Drawing.Size(50, 50);
            this.shp3.Visible = false;
            this.shp3.MouseEnter += new System.EventHandler(this.shp3_MouseEnter);
            // 
            // shp1
            // 
            this.shp1.FillColor = System.Drawing.Color.Pink;
            this.shp1.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp1.Location = new System.Drawing.Point(50, 25);
            this.shp1.Name = "shp1";
            this.shp1.Size = new System.Drawing.Size(50, 50);
            this.shp1.Visible = false;
            this.shp1.MouseEnter += new System.EventHandler(this.shp1_MouseEnter);
            // 
            // shp0
            // 
            this.shp0.FillColor = System.Drawing.Color.Pink;
            this.shp0.FillGradientColor = System.Drawing.Color.HotPink;
            this.shp0.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.shp0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shp0.Location = new System.Drawing.Point(0, 25);
            this.shp0.Name = "shp0";
            this.shp0.Size = new System.Drawing.Size(50, 50);
            this.shp0.Visible = false;
            this.shp0.MouseEnter += new System.EventHandler(this.shp0_MouseEnter);
            // 
            // tmrGo
            // 
            this.tmrGo.Interval = 10;
            this.tmrGo.Tick += new System.EventHandler(this.tmrGo_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Pink;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinkToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.whiteToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.greyToolStripMenuItem.Text = "Gray";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(244, 430);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // pbrPlay
            // 
            this.pbrPlay.Location = new System.Drawing.Point(1, 446);
            this.pbrPlay.Name = "pbrPlay";
            this.pbrPlay.Size = new System.Drawing.Size(500, 15);
            this.pbrPlay.TabIndex = 4;
            this.pbrPlay.Value = 100;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(502, 462);
            this.Controls.Add(this.pbrPlay);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chaos - Bradley McKenzie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp8;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp9;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp5;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp7;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp6;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp0;
        private System.Windows.Forms.Timer tmrGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar pbrPlay;
        private System.Windows.Forms.Timer tmrTimer;
    }
}

