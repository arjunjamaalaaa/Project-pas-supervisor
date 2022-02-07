<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DokumenForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DokumenForm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nipText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.namaText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mapelText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rppText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.linkText = New System.Windows.Forms.TextBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.statText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.catatanText = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 258)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(505, 180)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dokumen Yang Sudah di upload"
        '
        'nipText
        '
        Me.nipText.Location = New System.Drawing.Point(150, 48)
        Me.nipText.Name = "nipText"
        Me.nipText.Size = New System.Drawing.Size(100, 20)
        Me.nipText.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NIP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama"
        '
        'namaText
        '
        Me.namaText.Location = New System.Drawing.Point(150, 98)
        Me.namaText.Name = "namaText"
        Me.namaText.Size = New System.Drawing.Size(100, 20)
        Me.namaText.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mata Pelajaran"
        '
        'mapelText
        '
        Me.mapelText.Location = New System.Drawing.Point(150, 152)
        Me.mapelText.Name = "mapelText"
        Me.mapelText.Size = New System.Drawing.Size(100, 20)
        Me.mapelText.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "RPP"
        '
        'rppText
        '
        Me.rppText.Location = New System.Drawing.Point(393, 48)
        Me.rppText.Multiline = True
        Me.rppText.Name = "rppText"
        Me.rppText.Size = New System.Drawing.Size(136, 66)
        Me.rppText.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Link Video"
        '
        'linkText
        '
        Me.linkText.Location = New System.Drawing.Point(393, 152)
        Me.linkText.Multiline = True
        Me.linkText.Name = "linkText"
        Me.linkText.Size = New System.Drawing.Size(136, 51)
        Me.linkText.TabIndex = 10
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(554, 258)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(286, 335)
        Me.AxAcroPDF1.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(150, 194)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(50, 20)
        Me.TextBox5.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(564, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Status"
        '
        'statText
        '
        Me.statText.Location = New System.Drawing.Point(628, 48)
        Me.statText.Multiline = True
        Me.statText.Name = "statText"
        Me.statText.Size = New System.Drawing.Size(136, 20)
        Me.statText.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(564, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Catatan"
        '
        'catatanText
        '
        Me.catatanText.Location = New System.Drawing.Point(628, 85)
        Me.catatanText.Multiline = True
        Me.catatanText.Name = "catatanText"
        Me.catatanText.Size = New System.Drawing.Size(204, 129)
        Me.catatanText.TabIndex = 16
        '
        'DokumenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 605)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.catatanText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.statText)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.linkText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rppText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mapelText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.namaText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nipText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DokumenForm"
        Me.Text = "DokumenForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents nipText As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents namaText As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents mapelText As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents rppText As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents linkText As Windows.Forms.TextBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox5 As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents statText As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents catatanText As Windows.Forms.TextBox
End Class
