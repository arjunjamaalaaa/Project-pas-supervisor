<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KurikulumForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nipKuri = New System.Windows.Forms.TextBox()
        Me.namaText = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tambahGuru = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.accDokumen = New System.Windows.Forms.DataGridView()
        Me.guruDone = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.accDokumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guruDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "nip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nama"
        '
        'nipKuri
        '
        Me.nipKuri.Location = New System.Drawing.Point(145, 43)
        Me.nipKuri.Name = "nipKuri"
        Me.nipKuri.Size = New System.Drawing.Size(100, 20)
        Me.nipKuri.TabIndex = 2
        '
        'namaText
        '
        Me.namaText.Location = New System.Drawing.Point(145, 85)
        Me.namaText.Name = "namaText"
        Me.namaText.Size = New System.Drawing.Size(100, 20)
        Me.namaText.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(620, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Tambah Jadwal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tambahGuru
        '
        Me.tambahGuru.Location = New System.Drawing.Point(620, 22)
        Me.tambahGuru.Name = "tambahGuru"
        Me.tambahGuru.Size = New System.Drawing.Size(199, 23)
        Me.tambahGuru.TabIndex = 5
        Me.tambahGuru.Text = "Tambah Guru"
        Me.tambahGuru.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dokumen yang sudah di acc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Guru sudah supervisi"
        '
        'accDokumen
        '
        Me.accDokumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.accDokumen.Location = New System.Drawing.Point(46, 190)
        Me.accDokumen.Name = "accDokumen"
        Me.accDokumen.Size = New System.Drawing.Size(375, 214)
        Me.accDokumen.TabIndex = 8
        '
        'guruDone
        '
        Me.guruDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.guruDone.Location = New System.Drawing.Point(453, 190)
        Me.guruDone.Name = "guruDone"
        Me.guruDone.Size = New System.Drawing.Size(394, 214)
        Me.guruDone.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(620, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'KurikulumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.guruDone)
        Me.Controls.Add(Me.accDokumen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tambahGuru)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.namaText)
        Me.Controls.Add(Me.nipKuri)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KurikulumForm"
        Me.Text = "KurikulumForm"
        CType(Me.accDokumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guruDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents nipKuri As Windows.Forms.TextBox
    Friend WithEvents namaText As Windows.Forms.TextBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents tambahGuru As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents accDokumen As Windows.Forms.DataGridView
    Friend WithEvents guruDone As Windows.Forms.DataGridView
    Friend WithEvents Button2 As Windows.Forms.Button
End Class
