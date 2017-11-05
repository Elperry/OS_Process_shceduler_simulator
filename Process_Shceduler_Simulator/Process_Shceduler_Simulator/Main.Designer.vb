<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stype = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AVGlbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pgannt = New System.Windows.Forms.Panel()
        Me.readyq = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Qtl = New System.Windows.Forms.Label()
        Me.QT = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(19, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scheduling Type :"
        '
        'stype
        '
        Me.stype.FormattingEnabled = True
        Me.stype.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.stype.Items.AddRange(New Object() {"", "FCFS", "Non-Preemptive -Priority", "Preemptive -Priority", "Round Robin", "Non-Preemptive SJF", "Preemptive SJF"})
        Me.stype.Location = New System.Drawing.Point(164, 41)
        Me.stype.Name = "stype"
        Me.stype.Size = New System.Drawing.Size(258, 21)
        Me.stype.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(22, 93)
        Me.Panel1.MaximumSize = New System.Drawing.Size(400, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 155)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(464, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Process"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(464, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(267, 50)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(464, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(268, 45)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Start Simulator"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(604, 203)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 45)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Exit !!"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Table of Processes :"
        '
        'AVGlbl
        '
        Me.AVGlbl.AutoSize = True
        Me.AVGlbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AVGlbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AVGlbl.ForeColor = System.Drawing.Color.Maroon
        Me.AVGlbl.Location = New System.Drawing.Point(188, 287)
        Me.AVGlbl.MaximumSize = New System.Drawing.Size(70, 20)
        Me.AVGlbl.Name = "AVGlbl"
        Me.AVGlbl.Size = New System.Drawing.Size(61, 18)
        Me.AVGlbl.TabIndex = 11
        Me.AVGlbl.Text = "None !!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(19, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(716, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "---------------------------------------------------------------------------------" &
    "-------------------------------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(19, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(716, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "---------------------------------------------------------------------------------" &
    "-------------------------------------"
        '
        'Pgannt
        '
        Me.Pgannt.BackColor = System.Drawing.Color.Black
        Me.Pgannt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pgannt.Location = New System.Drawing.Point(22, 423)
        Me.Pgannt.MaximumSize = New System.Drawing.Size(710, 4)
        Me.Pgannt.MinimumSize = New System.Drawing.Size(4, 41)
        Me.Pgannt.Name = "Pgannt"
        Me.Pgannt.Size = New System.Drawing.Size(710, 41)
        Me.Pgannt.TabIndex = 17
        '
        'readyq
        '
        Me.readyq.Location = New System.Drawing.Point(327, 314)
        Me.readyq.MaximumSize = New System.Drawing.Size(404, 39)
        Me.readyq.Name = "readyq"
        Me.readyq.Size = New System.Drawing.Size(404, 39)
        Me.readyq.TabIndex = 18
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Process_Shceduler_Simulator.My.Resources.Resources._2
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(22, 372)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(160, 45)
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Process_Shceduler_Simulator.My.Resources.Resources.Untitled_
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(322, 274)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(163, 40)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Process_Shceduler_Simulator.My.Resources.Resources.Untitled_3
        Me.PictureBox2.Location = New System.Drawing.Point(267, 268)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 90)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Process_Shceduler_Simulator.My.Resources.Resources.Untitled_2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(22, 277)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 37)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(16, 470)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 21)
        Me.Panel2.TabIndex = 19
        '
        'Qtl
        '
        Me.Qtl.AutoSize = True
        Me.Qtl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Qtl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qtl.ForeColor = System.Drawing.Color.Maroon
        Me.Qtl.Location = New System.Drawing.Point(285, 42)
        Me.Qtl.Name = "Qtl"
        Me.Qtl.Size = New System.Drawing.Size(42, 18)
        Me.Qtl.TabIndex = 20
        Me.Qtl.Text = "QT  :"
        Me.Qtl.Visible = False
        '
        'QT
        '
        Me.QT.Location = New System.Drawing.Point(333, 42)
        Me.QT.Name = "QT"
        Me.QT.Size = New System.Drawing.Size(89, 20)
        Me.QT.TabIndex = 21
        Me.QT.Text = "10"
        Me.QT.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(464, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 45)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "About Me"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(757, 503)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.QT)
        Me.Controls.Add(Me.Qtl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.readyq)
        Me.Controls.Add(Me.Pgannt)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AVGlbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.stype)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Scheduler Simulator"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents stype As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AVGlbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Pgannt As Panel
    Friend WithEvents readyq As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Qtl As Label
    Friend WithEvents QT As TextBox
    Friend WithEvents Button2 As Button
End Class
