
Public Class Main

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stype.SelectedIndexChanged

        If stype.SelectedItem.ToString = "FCFS" Then
            scheduler = 1
            initiate()
        ElseIf stype.SelectedItem.ToString = "Non-Preemptive -Priority" Then
            scheduler = 2
            initiate()
        ElseIf stype.SelectedItem.ToString = "Preemptive -Priority" Then
            scheduler = 3
            initiate()
        ElseIf stype.SelectedItem.ToString = "Non-Preemptive SJF" Then
            scheduler = 4
            initiate()
        ElseIf stype.SelectedItem.ToString = "Preemptive SJF" Then
            scheduler = 5
            initiate()
        ElseIf stype.SelectedItem.ToString = "Round Robin" Then
            scheduler = 6
            stype.Width = 100
            Qtl.Visible = True
            QT.Visible = True
            initiate()
        Else
            scheduler = 0
            clear()
        End If
        If scheduler <> 6 Then
            stype.Width = 258
            Qtl.Visible = False
            QT.Visible = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stype.SelectedIndex = True Then
            MessageBox.Show("Please Select The Scheduler Type first")
        ElseIf scheduler = 1 Or scheduler = 4 Or scheduler = 5 Or scheduler = 6 Then
            addp.Close()
            addp.Show()
        ElseIf scheduler = 2 Or scheduler = 3 Then
            addPri.Close()
            addPri.Show()

        End If


    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Table1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        Table1.AutoSize = True


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (rowsNum(table) > 0) Then
            If scheduler = 1 Then
                sorting(1)
                Dim avg As Double = 0
                Dim t As Integer = 0
                For i = 0 To rowsNum(table) - 1
                    avg += t - sortedT(i).Item(1)
                    t = t + sortedT(i).Item(2)
                Next
                ' MessageBox.Show(avg.ToString)
                avg = avg / rowsNum(table)
                AVGlbl.Text = avg.ToString
                gannt(0)
            ElseIf scheduler = 2 Then
                sorting(3)
                Dim avg As Double = 0
                Dim t As Integer = 0
                For i = 0 To rowsNum(sortedT) - 1
                    avg += t - sortedT(i).Item(1)
                    t = t + sortedT(i).Item(2)
                Next
                ' MessageBox.Show(avg.ToString)
                avg = avg / rowsNum(sortedT)
                AVGlbl.Text = avg.ToString
                gannt(3)
            ElseIf scheduler = 3 Then

                preeSorting(3)
                AVGlbl.Text = preeAvgw().ToString
                gannt(3)
            ElseIf scheduler = 4 Then
                sorting(2)
                Dim avg As Double = 0
                Dim t As Integer = 0
                For i = 0 To rowsNum(sortedT) - 1
                    avg += t - sortedT(i).Item(1)
                    t = t + sortedT(i).Item(2)
                Next
                ' MessageBox.Show(avg.ToString)
                avg = avg / rowsNum(sortedT)
                AVGlbl.Text = avg.ToString
                gannt(2)
            ElseIf scheduler = 5 Then
                preeSorting(2)
                AVGlbl.Text = preeAvgw().ToString
                gannt(2)
            ElseIf scheduler = 6 Then
                Qtime = Convert.ToInt32(QT.Text)
                If Qtime = 0 Or Qtime > 100 Then
                    MessageBox.Show("Please enter Valid Quantum time >>QT")
                Else
                    RRS(Qtime)
                    AVGlbl.Text = preeAvgw().ToString
                    gannt(1)
                End If
            End If
        Else
            MessageBox.Show("Please add Processes first.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        scheduler = 0
        stype.SelectedIndex = 0
        clear()
    End Sub

    Private Sub QT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QT.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s As String
        s = "Hi " + Environment.NewLine + " My name is Mohammad Mahmud Hafez Alberry"
        s += Environment.NewLine + "ASU >> 3rd year >> Computer&Systems >>Sec : 3"
        s += Environment.NewLine + "Email : Mohammedelpry@yahoo.com"
        s += Environment.NewLine + "I hope You interest in my hard work"
        s += Environment.NewLine + " Thanks"
        MessageBox.Show(s)
    End Sub
End Class
