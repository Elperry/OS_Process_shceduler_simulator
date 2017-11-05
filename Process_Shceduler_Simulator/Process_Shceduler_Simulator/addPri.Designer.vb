<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addPri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addPri))
        Me.FCFSGB = New System.Windows.Forms.GroupBox()
        Me.prioritytxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Ariv = New System.Windows.Forms.TextBox()
        Me.Burstb = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FCFSGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'FCFSGB
        '
        Me.FCFSGB.Controls.Add(Me.prioritytxt)
        Me.FCFSGB.Controls.Add(Me.Label5)
        Me.FCFSGB.Controls.Add(Me.Label4)
        Me.FCFSGB.Controls.Add(Me.Button4)
        Me.FCFSGB.Controls.Add(Me.Ariv)
        Me.FCFSGB.Controls.Add(Me.Burstb)
        Me.FCFSGB.Controls.Add(Me.Button3)
        Me.FCFSGB.Controls.Add(Me.Button2)
        Me.FCFSGB.Controls.Add(Me.Button1)
        Me.FCFSGB.Controls.Add(Me.PID)
        Me.FCFSGB.Controls.Add(Me.Label3)
        Me.FCFSGB.Controls.Add(Me.Label2)
        Me.FCFSGB.Controls.Add(Me.Label1)
        Me.FCFSGB.Location = New System.Drawing.Point(12, 12)
        Me.FCFSGB.Name = "FCFSGB"
        Me.FCFSGB.Size = New System.Drawing.Size(286, 222)
        Me.FCFSGB.TabIndex = 0
        Me.FCFSGB.TabStop = False
        Me.FCFSGB.Text = "GroupBox1"
        '
        'prioritytxt
        '
        Me.prioritytxt.Location = New System.Drawing.Point(130, 107)
        Me.prioritytxt.Name = "prioritytxt"
        Me.prioritytxt.Size = New System.Drawing.Size(147, 20)
        Me.prioritytxt.TabIndex = 9
        Me.prioritytxt.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(9, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Priority       :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(105, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(352, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Note : If don't choose color I'm going to choose for you"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 137)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 21)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Choose Color"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Ariv
        '
        Me.Ariv.Location = New System.Drawing.Point(129, 54)
        Me.Ariv.Name = "Ariv"
        Me.Ariv.Size = New System.Drawing.Size(147, 20)
        Me.Ariv.TabIndex = 2
        Me.Ariv.Text = "0"
        '
        'Burstb
        '
        Me.Burstb.Location = New System.Drawing.Point(129, 80)
        Me.Burstb.Name = "Burstb"
        Me.Burstb.Size = New System.Drawing.Size(148, 20)
        Me.Burstb.TabIndex = 3
        Me.Burstb.Text = "5"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(202, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 21)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 21)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Add Process"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 21)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PID
        '
        Me.PID.Location = New System.Drawing.Point(129, 28)
        Me.PID.Name = "PID"
        Me.PID.Size = New System.Drawing.Size(148, 20)
        Me.PID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Arival Time :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(5, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Burst Time  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Process ID  :"
        '
        'addPri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(309, 240)
        Me.Controls.Add(Me.FCFSGB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(325, 279)
        Me.MinimumSize = New System.Drawing.Size(325, 279)
        Me.Name = "addPri"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Process"
        Me.TopMost = True
        Me.FCFSGB.ResumeLayout(False)
        Me.FCFSGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FCFSGB As GroupBox
    Friend WithEvents PID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Ariv As TextBox
    Friend WithEvents Burstb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents prioritytxt As TextBox
    Friend WithEvents Label5 As Label
End Class
