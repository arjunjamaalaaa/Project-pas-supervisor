<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supervisiForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supervisiForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namaText = New System.Windows.Forms.TextBox()
        Me.nipText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.emailText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mapelText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.linkText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rppText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.statusCmb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.catatanText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.kembaliBtn = New System.Windows.Forms.Button()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'namaText
        '
        Me.namaText.Location = New System.Drawing.Point(108, 35)
        Me.namaText.Name = "namaText"
        Me.namaText.Size = New System.Drawing.Size(100, 20)
        Me.namaText.TabIndex = 1
        '
        'nipText
        '
        Me.nipText.Location = New System.Drawing.Point(108, 83)
        Me.nipText.Name = "nipText"
        Me.nipText.Size = New System.Drawing.Size(100, 20)
        Me.nipText.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIP"
        '
        'emailText
        '
        Me.emailText.Location = New System.Drawing.Point(108, 125)
        Me.emailText.Name = "emailText"
        Me.emailText.Size = New System.Drawing.Size(100, 20)
        Me.emailText.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'mapelText
        '
        Me.mapelText.Location = New System.Drawing.Point(108, 171)
        Me.mapelText.Name = "mapelText"
        Me.mapelText.Size = New System.Drawing.Size(100, 20)
        Me.mapelText.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mapel"
        '
        'linkText
        '
        Me.linkText.Location = New System.Drawing.Point(108, 330)
        Me.linkText.Name = "linkText"
        Me.linkText.Size = New System.Drawing.Size(331, 20)
        Me.linkText.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Link"
        '
        'rppText
        '
        Me.rppText.Location = New System.Drawing.Point(291, 35)
        Me.rppText.Multiline = True
        Me.rppText.Name = "rppText"
        Me.rppText.Size = New System.Drawing.Size(148, 156)
        Me.rppText.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "RPP"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(480, 35)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(293, 274)
        Me.AxAcroPDF1.TabIndex = 12
        '
        'statusCmb
        '
        Me.statusCmb.FormattingEnabled = True
        Me.statusCmb.Items.AddRange(New Object() {"belum lulus", "lulus", "dalam proses"})
        Me.statusCmb.Location = New System.Drawing.Point(108, 371)
        Me.statusCmb.Name = "statusCmb"
        Me.statusCmb.Size = New System.Drawing.Size(100, 21)
        Me.statusCmb.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Status"
        '
        'catatanText
        '
        Me.catatanText.Location = New System.Drawing.Point(108, 205)
        Me.catatanText.Multiline = True
        Me.catatanText.Name = "catatanText"
        Me.catatanText.Size = New System.Drawing.Size(331, 104)
        Me.catatanText.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Catatan"
        '
        'uploadBtn
        '
        Me.uploadBtn.Location = New System.Drawing.Point(480, 390)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(75, 23)
        Me.uploadBtn.TabIndex = 17
        Me.uploadBtn.Text = "Upload"
        Me.uploadBtn.UseVisualStyleBackColor = True
        '
        'kembaliBtn
        '
        Me.kembaliBtn.Location = New System.Drawing.Point(588, 390)
        Me.kembaliBtn.Name = "kembaliBtn"
        Me.kembaliBtn.Size = New System.Drawing.Size(75, 23)
        Me.kembaliBtn.TabIndex = 18
        Me.kembaliBtn.Text = "Kembali"
        Me.kembaliBtn.UseVisualStyleBackColor = True
        '
        'supervisiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.kembaliBtn)
        Me.Controls.Add(Me.uploadBtn)
        Me.Controls.Add(Me.catatanText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.statusCmb)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.rppText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.linkText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mapelText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.emailText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nipText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.namaText)
        Me.Controls.Add(Me.Label1)
        Me.Name = "supervisiForm"
        Me.Text = "supervisiForm"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents namaText As Windows.Forms.TextBox
    Friend WithEvents nipText As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents emailText As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents mapelText As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents linkText As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents rppText As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents statusCmb As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents catatanText As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents uploadBtn As Windows.Forms.Button
    Friend WithEvents kembaliBtn As Windows.Forms.Button
End Class
