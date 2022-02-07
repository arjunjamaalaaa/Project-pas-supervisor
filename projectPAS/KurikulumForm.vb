Imports System.Data.SqlClient

Public Class KurikulumForm

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
    Private Sub KurikulumForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Dim name As String = "select nama from table_teachers where nip='" & nameLogin & "'"
        CMD = New SqlCommand(name, CONN)
        RD = CMD.ExecuteReader
        RD.Read()


        nipKuri.Text = loginForm.nipText.Text
        nipKuri.Enabled = False
        namaText.Text = RD.Item("nama")
        namaText.Enabled = False
        Call docsAcc()
        Call accGuru()


    End Sub

    Sub accGuru()
        Call connection()
        Dim query As String = "select  c.nama, c.email ,b.mapel, b.embed, b.rpp, b.catatan, b.status from tbl_jadwal as a 
left join tbl_dokumen as b on a.nip = b.nip
left join table_teachers as c on a.nip = c.nip
where b.status = 'lulus'"
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        guruDone.DataSource = dt2
    End Sub


    Sub docsAcc()
        Call connection()
        Dim query As String = "select nip, mapel, rpp, embed from tbl_dokumen where status ='lulus'"
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        accDokumen.DataSource = dt2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        JadwalForm.Show()
        Me.Hide()
    End Sub

    Private Sub tambahGuru_Click(sender As Object, e As EventArgs) Handles tambahGuru.Click
        addGuruForm.Show()
        Me.Hide()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loginForm.Show()
        Me.Hide()

    End Sub
End Class