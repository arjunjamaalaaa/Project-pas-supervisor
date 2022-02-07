Imports System.Data.SqlClient
Public Class KepsekForm
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
    Private Sub KepsekForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Dim name As String = "select nama from table_teachers where nip='" & nameLogin & "'"
        CMD = New SqlCommand(name, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox1.Text = nameLogin
        TextBox2.Text = RD.Item("nama")
        Call accGuru()


    End Sub

    Sub accGuru()
        Call connection()
        Dim query As String = "select  c.nip as [NIP], c.nama as [Nama Guru], c.email as [Email], c.alamat as [Alamat] ,b.mapel as [Mata Pelajaran], b.status as [Status Supervisi], b.catatan as [Catatan Supervisor] from tbl_jadwal as a 
left join tbl_dokumen as b on a.nip = b.nip
left join table_teachers as c on a.nip = c.nip
where b.status = 'lulus'"
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView2.DataSource = dt2
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DokumenForm.Show()
        Me.Hide()

    End Sub
End Class