Imports System.Data.SqlClient
Public Class supervisiForm

    Dim CONN As SqlConnection
    Dim CMD As SqlCommand
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim RD As SqlDataReader
    Dim DT As DataTable
    Dim LokasiData As String
    Const nama_komputer = "DESKTOP-22R4LQE"
    Const nama_db = "db_multiUser"
    Dim nipLogin As String = SupervisorForm.TextBox2.Text

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Private Sub supervisiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Dim name As String = "select c.nama, c.email ,b.mapel, b.embed, b.rpp, b.catatan, b.status from tbl_jadwal as a 
left join tbl_dokumen as b on a.nip = b.nip
left join table_teachers as c on a.nip = c.nip
where a.nip='" & nipLogin & "' "
        CMD = New SqlCommand(name, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        namaText.Enabled = False
        namaText.Text = RD(0)
        nipText.Enabled = False
        nipText.Text = nipLogin
        emailText.Enabled = False
        emailText.Text = RD(1)
        mapelText.Enabled = False
        mapelText.Text = RD(2)
        linkText.Enabled = False
        linkText.Text = RD(3)
        rppText.Enabled = False
        rppText.Text = RD(4)
        catatanText.Text = RD(5)
        statusCmb.SelectedItem = RD(6)
        AxAcroPDF1.src = (rppText.Text)

    End Sub

    Sub clear()
        namaText.Text = ""
        nipText.Text = ""
        emailText.Text = ""
        mapelText.Text = ""
        linkText.Text = ""
        rppText.Text = ""
        catatanText.Text = ""
        statusCmb.Text = ""
        AxAcroPDF1.src = (rppText.Text)
    End Sub

    Private Sub kembaliBtn_Click(sender As Object, e As EventArgs) Handles kembaliBtn.Click
        SupervisorForm.Show()
        Me.Hide()
        Call clear()

    End Sub

    Sub supervisi()
        Call connection()
        Dim edit As String = "update tbl_dokumen set catatan='" & catatanText.Text & "', status='" & statusCmb.SelectedItem & "' from tbl_dokumen where nip='" & nipLogin & "'"
        CMD = New SqlCommand(edit, CONN)
        CMD.ExecuteNonQuery()

        MsgBox("berhasil mensupervisi")
    End Sub
    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click
        Call supervisi()

    End Sub
End Class