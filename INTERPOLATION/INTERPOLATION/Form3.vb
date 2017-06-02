Imports System.Windows.Forms.DataVisualization.Charting
Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Hide()
        Button1.Text = "Line graph"
        Chart1.Series.Clear()
        Dim num, i, a, b As Integer
        num = Form1.DataGridView1.RowCount
        num = num - 2
        i = 0
        Chart1.Titles.Add("Interpolation")
        Dim po As New Series
        po.ChartType = SeriesChartType.Area
        po.Name = "Interpolation Value"

        While (i <= num)
            a = Form1.DataGridView1.Rows(i).Cells(0).Value
            b = Form1.DataGridView1.Rows(i).Cells(1).Value
            po.Points.AddXY(a, b)
            i = i + 1
        End While
        Chart1.Series.Add(po)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Chart1.Series.Clear()
        Button2.Text = "Area graph"
        Dim num, i, a, b As Integer
        num = Form1.DataGridView1.RowCount
        num = num - 2
        i = 0

        Dim po As New Series
        po.ChartType = SeriesChartType.Pie






        po.Name = "Interpolation Value"

        While (i <= num)
            a = Form1.DataGridView1.Rows(i).Cells(0).Value
            b = Form1.DataGridView1.Rows(i).Cells(1).Value
            po.Points.AddXY(a, b)
            i = i + 1
        End While
        Chart1.Series.Add(po)
        Button1.Hide()
        Button2.Show()
    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Button2.Hide()
        Button1.Text = "pie graph"
        Chart1.Series.Clear()
        Dim num, i, a, b As Integer
        num = Form1.DataGridView1.RowCount
        num = num - 2
        i = 0

        Dim po As New Series
        po.ChartType = SeriesChartType.Area
        po.Name = "Interpolation Value"

        While (i <= num)
            a = Form1.DataGridView1.Rows(i).Cells(0).Value
            b = Form1.DataGridView1.Rows(i).Cells(1).Value
            po.Points.AddXY(a, b)
            i = i + 1
        End While
        Chart1.Series.Add(po)
        Button1.Show()
    End Sub
End Class