Imports System.Data.OleDb

Public Class Dash
    Dim connectionstring As String
    Dim cnn As OleDbConnection


    Private Property adapter As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True






    End Sub


    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True

    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
        Panel6.Visible = False
        GunaButton7.Visible = False
        GunaButton3.Visible = False
        GunaButton4.Visible = False
        GunaButton5.Visible = False
        GunaButton6.Visible = False
        GunaButton9.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        Panel5.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
       
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        GunaButton3.Visible = True
        GunaButton4.Visible = True
        GunaButton5.Visible = True
        GunaButton6.Visible = True
        GunaButton9.Visible = False
        GunaButton7.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Panel1.Visible = True
        Panel6.Visible = True
        Panel5.Visible = False



    End Sub

    Private Sub Dash_Load(sender As Object, e As EventArgs)
       


    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        warning.Show()


    End Sub

    Private Sub Dash_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
      
        connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\VS studio\VS 2012\Pizza Mania new\Pizza Mania new\Pizza_Mania.accdb"
        cnn = New OleDbConnection
        cnn.ConnectionString = connectionstring
        cnn.Open()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Dim oledb As OleDbDataAdapter
        Dim sqlstring As String
        Dim ds As New DataSet
        Dim cmd As OleDbCommand
        Dim Inputvalue As String
        If CheckBox1.Checked = True Then
            sqlstring = "select * from veg_pizza where p_id=1001"
            oledb = New OleDbDataAdapter()
            oledb.SelectCommand = New OleDbCommand(sqlstring, cnn)
            oledb.Fill(ds)
            GunaDataGridView1.Rows(0).Cells(0).Value = ds.Tables(0).Rows(0).Item(1)
            GunaDataGridView1.Rows(0).Cells(1).Value = InputBox("Please Insert Quantity:", "Inputvalue")
            GunaDataGridView1.Rows(0).Cells(2).Value = ds.Tables(0).Rows(0).Item(2) * GunaDataGridView1.Rows(0).Cells(1).Value
        Else
            GunaDataGridView1.Rows(0).Cells(0).Value = ""
            GunaDataGridView1.Rows(0).Cells(1).Value = ""
            GunaDataGridView1.Rows(0).Cells(2).Value = ""

        End If

        
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        Dim oledb As OleDbDataAdapter
        Dim sqlstr As String
        Dim ds As New DataSet
        Dim row As New DataGridViewRow
        Dim cmd As OleDbCommand
        Dim i As Integer
        If CheckBox2.Checked = True Then
            row.CreateCells(GunaDataGridView1)
            sqlstr = "select * from veg_pizza where p_id=1002"
            oledb = New OleDbDataAdapter()
            oledb.SelectCommand = New OleDbCommand(sqlstr, cnn)
            oledb.Fill(ds)
            GunaDataGridView1.Rows.Add(1)

            i = GunaDataGridView1.Rows.Count - 1

            GunaDataGridView1.Rows(i).Cells(1).Value = InputBox("Please Insert Quantity:", "Input value")
            If GunaDataGridView1.Rows(i).Cells(1).Value <> "" Then
                GunaDataGridView1.Rows(i).Cells(0).Value = ds.Tables(0).Rows(0).Item(1)
                GunaDataGridView1.Rows(i).Cells(2).Value = ds.Tables(0).Rows(0).Item(2) * GunaDataGridView1.Rows(i).Cells(1).Value
            End If


        Else
            i = GunaDataGridView1.Rows.Count - 1
            GunaDataGridView1.Rows(i).Cells(0).Value = ""
            GunaDataGridView1.Rows(i).Cells(1).Value = ""
            GunaDataGridView1.Rows(i).Cells(2).Value = ""
            GunaDataGridView1.Rows.RemoveAt(i)
        End If

    End Sub

    Private Sub GunaButton11_Click(sender As Object, e As EventArgs) Handles GunaButton11.Click
        If CheckBox31.Checked = True Then
            QR.Show()
            Me.Enabled = False


        End If
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaButton13_Click(sender As Object, e As EventArgs) Handles GunaButton13.Click
        GunaDataGridView1.Rows.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False

    End Sub
End Class