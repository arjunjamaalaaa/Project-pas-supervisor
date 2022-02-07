Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class uploadForm

    Dim CONN As SqlConnection
    Dim CMD As SqlCommand
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim RD As SqlDataReader
    Dim DT As DataTable
    Dim LokasiData As String
    Const nama_komputer = "DESKTOP-22R4LQE"
    Const nama_db = "db_multiUser"
    Dim nipLogin As String = GuruForm.TextBox1.Text

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Sub cariData()
        Call connection()
        Dim cari As String = "select * from tbl_dokumen where id='" & TextBox4.Text & "'"
        CMD = New SqlCommand(cari, CONN)
        RD = CMD.ExecuteReader
        RD.Read()
    End Sub
    Private Sub uploadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox4.Visible = False
        TextBox3.Text = nipLogin
        TextBox3.Enabled = False
        TextBox2.Enabled = False
        Call munculData()
        Call clear()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox2.Text = OpenFileDialog1.FileName
        AxAcroPDF1.src = (TextBox2.Text)
    End Sub

    Sub clear()
        mapelText.Clear()
        TextBox2.Clear()
        TextBox1.Clear()
        AxAcroPDF1.src = (TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call connection()
        Dim input As String = "insert into tbl_dokumen values('" & nipLogin & "', '" & mapelText.Text & "', '" & TextBox2.Text & "','" & TextBox1.Text & "','menunggu supervisi','dalam proses')"
        Dim inputCMD = New SqlCommand(input, CONN)
        inputCMD.ExecuteNonQuery()
        Call munculData()
        Call clear()


    End Sub

    Sub munculData()
        Call connection()
        Dim query As String = "select id,nip,mapel,rpp,embed  from tbl_dokumen"
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GuruForm.Show()
        Me.Hide()

    End Sub
    Sub hapus()
        Call connection()
        Dim hapus As String = "delete tbl_dokumen where id='" & TextBox4.Text & "'"
        Dim cmdHapus = New SqlCommand(hapus, CONN)
        cmdHapus.ExecuteNonQuery()
        Call clear()
        Call munculData()


    End Sub
    Sub ketemu()
        mapelText.Text = RD(2)
        TextBox1.Text = RD(4)
        TextBox2.Text = RD(3)
        AxAcroPDF1.src = (TextBox2.Text)
    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Call cariData()
        If RD.HasRows Then
            Call ketemu()
        Else
            MsgBox("error")
        End If
    End Sub

    Sub edit()
        Call connection()
        Dim edit As String = "update tbl_dokumen set mapel='" & mapelText.Text & "', rpp='" & TextBox2.Text & "', embed='" & TextBox1.Text & "' where id = '" & TextBox4.Text & "'"
        Dim comand = New SqlCommand(edit, CONN)
        comand.ExecuteNonQuery()
        Call clear()
        Call munculData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call edit()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call hapus()

    End Sub

End Class