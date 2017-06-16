<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.Human = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picFace2 = New System.Windows.Forms.PictureBox()
        Me.picFace3 = New System.Windows.Forms.PictureBox()
        Me.picFace1 = New System.Windows.Forms.PictureBox()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.picHuman = New System.Windows.Forms.PictureBox()
        CType(Me.picFace2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFace3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFace1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHuman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miramonte", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rock Paper Scissors"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Miramonte", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(23, 329)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(376, 35)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRock
        '
        Me.btnRock.Font = New System.Drawing.Font("Miramonte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRock.Location = New System.Drawing.Point(24, 300)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(121, 29)
        Me.btnRock.TabIndex = 2
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.Font = New System.Drawing.Font("Miramonte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScissors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnScissors.Location = New System.Drawing.Point(278, 300)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(121, 29)
        Me.btnScissors.TabIndex = 3
        Me.btnScissors.Text = "Scissors"
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.Font = New System.Drawing.Font("Miramonte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPaper.Location = New System.Drawing.Point(151, 300)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(121, 29)
        Me.btnPaper.TabIndex = 4
        Me.btnPaper.Text = "Paper"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'Human
        '
        Me.Human.AutoSize = True
        Me.Human.Font = New System.Drawing.Font("Miramonte", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Human.Location = New System.Drawing.Point(70, 54)
        Me.Human.Name = "Human"
        Me.Human.Size = New System.Drawing.Size(106, 33)
        Me.Human.TabIndex = 7
        Me.Human.Text = "Human"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miramonte", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Computer"
        '
        'picFace2
        '
        Me.picFace2.Image = Global.WindowsApplication1.My.Resources.Resources.Capture2
        Me.picFace2.Location = New System.Drawing.Point(100, 370)
        Me.picFace2.Name = "picFace2"
        Me.picFace2.Size = New System.Drawing.Size(76, 77)
        Me.picFace2.TabIndex = 11
        Me.picFace2.TabStop = False
        Me.picFace2.Visible = False
        '
        'picFace3
        '
        Me.picFace3.Image = Global.WindowsApplication1.My.Resources.Resources.Capture3
        Me.picFace3.Location = New System.Drawing.Point(182, 370)
        Me.picFace3.Name = "picFace3"
        Me.picFace3.Size = New System.Drawing.Size(76, 77)
        Me.picFace3.TabIndex = 10
        Me.picFace3.TabStop = False
        Me.picFace3.Visible = False
        '
        'picFace1
        '
        Me.picFace1.Image = Global.WindowsApplication1.My.Resources.Resources.Capture
        Me.picFace1.Location = New System.Drawing.Point(12, 370)
        Me.picFace1.Name = "picFace1"
        Me.picFace1.Size = New System.Drawing.Size(76, 77)
        Me.picFace1.TabIndex = 9
        Me.picFace1.TabStop = False
        Me.picFace1.Visible = False
        '
        'picComputer
        '
        Me.picComputer.Image = Global.WindowsApplication1.My.Resources.Resources.Capture
        Me.picComputer.Location = New System.Drawing.Point(232, 105)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(164, 165)
        Me.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picComputer.TabIndex = 6
        Me.picComputer.TabStop = False
        '
        'picHuman
        '
        Me.picHuman.Image = Global.WindowsApplication1.My.Resources.Resources.Capture
        Me.picHuman.Location = New System.Drawing.Point(37, 105)
        Me.picHuman.Name = "picHuman"
        Me.picHuman.Size = New System.Drawing.Size(164, 165)
        Me.picHuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHuman.TabIndex = 5
        Me.picHuman.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 363)
        Me.Controls.Add(Me.picFace2)
        Me.Controls.Add(Me.picFace3)
        Me.Controls.Add(Me.picFace1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Human)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.picHuman)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFace2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFace3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFace1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHuman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents picHuman As System.Windows.Forms.PictureBox
    Friend WithEvents picComputer As System.Windows.Forms.PictureBox
    Friend WithEvents Human As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picFace1 As System.Windows.Forms.PictureBox
    Friend WithEvents picFace3 As System.Windows.Forms.PictureBox
    Friend WithEvents picFace2 As System.Windows.Forms.PictureBox

End Class
