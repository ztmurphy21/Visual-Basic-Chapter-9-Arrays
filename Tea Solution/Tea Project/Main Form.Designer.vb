<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstPounds = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnForEachNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPounds
        '
        Me.lstPounds.Enabled = False
        Me.lstPounds.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPounds.FormattingEnabled = True
        Me.lstPounds.ItemHeight = 17
        Me.lstPounds.Location = New System.Drawing.Point(30, 47)
        Me.lstPounds.Name = "lstPounds"
        Me.lstPounds.Size = New System.Drawing.Size(78, 123)
        Me.lstPounds.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pounds:"
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(181, 47)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(110, 28)
        Me.btnForNext.TabIndex = 0
        Me.btnForNext.Text = "&For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'btnForEachNext
        '
        Me.btnForEachNext.Location = New System.Drawing.Point(181, 81)
        Me.btnForEachNext.Name = "btnForEachNext"
        Me.btnForEachNext.Size = New System.Drawing.Size(110, 28)
        Me.btnForEachNext.TabIndex = 1
        Me.btnForEachNext.Text = "For &Each...Next"
        Me.btnForEachNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(181, 115)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 28)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 206)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnForEachNext)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPounds)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tea Emporium"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstPounds As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnForNext As Button
    Friend WithEvents btnForEachNext As Button
    Friend WithEvents btnExit As Button
End Class
