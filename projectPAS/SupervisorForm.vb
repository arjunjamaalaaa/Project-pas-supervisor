Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class SupervisorForm
    Dim CONN As SqlConnection
    Dim CMD As SqlCommand
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim RD As SqlDataReader
    Dim DT As DataTable
    Dim LokasiData As String
    Const nama_komputer = "DESKTOP-22R4LQE"
    Const nama_db = "db_multiUser"
    Dim nipLogin As String = loginForm.nipText.Text

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Private Sub SupervisorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Dim name As String = "select * from table_teachers where nip='" & nipLogin & "'"
        CMD = New SqlCommand(name, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        nipText.Text = nipLogin
        nipText.Enabled = False
        TextBox1.Visible = False
        TextBox1.Text = RD(0)
        namaText.Text = RD(2)
        namaText.Enabled = False
        'TextBox2.Visible = False
        TextBox2.Enabled = False
        TextBox2.Visible = False



        Call jadwal()

    End Sub
    Sub clear()
        nipText.Text = ""
        namaText.Text = ""
    End Sub

    Sub jadwal()
        Call connection()
        Dim query As String = "select a.tanggal, a.jam, a.nip , b.nama as [nama guru], a.ruangan from tbl_jadwal as a left join table_teachers as b on a.nip = b.nip where a.id_supervisor='" & TextBox1.Text & "' "
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginForm.Show()
        Call clear()

        Me.Hide()

    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        supervisiForm.Show()
        Me.Hide()

    End Sub
End Class