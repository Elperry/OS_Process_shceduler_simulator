Public Class addPri
    Public co As Color
    Private Sub addPri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = "Note :" + Environment.NewLine + "   if you don't select color" + Environment.NewLine + "it will be selected randomly"
        PID.Text = "P" + rowsNum(table).ToString


        If scheduler = 1 Then
            FCFSGB.Show()
        ElseIf scheduler = 2 Then

        ElseIf scheduler = 0 Then
            FCFSGB.Hide()

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub

    Private Sub arivalT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ariv.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub Burst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Burstb.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PID.Text = ""
        Ariv.Text = ""
        Burstb.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If co = Color.Empty Then
            co = randomColor()

        End If
        If PID.Text = "" Or Ariv.Text = "" Or Burstb.Text = "" Or prioritytxt.Text = "" Then
            MessageBox.Show("Please Make Sure from your input")
        Else
            Dim a, b, p As Integer
            a = Convert.ToInt32(Ariv.Text)
            b = Convert.ToInt32(Burstb.Text)
            p = Convert.ToInt32(prioritytxt.Text)
            addProcess(PID.Text, a, b, p, co)
            co = Color.Empty
        End If
        PID.Text = "P" + rowsNum(table).ToString

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            co = ColorDialog1.Color
        End If
    End Sub
End Class