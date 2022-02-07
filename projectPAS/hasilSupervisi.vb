Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class hasilSupervisi
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

    Sub munculData()
        Call connection()
        Dim query As String = "select id as ID,nip as NIP,mapel as [Mata Pelajaran],status as Status from tbl_dokumen where nip='" & nipLogin & "'"
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub hasilSupervisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        munculData()
        idText.Visible = False
        TextBox1.Enabled = False


    End Sub

    Sub cariData()
        Call connection()
        Dim cari As String = "select * from tbl_dokumen where id='" & TextBox1.Text & "'"
        CMD = New SqlCommand(cari, CONN)
        RD = CMD.ExecuteReader
        RD.Read()
    End Sub

    Sub ketemu()
        TextBox1.Text = RD(5)
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Call cariData()
        If RD.HasRows Then
            Call ketemu()
        Else
            MsgBox("Id tidak ditemukan")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GuruForm.Show()
        Me.Hide()
        TextBox1.Text = ""

    End Sub


End Class