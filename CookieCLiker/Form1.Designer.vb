<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Click_bt = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NoobUPG = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Click_bt
        '
        Me.Click_bt.Location = New System.Drawing.Point(75, 210)
        Me.Click_bt.Name = "Click_bt"
        Me.Click_bt.Size = New System.Drawing.Size(132, 69)
        Me.Click_bt.TabIndex = 0
        Me.Click_bt.Text = "Click"
        Me.Click_bt.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 151)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 23)
        Me.TextBox1.TabIndex = 1
        '
        'NoobUPG
        '
        Me.NoobUPG.Location = New System.Drawing.Point(518, 53)
        Me.NoobUPG.Name = "NoobUPG"
        Me.NoobUPG.Size = New System.Drawing.Size(155, 23)
        Me.NoobUPG.TabIndex = 2
        Me.NoobUPG.Text = "Noob Upgrade"
        Me.NoobUPG.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(152, 298)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(55, 23)
        Me.TextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(518, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Grandma"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.NoobUPG)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Click_bt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Click_bt As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NoobUPG As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
