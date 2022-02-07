Imports System.Data.SqlClient

Public Class GuruForm

    Dim CONN As SqlConnection
    Dim CMD As SqlCommand
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim RD As SqlDataReader
    Dim DT As DataTable
    Dim LokasiData As String
    Const nama_komputer = "DESKTOP-22R4LQE"
    Const nama_db = "db_multiUser"
    Dim nameLogin As String = loginForm.nipText.Text

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Sub jadwal()
        Call connection()
        Dim query As String = "select a.tanggal, a.jam, b.nama as [nama supervisor], a.ruangan  from tbl_jadwal as a left join table_teachers as b on a.id_supervisor = b.id where a.nip='" & nameLogin & "'"
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub


    Private Sub GuruForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Dim name As String = "select nama from table_teachers where nip='" & nameLogin & "'"
        CMD = New SqlCommand(name, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        Call jadwal()

        TextBox1.Text = loginForm.nipText.Text
        TextBox1.Enabled = False
        TextBox2.Text = RD.Item("nama")
        TextBox2.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        uploadForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hasilSupervisi.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        loginForm.Show()
        Me.Hide()

    End Sub
End Class