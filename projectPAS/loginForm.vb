Imports System.Data.SqlClient

Public Class loginForm

    'Dim con As SqlConnection
    'Dim cmd As SqlCommand
    'Dim sda As SqlDataAdapter
    'Dim dt As DataTable
    'Dim rd As SqlDataReader

    Dim CONN As SqlConnection
    Dim CMD As SqlCommand
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim RD As SqlDataReader
    Dim DT As DataTable
    Dim LokasiData As String
    Const nama_komputer = "DESKTOP-22R4LQE"
    Const nama_db = "db_multiUser"

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    'Sub connection()
    '    Dim conn As String = "Data Source=DESKTOP-22R4LQE;Initial Catalog=db_multiUser;Integrated Security=True"

    'End Sub
    Sub Login()

        Call connection()
        Dim logic1 As String = "select * from table_teachers where nip='" & nipText.Text & "' and password='" & passText.Text & "' and (jabatan1='" & cmbMulti.SelectedItem & "' or jabatan2='" & cmbMulti.SelectedItem & "')"
        CMD = New SqlCommand(logic1, CONN)
        DA = New SqlDataAdapter(CMD)
        DT = New DataTable
        DA.Fill(DT)

        'LOGIC 2'
        Dim logic2 As String = "select * from table_teachers where nip='" & nipText.Text & "' and password='" & passText.Text & "' and (jabatan1='kurikulum' or jabatan2='kurikulum') and supervisor='yes'"
        Dim cmd2 = New SqlCommand(logic2, CONN)
        Dim da2 = New SqlDataAdapter(cmd2)
        Dim dt2 = New DataTable
        da2.Fill(dt2)

        'Logic 3'
        Dim logic3 As String = "select * from table_teachers where nip='" & nipText.Text & "' and password='" & passText.Text & "' and (jabatan1='" & cmbMulti.SelectedItem & "' or jabatan2='" & cmbMulti.SelectedItem & "') and supervisor='yes'"
        Dim cmd3 = New SqlCommand(logic3, CONN)
        Dim da3 = New SqlDataAdapter(cmd3)
        Dim dt3 = New DataTable
        da3.Fill(dt3)

        If nipText.Text = "" Or passText.Text = "" Or cmbMulti.SelectedItem = "" Then
            MsgBox("Data tidak boleh kosong")

        ElseIf (DT.Rows.Count > 0 And cmbMulti.SelectedItem = "guru/laboran") Then
            GuruForm.Show()
            Me.Hide()
            MsgBox("anda login sebagai " + cmbMulti.SelectedItem)

        ElseIf (DT.Rows.Count > 0 And cmbMulti.SelectedItem = "kurikulum") Then
            KurikulumForm.Show()
            Me.Hide()
            MsgBox("anda login sebagai " + cmbMulti.SelectedItem)
        ElseIf (DT.Rows.Count > 0 And cmbMulti.SelectedItem = "kepala sekolah") Then
            SupervisorForm.Show()
            Me.Hide()
            MsgBox("anda login sebagai " + cmbMulti.SelectedItem)
        Else
            MsgBox("anda tidak memiliki role tersebut")
            nipText.Text = ""
            passText.Text = ""
            cmbMulti.Text = ""
        End If


    End Sub

    Sub clear()
        nipText.Text = ""
        passText.Text = ""
        cmbMulti.Text = ""
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Call connection()
        Call Login()
        Call clear()



    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class