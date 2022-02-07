Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DokumenForm

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

    Sub data()
        Call connection()
        Dim name As String = "select b.id as [ID], b.nama as [Nama Guru], a.nip as [NIP], a.mapel as [Mata Pelajaran], a.rpp as [RPP], a.embed as [Link Video], a.status as [Status Supervisi], a.catatan as [Catatan Supervisor]  
from tbl_dokumen as a left join table_teachers as b on a.nip = b.nip 
where b.id='" & TextBox5.Text & "' "
        CMD = New SqlCommand(name, CONN)
        RD = CMD.ExecuteReader
        RD.Read()
    End Sub
    Private Sub DokumenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        rppText.Enabled = False
        linkText.Enabled = False
        namaText.Enabled = False
        mapelText.Enabled = False
        nipText.Enabled = False
        statText.Enabled = False
        catatanText.Enabled = False
        TextBox5.Visible = False


        Call accGuru()

    End Sub

    Sub accGuru()
        Call connection()
        Dim query As String = "select b.id as [ID], b.nama as [Nama Guru], a.nip as [NIP], a.mapel as [Mata Pelajaran], a.rpp as [RPP], a.embed as [Link Video], a.status as [Status Supervisi], a.catatan as [Catatan Supervisor]  from tbl_dokumen as a left join table_teachers as b on a.nip = b.nip "
        Dim cmd4 = New SqlCommand(query, CONN)
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = cmd4
        Dim dt2 = New DataTable
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub

    Sub isiForm()
        nipText.Text = RD(2)
        namaText.Text = RD(1)
        mapelText.Text = RD(3)
        rppText.Text = RD(4)
        linkText.Text = RD(5)
        statText.Text = RD(6)
        catatanText.Text = RD(7)
        AxAcroPDF1.src = (rppText.Text)


    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Call data()
        If RD.HasRows Then
            Call isiForm()
        Else

        End If
    End Sub
End Class