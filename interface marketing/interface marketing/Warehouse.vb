Public Class Warehouse
    Dim OpenFileDialog1 As New OpenFileDialog
    Dim statusCari As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusCari = True
        koneksiDB()
        matilkanForm(TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6)
        tampilkanData("sekect * from Warehouse", DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nyalakanForm(TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6)
        clearForm(TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckEmpty(TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6) Then
            MsgBox("Data Belum Lengkap")
        Else
            If CheckDuplicate(TextBox1.Text) Then

            End If
        End If
    End Sub
End Class