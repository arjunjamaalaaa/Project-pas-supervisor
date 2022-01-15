Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class addGuruForm

    Dim CONN As SqlConnection
    Dim CMD As SqlCommand
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim RD As SqlDataReader
    Dim DT As DataTable
    Dim LokasiData As String
    Const nama_komputer = "DESKTOP-22R4LQE"
    Const nama_db = "db_multiUser"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call inputData()
        Call munculData()


    End Sub

    Sub munculData()

        Call connection()
        Dim query As String = "select * from table_teachers"
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView1.DataSource = dt2




    End Sub
    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Private Sub addGuruForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call munculData()
        ComboBox3.Visible = False
        idText.Hide()



    End Sub

    Sub data()
        Call connection()
        Dim cari As String = "select * from table_teachers where id='" & idText.Text & "'"
        CMD = New SqlCommand(cari, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

    End Sub

    Sub clear()
        ComboBox3.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub


    Sub inputData()
        Call connection()
        Dim insert As String = "insert into table_teachers values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "','' ,'" & TextBox1.Text & "')"
        Dim cmd3 = New SqlCommand(insert, CONN)
        cmd3.ExecuteNonQuery()
        Call munculData()
        Call clear()



    End Sub

    Sub isiForm()
        ComboBox3.Visible = True
        TextBox1.Text = RD(1)
        TextBox2.Text = RD(2)
        TextBox3.Text = RD(3)
        TextBox4.Text = RD(4)
        ComboBox1.SelectedItem = RD(5)
        ComboBox2.SelectedItem = RD(6)
        ComboBox3.SelectedItem = RD(7)

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        idText.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Call data()
        If RD.HasRows Then
            Call isiForm()
        Else

        End If
    End Sub

    Sub edit()
        Call connection()
        Dim edit As String = "update table_teachers set nip='" & TextBox1.Text & "', nama='" & TextBox2.Text & "', alamat='" & TextBox3.Text & "', jabatan1='" & ComboBox1.SelectedItem & "', jabatan2='" & ComboBox2.SelectedItem & "', supervisor='" & ComboBox3.SelectedItem.ToString & "', password='" & TextBox1.Text & "' where id = '" & idText.Text & "'"
        Dim comand = New SqlCommand(edit, CONN)
        comand.ExecuteNonQuery()
        Call clear()
        ComboBox3.Visible = False
        Call munculData()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call edit()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        KurikulumForm.Show()
        Me.Hide()

    End Sub

    Sub hapus()
        Call connection()
        Dim hapus As String = "delete table_teachers where id='" & idText.Text & "'"
        Dim cmdHapus = New SqlCommand(hapus, CONN)
        cmdHapus.ExecuteNonQuery()
        Call munculData()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call hapus()
        Call clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call clear()

    End Sub
End Class