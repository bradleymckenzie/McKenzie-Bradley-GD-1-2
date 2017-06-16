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
        Me.btnDrawLine = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDrawEllipse = New System.Windows.Forms.Button()
        Me.btnFillEllipse = New System.Windows.Forms.Button()
        Me.btnDrawRectangle = New System.Windows.Forms.Button()
        Me.btnFillRectangle = New System.Windows.Forms.Button()
        Me.btnDrawArc = New System.Windows.Forms.Button()
        Me.btnDrawText = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.FillPie = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDrawLine
        '
        Me.btnDrawLine.BackColor = System.Drawing.Color.White
        Me.btnDrawLine.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawLine.Location = New System.Drawing.Point(12, 12)
        Me.btnDrawLine.Name = "btnDrawLine"
        Me.btnDrawLine.Size = New System.Drawing.Size(108, 23)
        Me.btnDrawLine.TabIndex = 0
        Me.btnDrawLine.Text = "DrawLine"
        Me.btnDrawLine.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDrawLine.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 22)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDrawEllipse
        '
        Me.btnDrawEllipse.BackColor = System.Drawing.Color.White
        Me.btnDrawEllipse.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawEllipse.Location = New System.Drawing.Point(12, 41)
        Me.btnDrawEllipse.Name = "btnDrawEllipse"
        Me.btnDrawEllipse.Size = New System.Drawing.Size(108, 24)
        Me.btnDrawEllipse.TabIndex = 10
        Me.btnDrawEllipse.Text = "DrawEllipse"
        Me.btnDrawEllipse.UseVisualStyleBackColor = False
        '
        'btnFillEllipse
        '
        Me.btnFillEllipse.BackColor = System.Drawing.Color.White
        Me.btnFillEllipse.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillEllipse.Location = New System.Drawing.Point(12, 71)
        Me.btnFillEllipse.Name = "btnFillEllipse"
        Me.btnFillEllipse.Size = New System.Drawing.Size(108, 23)
        Me.btnFillEllipse.TabIndex = 11
        Me.btnFillEllipse.Text = "FillEllipse"
        Me.btnFillEllipse.UseVisualStyleBackColor = False
        '
        'btnDrawRectangle
        '
        Me.btnDrawRectangle.BackColor = System.Drawing.Color.White
        Me.btnDrawRectangle.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawRectangle.Location = New System.Drawing.Point(12, 100)
        Me.btnDrawRectangle.Name = "btnDrawRectangle"
        Me.btnDrawRectangle.Size = New System.Drawing.Size(108, 22)
        Me.btnDrawRectangle.TabIndex = 12
        Me.btnDrawRectangle.Text = "DrawRectangle"
        Me.btnDrawRectangle.UseVisualStyleBackColor = False
        '
        'btnFillRectangle
        '
        Me.btnFillRectangle.BackColor = System.Drawing.Color.White
        Me.btnFillRectangle.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillRectangle.Location = New System.Drawing.Point(12, 128)
        Me.btnFillRectangle.Name = "btnFillRectangle"
        Me.btnFillRectangle.Size = New System.Drawing.Size(108, 24)
        Me.btnFillRectangle.TabIndex = 13
        Me.btnFillRectangle.Text = "FillRectangle"
        Me.btnFillRectangle.UseVisualStyleBackColor = False
        '
        'btnDrawArc
        '
        Me.btnDrawArc.BackColor = System.Drawing.Color.White
        Me.btnDrawArc.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawArc.Location = New System.Drawing.Point(12, 158)
        Me.btnDrawArc.Name = "btnDrawArc"
        Me.btnDrawArc.Size = New System.Drawing.Size(108, 24)
        Me.btnDrawArc.TabIndex = 14
        Me.btnDrawArc.Text = "DrawArc"
        Me.btnDrawArc.UseVisualStyleBackColor = False
        '
        'btnDrawText
        '
        Me.btnDrawText.BackColor = System.Drawing.Color.White
        Me.btnDrawText.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawText.Location = New System.Drawing.Point(12, 218)
        Me.btnDrawText.Name = "btnDrawText"
        Me.btnDrawText.Size = New System.Drawing.Size(108, 23)
        Me.btnDrawText.TabIndex = 16
        Me.btnDrawText.Text = "DrawText"
        Me.btnDrawText.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(12, 287)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 22)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'FillPie
        '
        Me.FillPie.BackColor = System.Drawing.Color.White
        Me.FillPie.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillPie.Location = New System.Drawing.Point(12, 188)
        Me.FillPie.Name = "FillPie"
        Me.FillPie.Size = New System.Drawing.Size(108, 24)
        Me.FillPie.TabIndex = 19
        Me.FillPie.Text = "FillPie"
        Me.FillPie.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(774, 343)
        Me.Controls.Add(Me.FillPie)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDrawText)
        Me.Controls.Add(Me.btnDrawArc)
        Me.Controls.Add(Me.btnFillRectangle)
        Me.Controls.Add(Me.btnDrawRectangle)
        Me.Controls.Add(Me.btnFillEllipse)
        Me.Controls.Add(Me.btnDrawEllipse)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDrawLine)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDrawLine As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDrawEllipse As System.Windows.Forms.Button
    Friend WithEvents btnFillEllipse As System.Windows.Forms.Button
    Friend WithEvents btnDrawRectangle As System.Windows.Forms.Button
    Friend WithEvents btnFillRectangle As System.Windows.Forms.Button
    Friend WithEvents btnDrawArc As System.Windows.Forms.Button
    Friend WithEvents btnDrawText As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents FillPie As System.Windows.Forms.Button

End Class
