Imports System.Data.SqlClient

Public Class JadwalForm

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

    Sub munculNip()
        Call connection()
        ComboBox1.Items.Clear()
        CMD = New SqlCommand("select * from table_teachers", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(1))
        Loop
    End Sub

    Sub munculId()
        Call connection()
        ComboBox2.Items.Clear()
        Dim cmd2 = New SqlCommand("select * from table_teachers where supervisor='yes'", CONN)
        Dim rd2 = cmd2.ExecuteReader
        Do While rd2.Read
            ComboBox2.Items.Add(rd2.Item(0))
        Loop


    End Sub

    Sub munculData()

        Call connection()
        Dim query As String = "select * from tbl_jadwal"
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView1.DataSource = dt2




    End Sub


    Sub clear()
        waktu.Text = ""
        selesai.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Sub inputJadwal()
        Call connection()
        Dim insert As String = "insert into tbl_jadwal values('" & tanggal1.Value.ToString("dd/mm/yyyy") & "','" & waktu.Text & "' + '-' + '" & selesai.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "', '" & ComboBox3.SelectedItem & "')"
        Dim cmd3 = New SqlCommand(insert, CONN)
        cmd3.ExecuteNonQuery()





        'Dim cmd3 = New SqlCommand("select id from table_teachers where name='" & ComboBox2.SelectedItem & "'", CONN)
        'Dim rd3 = cmd3.ExecuteReader
        'rd3.Read()



    End Sub

    Private Sub JadwalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call munculNip()
        Call munculId()
        Call munculData()


        'Dim queryStringSelect As String = "select id, nama from table_teachers where nama='" & ComboBox2.SelectedItem & "'"
        'Dim cmd4 = New SqlCommand(queryStringSelect, CONN)
        'Dim rd4 = cmd4.ExecuteReader
        'rd4.Read()

        'ComboBox2.Items.Add("'" & rd4.Item("id") & "'" + " - " + "'" & rd4.Item("nama") & "'")

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call inputJadwal()
        Call clear()
        Call munculData()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call connection()
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim CMDD As New SqlCommand("delete from tbl_jadwal where id = @id", CONN)
            CMDD.Parameters.AddWithValue("id", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            CMDD.ExecuteNonQuery()
        Next
        Call munculData()
        MsgBox("data berhasil dihapus")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KurikulumForm.Show()
        Me.Hide()

    End Sub

End Class