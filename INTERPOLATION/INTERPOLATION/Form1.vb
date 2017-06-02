Public Class Form1
   
    Function inter(ByVal y() As Double, ByVal num As Double) As Integer
        Dim i, j, k As Integer
        Dim first(1000), t1, t2, last(1000) As Double
        i = 0
        j = 1
        k = 0
        last(k) = y(num)
        While (j < num + 1)
            While (i < num)
                t1 = DataGridView1.Rows(i - k).Cells(j).Value
                t2 = DataGridView1.Rows(i + 1 - k).Cells(j).Value
                DataGridView1.Rows(i - k).Cells(j + 1).Value = t2 - t1
                last(j) = DataGridView1.Rows(i - k).Cells(j + 1).Value
                i = i + 1
            End While

            i = j
            j = j + 1
            k = k + 1
        End While
        i = 1
        While (i <= num + 1)
            first(i - 1) = DataGridView1.Rows(0).Cells(i).Value
            i = i + 1
        End While
        calculate(last, first, num)
        Return 0
    End Function
    Function calculate(ByVal last() As Double, ByVal first() As Double, ByVal number As Double) As Integer
        Dim a, b, c, e, r, val(1000), xo As Double
        Dim h, n, x, ans, temp, re, fa As Double
        a = last(0)

        b = first(0)
        c = (a + b) / 2

        If (Not (TextBox1.Text = vbNullString)) Then
            a = TextBox1.Text
        Else
            MsgBox("value to be interpolated left blank")
            Return 0
        End If
        If (((a < c) And (ComboBox1.SelectedIndex = 0)) Or (ComboBox1.SelectedIndex = 1)) Then

            val = first
            xo = DataGridView1.Rows(0).Cells(0).Value

            x = a

            e = DataGridView1.Rows(1).Cells(0).Value
            r = DataGridView1.Rows(0).Cells(0).Value
            h = e - r
            Label2.Text = "h=" & h
            n = (x - xo) / h
            Label3.Text = "n=" & n

            b = 0
            ans = 0
            temp = 1
            fa = 1
            re = 1
            While (b <= number)

                temp = val(b) * re
                temp = temp / fa
                ans = ans + temp


                re = re * (n - b)
                b = b + 1
                If (b > 1) Then
                    fa = fa * b


                End If
            End While
        ElseIf (((a >= c) And (ComboBox1.SelectedIndex = 0)) Or (ComboBox1.SelectedIndex = 2)) Then
            val = last

            xo = DataGridView1.Rows(number).Cells(0).Value

            x = a

            e = DataGridView1.Rows(1).Cells(0).Value
            r = DataGridView1.Rows(0).Cells(0).Value
            h = e - r
            Label2.Text = "h=" & h
            n = (x - xo) / h
            Label3.Text = "n=" & n

            b = 0
            ans = 0
            temp = 1
            fa = 1
            re = 1
            While (b <= number)
                temp = val(b) * re
                temp = temp / fa

                ans = ans + temp


                re = re * (n + b)
                b = b + 1
                If (b > 1) Then
                    fa = fa * b

                End If
            End While
        End If





        Label4.Text = "f(" & a & ")" & " ans=" & ans
        Form3.Show()
        Return 0
    End Function
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("AUTOMATIC")
        ComboBox1.Items.Add("FORWARD")
        ComboBox1.Items.Add("BACKWARD")
        ComboBox1.SelectedIndex = 0
        DataGridView1.Columns.Add("x", "x")
        DataGridView1.Columns.Add("y", "y")
        DataGridView1.RowCount = 1
        DataGridView1.RowCount = 1

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x(100), y(100), num, num2 As Double

        Dim S As String
       

        num2 = DataGridView1.RowCount

        num = 0
        Try
            While (num < num2)

                x(num) = DataGridView1.Rows(num).Cells(0).Value
                y(num) = DataGridView1.Rows(num).Cells(1).Value
                num = num + 1
            End While
      
        num = num - 2
        num2 = 0
        While (num2 < num)
            DataGridView1.Columns.Add("D" & num2, "D" & num2)
            num2 = num2 + 1
        End While

        inter(y, num)
        Catch r As Exception
            MsgBox("non numeric value found:" + r.Message)
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim n As New Form1
        Application.Restart()









    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
