Module PublicVars
    Public table, sortedT, rqueue, trq, tmpT As New DataTable
    Public Table1, progress, queue As New TableLayoutPanel
    Public tmpRow As DataRow
    Public scheduler, Qtime As Integer
    Public myFont As Font = New Font("Comic Sans MS", 10, FontStyle.Bold Or FontStyle.Underline)
    Public Sub swapData(ByRef a As DataRow, ByRef b As DataRow)
        Dim cols As Integer = table.Columns.Count
        For i = 0 To cols - 1
            If i = 0 Then
                Dim c As String = a(i)
                a(i) = b(i)
                b(i) = c
            ElseIf i = cols - 1 Then
                Dim c As Color = a(i)
                a(i) = b(i)
                b(i) = c
            Else
                Dim c As Integer = a(i)
                a(i) = b(i)
                b(i) = c
            End If
        Next
    End Sub
    Public Function labls() As Label
        Dim x As New Label
        x.Font = myFont
        x.ForeColor = Color.Blue
        x.AutoSize = True
        x.Margin = New Padding(0)
        Return x
    End Function
    Public Function colredlbl(ByVal c As Color) As Label
        Dim x As New Label
        x.BackColor = c
        x.Font = New Font("Comic Sans MS", 5)
        x.Width = 1
        x.Text = " "
        x.Height = 37
        x.Margin = New Padding(0)
        Return x
    End Function
    Public Sub clear()
        table.Clear()
        sortedT.Clear()
        rqueue.Clear()
        trq.Clear()
        table.Columns.Clear()
        sortedT.Columns.Clear()
        rqueue.Columns.Clear()
        trq.Columns.Clear()
        tmpT.Columns.Clear()
        Table1.Controls.Clear()
        progress.Controls.Clear()
        queue.Controls.Clear()
        Main.AVGlbl.Text = "None !!"
        Main.Panel2.Controls.Clear()
    End Sub
    Public Sub initiate()
        clear()
        If (scheduler = 1 Or scheduler = 4 Or scheduler = 5 Or scheduler = 6) Then
            table.Columns.Add("PID", GetType(String))
            table.Columns.Add("arival_Time", GetType(Integer))
            table.Columns.Add("Burst_Time", GetType(Integer))
            table.Columns.Add("Collor", GetType(Color))
            Dim process As Label = labls()
            Dim arivalT As Label = labls()
            Dim burstT As Label = labls()
            Dim pcolor As Label = labls()
            pcolor.Text = "P-Color"
            process.Text = "Process"
            arivalT.Text = "Arival Time"
            burstT.Text = "Burst Time"
            Table1.Dock = DockStyle.Fill

            Table1.Controls.Add(process, 0, 0)
            Table1.Controls.Add(arivalT, 1, 0)
            Table1.Controls.Add(burstT, 2, 0)
            Table1.Controls.Add(pcolor, 3, 0)
            Main.Panel1.Controls.Add(Table1)
        ElseIf scheduler = 2 Or scheduler = 3 Then
            table.Columns.Add("PID", GetType(String))
            table.Columns.Add("Arival_Time", GetType(Integer))
            table.Columns.Add("Burst_Time", GetType(Integer))
            table.Columns.Add("Priority", GetType(Integer))
            table.Columns.Add("Color", GetType(Color))
            Dim process As Label = labls()
            Dim arivalT As Label = labls()
            Dim burstT As Label = labls()
            Dim pcolor As Label = labls()
            Dim priority As Label = labls()
            pcolor.Text = "P-Color"
            process.Text = "Process"
            arivalT.Text = "Arival_Time"
            burstT.Text = "Burst Time"
            priority.Text = "Priority"
            Table1.Dock = DockStyle.Fill

            Table1.Controls.Add(process, 0, 0)
            Table1.Controls.Add(arivalT, 1, 0)
            Table1.Controls.Add(burstT, 2, 0)
            Table1.Controls.Add(priority, 3, 0)
            Table1.Controls.Add(pcolor, 4, 0)
            Main.Panel1.Controls.Add(Table1)
        End If

    End Sub
    Public Sub addProcess(ByVal pid As String, ByVal a As Integer, ByVal b As Integer, ByVal c As Color)
        Dim process As Label = labls()
        Dim arivalT As Label = labls()
        Dim burstT As Label = labls()
        Dim pcolor As Label = New Label
        pcolor.Font = New Font("Comic Sans MS", 10, FontStyle.Bold)
        pcolor.Width = 20
        pcolor.Height = 20
        pcolor.Text = " "
        pcolor.BackColor = c
        Dim row As DataRow = table.NewRow()
        If (scheduler = 1 Or scheduler = 4 Or scheduler = 5 Or scheduler = 6) Then
            row(0) = pid
            row(1) = a
            row(2) = b
            row(3) = c
            table.Rows.Add(row)
            'MessageBox.Show(row(0) + " " + row(1).ToString)
            process.Text = pid
            arivalT.Text = a.ToString
            burstT.Text = b.ToString
            Table1.Dock = DockStyle.Fill
            Dim r As Integer = rowsNum(table)
            Table1.Controls.Add(process, 0, r)
            Table1.Controls.Add(arivalT, 1, r)
            Table1.Controls.Add(burstT, 2, r)
            Table1.Controls.Add(pcolor, 3, r)
            Main.Panel1.Controls.Add(Table1)
            Main.Panel1.AutoScrollMinSize = New Size(600, 24 * (rowsNum(table) + 1))

        End If
    End Sub
    Public Sub addProcess(ByVal pid As String, ByVal a As Integer, ByVal b As Integer, ByVal p As Integer, ByVal c As Color)
        Dim process As Label = labls()
        Dim arivalT As Label = labls()
        Dim burstT As Label = labls()
        Dim priority As Label = labls()
        Dim pcolor As Label = New Label
        pcolor.Font = New Font("Comic Sans MS", 10, FontStyle.Bold)
        pcolor.Width = 20
        pcolor.Height = 20
        pcolor.Text = " "
        pcolor.BackColor = c
        Dim row As DataRow = table.NewRow()
        If (scheduler = 2 Or scheduler = 3) Then
            row(0) = pid
            row(1) = a
            row(2) = b
            row(3) = p
            row(4) = c
            table.Rows.Add(row)
            'MessageBox.Show(row(0) + " " + row(1).ToString)
            process.Text = pid
            arivalT.Text = a.ToString
            burstT.Text = b.ToString
            priority.Text = p.ToString
            Table1.Dock = DockStyle.Fill
            Dim r As Integer = rowsNum(table)
            Table1.Controls.Add(process, 0, r)
            Table1.Controls.Add(arivalT, 1, r)
            Table1.Controls.Add(burstT, 2, r)
            Table1.Controls.Add(priority, 3, r)
            Table1.Controls.Add(pcolor, 4, r)
            Main.Panel1.Controls.Add(Table1)
            Main.Panel1.AutoScrollMinSize = New Size(600, 24 * (rowsNum(table) + 1))

        End If
    End Sub
    Public Function Cpy(ByVal r As DataRow, ByRef T As DataTable) As DataRow
        Dim x As DataRow
        x = T.NewRow
        x.ItemArray = r.ItemArray
        Return x
    End Function
    Public Sub SJFtable()
        table.Clear()
        table.Columns.Add("PID", GetType(String))
        table.Columns.Add("arival_Time", GetType(Integer))
        table.Columns.Add("Burst_Time", GetType(Integer))
    End Sub
    Public Function rowsNum(ByRef x As DataTable)
        Return x.Rows.Count
    End Function
    Public Function randomColor()
        Return Color.FromArgb(CInt(Int((254 * Rnd()) + 0)), CInt(Int((254 * Rnd()) + 0)), CInt(Int((254 * Rnd()) + 0)))
    End Function
    Public Sub sorting(ByVal ii As Integer)
        sortedT = table.Copy
        Dim ri, rj As DataRow
        Dim ati, atj As Integer
        If scheduler = 1 Then
            For i = 0 To rowsNum(sortedT) - 1
                ri = sortedT(i)
                ati = ri(1)
                For j = i + 1 To rowsNum(sortedT) - 1
                    rj = sortedT(j)
                    atj = rj(1)
                    If (ati > atj) Then
                        swapData(sortedT(i), sortedT(j))
                    End If
                Next
            Next
        ElseIf scheduler = 2 Or scheduler = 4 Then
            Dim time = 0
            Dim pri, prj As Integer
            For i = 0 To rowsNum(sortedT) - 1
                ri = sortedT(i)
                ati = ri(1)
                For j = i + 1 To rowsNum(sortedT) - 1
                    rj = sortedT(j)
                    atj = rj(1)
                    prj = rj(ii)
                    pri = ri(ii)
                    If (atj <= time) Then
                        If (pri > prj) Then
                            swapData(sortedT(i), sortedT(j))
                        End If
                    End If
                Next
                time += sortedT(i).Item(2)
            Next
        End If

    End Sub
    Public Sub gannt(ByVal xxx As Integer)
        Dim tot As Integer = 0
        For i = 0 To rowsNum(sortedT) - 1
            tot += sortedT(i).Item(2)
        Next
        trq = sortedT.Copy
        trq.Clear()

        rqueue = sortedT.Copy
        queue.Controls.Clear()
        Main.readyq.Controls.Add(queue)

        Dim ste As Double = 710 / tot
        progress.Controls.Clear()
        progress.AutoSize = True
        Dim ilbl As Label = labls()
        ilbl.Text = sortedT(0).Item(1).ToString
        ilbl.Location = New Point(0, 0)
        Main.Panel2.Controls.Add(ilbl)
        ilbl.Refresh()
        tot = 0
        Dim buf As Integer = 0
        Dim rin As Integer = 0
        Dim remo As Integer = 0
        For i = 0 To rowsNum(sortedT) - 1
            Dim ci As Integer = sortedT.Columns.Count - 1
            Dim cl As Color = sortedT(i).Item(ci)
            Dim lbl As Label = colredlbl(cl)
            progress.Controls.Add(lbl, i, 0)
            Main.Pgannt.Controls.Add(progress)
            If rqueue.Rows.Count > 0 Then
                rqueue(0).Delete()
            End If
            If trq.Rows.Count > 0 Then
                trq(0).Delete()
            End If
            If queue.Controls.Count > 0 Then
                queue.GetControlFromPosition(remo, 0).Dispose()
                queue.Refresh()
                remo += 1
            End If

            For x = 0 To (ste) * sortedT(i).Item(2)
                lbl.Width = x
                lbl.Refresh()
                If (i < rowsNum(sortedT) - 1) Then
                    Dim r = 0

                    While (r <= rqueue.Rows.Count - 1)
                        Dim c As Color = rqueue(r).Item(rqueue.Columns.Count - 1)
                        Dim rlbl As Label = colredlbl(c)
                        rlbl.Margin = New Padding(1)
                        rlbl.Width = 15
                        If (rqueue(r).Item(1) <= ((tot + x) / ste)) Then
                            If scheduler = 1 Then
                                queue.Controls.Add(rlbl, rin, 0)
                                rqueue(r).Delete()
                                rin += 1
                                queue.Refresh()
                            ElseIf scheduler = 2 Or scheduler = 4 Or scheduler = 5 Then
                                If trq.Rows.Count = 0 Then
                                    queue.Controls.Add(rlbl, rin, 0)
                                    trq.Rows.Add(Cpy(rqueue(r), trq))
                                    rqueue(r).Delete()
                                    rin += 1
                                    queue.Refresh()
                                Else
                                    Dim flag = 0
                                    'MessageBox.Show(trq(0).Item(0))
                                    For iq = 0 To (trq.Rows.Count - 1)
                                        If (rqueue(r).Item(xxx) < trq(iq).Item(xxx)) Then
                                            flag = 1
                                            trq.Rows.InsertAt(Cpy(rqueue(r), trq), iq)
                                            rqueue(r).Delete()
                                            queue.Controls.Clear()
                                            For h = 0 To trq.Rows.Count - 1
                                                rlbl = colredlbl(trq(h).Item(trq.Columns.Count - 1))
                                                rlbl.Width = 15
                                                rlbl.Margin = New Padding(1)
                                                queue.Controls.Add(rlbl, h, 0)
                                            Next
                                            rin += 1
                                            Exit For
                                        End If
                                    Next
                                    If (flag = 0) Then
                                        trq.Rows.Add(Cpy(rqueue(r), trq))
                                        rqueue(r).Delete()
                                        queue.Controls.Add(rlbl, rin, 0)
                                        rin += 1
                                    End If
                                End If
                                queue.Refresh()
                            End If

                        End If
                        r = r + 1
                    End While
                End If

                'Threading.Thread.Sleep(xxx)
            Next
            tot += lbl.Width - 2
            Dim ilbl2 As Label = labls()
            buf += sortedT(i).Item(2)
            ilbl2.Text = buf.ToString
            ilbl2.Location = New Point(tot, 0)
            Main.Panel2.Controls.Add(ilbl2)
            ilbl2.Refresh()
        Next

    End Sub
    Public Sub preeSorting(ByVal s As Integer)
        sortedT = table.Copy
        sortedT.Clear()
        Dim time = 0
        Dim i = 0
        Dim index = 0
        While (i < table.Rows.Count)
            Dim flag = 0
            For j = i + 1 To table.Rows.Count - 1
                Dim atj = table(j).Item(1)
                Dim prj = table(j).Item(s)
                Dim pri = table(i).Item(s)
                If (atj <= time) Then
                    If (pri > prj) Then
                        swapData(table(i), table(j))
                    End If
                End If
            Next
            sortedT.Rows.Add(Cpy(table(i), sortedT))
            index += 1
            Dim t = 0
            While (t < sortedT(index - 1).Item(2))
                If (i < table.Rows.Count - 1) Then
                    Dim j = i + 1
                    While (j < table.Rows.Count)
                        Dim atj = table(j).Item(1)
                        Dim prj = table(j).Item(s)
                        Dim pri = table(i).Item(s)
                        If (atj <= time) Then
                            If (pri > prj) Then
                                sortedT(index - 1).Item(2) = t
                                If (table(i).Item(2) - t <> 0) Then
                                    table(i).Item(2) = table(i).Item(2) - t
                                    table.Rows.Add(Cpy(table(i), table))
                                    flag = 1
                                Else
                                    flag = 1
                                    table(i).Delete()
                                    i -= 1
                                End If
                                Exit While
                            End If
                        End If
                        j += 1
                    End While
                End If
                If (flag = 1) Then
                    Exit While
                End If
                time += 1
                t += 1
            End While
            i += 1
        End While

    End Sub
    Public Function preeAvgw() As Double
        tmpT = sortedT.Copy
        Dim arr(sortedT.Rows.Count - 1), ti(sortedT.Rows.Count) As Double
        For ii = 0 To tmpT.Rows.Count
            If ii = 0 Then
                ti(ii) = 0
            Else
                ti(ii) = ti(ii - 1) + tmpT(ii - 1).Item(2)
            End If
        Next
        Dim i = 0
        Dim index = 0
        Dim tmp = 0
        While (i < tmpT.Rows.Count)
            Dim flag = 0
            Dim k = 0
            While (k < i)
                If (tmpT(i).Item(0) = tmpT(k).Item(0)) Then
                    flag = 1
                    Exit While
                End If
                k += 1
            End While
            If flag = 1 Then
                i += 1
                Continue While
            End If

            arr(index) = ti(i) - tmpT(i).Item(1)
            tmp = ti(i + 1)
            Dim j = i + 1
            While (j < tmpT.Rows.Count)
                If (tmpT(i).Item(0) = tmpT(j).Item(0)) Then
                    arr(index) += (ti(j) - tmp)
                    If (j < tmpT.Rows.Count - 1) Then
                        tmp = ti(j + 1)
                    End If

                End If
                j += 1
            End While
            index += 1
            i += 1
        End While
        Dim avg As Double = 0
        For x = 0 To index - 1
            avg += arr(x)
        Next
        Return avg / (index)
    End Function
    Public Sub RRS(ByVal q As Integer)
        sorting(1)
        Dim t = 0
        Dim p = 0
        While p < sortedT.Rows.Count
            If sortedT(p).Item(2) > q Then
                Dim flag = 0
                t += q
                For j = p + 1 To sortedT.Rows.Count - 1
                    If (sortedT(j).Item(1) > t) Then
                        flag = 1
                        sortedT.Rows.InsertAt((Cpy(sortedT(p), sortedT)), j)
                        sortedT(p).Item(2) = q
                        sortedT(j).Item(2) -= q
                        Exit For
                    End If
                Next
                If flag = 0 Then
                    sortedT.Rows.Add(Cpy(sortedT(p), sortedT))
                    sortedT(p).Item(2) = q
                    sortedT(sortedT.Rows.Count - 1).Item(2) -= q
                End If
            Else
                t += sortedT(p).Item(2)

            End If

            p += 1
        End While
    End Sub
End Module
