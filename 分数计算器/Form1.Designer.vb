<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form 重写 Dispose，以清理组件列表。
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

  'Windows 窗体设计器所必需的
  Private components As System.ComponentModel.IContainer

  '注意: 以下过程是 Windows 窗体设计器所必需的
  '可以使用 Windows 窗体设计器修改它。  
  '不要使用代码编辑器修改它。
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
  Me.TextBox1 = New System.Windows.Forms.TextBox()
  Me.Label1 = New System.Windows.Forms.Label()
  Me.TextBox2 = New System.Windows.Forms.TextBox()
  Me.Button1 = New System.Windows.Forms.Button()
  Me.Button2 = New System.Windows.Forms.Button()
  Me.Button3 = New System.Windows.Forms.Button()
  Me.Button4 = New System.Windows.Forms.Button()
  Me.TextBox3 = New System.Windows.Forms.TextBox()
  Me.Label2 = New System.Windows.Forms.Label()
  Me.TextBox4 = New System.Windows.Forms.TextBox()
  Me.Label3 = New System.Windows.Forms.Label()
  Me.TextBox5 = New System.Windows.Forms.TextBox()
  Me.Label4 = New System.Windows.Forms.Label()
  Me.TextBox6 = New System.Windows.Forms.TextBox()
  Me.SuspendLayout()
  '
  'TextBox1
  '
  Me.TextBox1.Location = New System.Drawing.Point(12, 12)
  Me.TextBox1.Name = "TextBox1"
  Me.TextBox1.Size = New System.Drawing.Size(50, 21)
  Me.TextBox1.TabIndex = 0
  Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
  '
  'Label1
  '
  Me.Label1.AutoSize = True
  Me.Label1.Location = New System.Drawing.Point(8, 36)
  Me.Label1.Name = "Label1"
  Me.Label1.Size = New System.Drawing.Size(59, 12)
  Me.Label1.TabIndex = 1
  Me.Label1.Text = "---------"
  '
  'TextBox2
  '
  Me.TextBox2.Location = New System.Drawing.Point(12, 51)
  Me.TextBox2.Name = "TextBox2"
  Me.TextBox2.Size = New System.Drawing.Size(50, 21)
  Me.TextBox2.TabIndex = 2
  Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
  '
  'Button1
  '
  Me.Button1.Location = New System.Drawing.Point(68, 7)
  Me.Button1.Name = "Button1"
  Me.Button1.Size = New System.Drawing.Size(18, 18)
  Me.Button1.TabIndex = 3
  Me.Button1.Text = "＋"
  Me.Button1.UseVisualStyleBackColor = True
  '
  'Button2
  '
  Me.Button2.Location = New System.Drawing.Point(68, 24)
  Me.Button2.Name = "Button2"
  Me.Button2.Size = New System.Drawing.Size(18, 18)
  Me.Button2.TabIndex = 4
  Me.Button2.Text = "－"
  Me.Button2.UseVisualStyleBackColor = True
  '
  'Button3
  '
  Me.Button3.Location = New System.Drawing.Point(68, 41)
  Me.Button3.Name = "Button3"
  Me.Button3.Size = New System.Drawing.Size(18, 18)
  Me.Button3.TabIndex = 5
  Me.Button3.Text = "×"
  Me.Button3.UseVisualStyleBackColor = True
  '
  'Button4
  '
  Me.Button4.Location = New System.Drawing.Point(68, 58)
  Me.Button4.Name = "Button4"
  Me.Button4.Size = New System.Drawing.Size(18, 18)
  Me.Button4.TabIndex = 6
  Me.Button4.Text = "÷"
  Me.Button4.UseVisualStyleBackColor = True
  '
  'TextBox3
  '
  Me.TextBox3.Location = New System.Drawing.Point(92, 12)
  Me.TextBox3.Name = "TextBox3"
  Me.TextBox3.Size = New System.Drawing.Size(50, 21)
  Me.TextBox3.TabIndex = 7
  Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
  '
  'Label2
  '
  Me.Label2.AutoSize = True
  Me.Label2.Location = New System.Drawing.Point(88, 36)
  Me.Label2.Name = "Label2"
  Me.Label2.Size = New System.Drawing.Size(59, 12)
  Me.Label2.TabIndex = 8
  Me.Label2.Text = "---------"
  '
  'TextBox4
  '
  Me.TextBox4.Location = New System.Drawing.Point(92, 51)
  Me.TextBox4.Name = "TextBox4"
  Me.TextBox4.Size = New System.Drawing.Size(50, 21)
  Me.TextBox4.TabIndex = 9
  Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
  '
  'Label3
  '
  Me.Label3.AutoSize = True
  Me.Label3.Font = New System.Drawing.Font("宋体", 30.0!)
  Me.Label3.Location = New System.Drawing.Point(148, 22)
  Me.Label3.Name = "Label3"
  Me.Label3.Size = New System.Drawing.Size(57, 40)
  Me.Label3.TabIndex = 10
  Me.Label3.Text = "＝"
  '
  'TextBox5
  '
  Me.TextBox5.Location = New System.Drawing.Point(211, 12)
  Me.TextBox5.Name = "TextBox5"
  Me.TextBox5.ReadOnly = True
  Me.TextBox5.Size = New System.Drawing.Size(50, 21)
  Me.TextBox5.TabIndex = 11
  Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
  '
  'Label4
  '
  Me.Label4.AutoSize = True
  Me.Label4.Location = New System.Drawing.Point(207, 36)
  Me.Label4.Name = "Label4"
  Me.Label4.Size = New System.Drawing.Size(59, 12)
  Me.Label4.TabIndex = 12
  Me.Label4.Text = "---------"
  '
  'TextBox6
  '
  Me.TextBox6.Location = New System.Drawing.Point(211, 51)
  Me.TextBox6.Name = "TextBox6"
  Me.TextBox6.ReadOnly = True
  Me.TextBox6.Size = New System.Drawing.Size(50, 21)
  Me.TextBox6.TabIndex = 13
  Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
  '
  'Form1
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(273, 84)
  Me.Controls.Add(Me.TextBox6)
  Me.Controls.Add(Me.Label4)
  Me.Controls.Add(Me.TextBox5)
  Me.Controls.Add(Me.Label3)
  Me.Controls.Add(Me.TextBox4)
  Me.Controls.Add(Me.Label2)
  Me.Controls.Add(Me.TextBox3)
  Me.Controls.Add(Me.Button4)
  Me.Controls.Add(Me.Button3)
  Me.Controls.Add(Me.Button2)
  Me.Controls.Add(Me.Button1)
  Me.Controls.Add(Me.TextBox2)
  Me.Controls.Add(Me.Label1)
  Me.Controls.Add(Me.TextBox1)
  Me.MaximizeBox = False
  Me.Name = "Form1"
  Me.Text = "分数计算器"
  Me.ResumeLayout(False)
  Me.PerformLayout()

  End Sub

  Friend WithEvents TextBox1 As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents TextBox2 As TextBox
  Friend WithEvents Button1 As Button
  Friend WithEvents Button2 As Button
  Friend WithEvents Button3 As Button
  Friend WithEvents Button4 As Button
  Friend WithEvents TextBox3 As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents TextBox4 As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents TextBox5 As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents TextBox6 As TextBox
End Class
