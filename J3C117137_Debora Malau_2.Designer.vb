<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rata = New System.Windows.Forms.Label()
        Me.hadiah = New System.Windows.Forms.Label()
        Me.hitung = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.nilai1 = New System.Windows.Forms.TextBox()
        Me.nilai2 = New System.Windows.Forms.TextBox()
        Me.nilai3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rataan:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Hadiah:"
        '
        'rata
        '
        Me.rata.AutoSize = True
        Me.rata.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rata.Location = New System.Drawing.Point(139, 243)
        Me.rata.Name = "rata"
        Me.rata.Size = New System.Drawing.Size(180, 24)
        Me.rata.TabIndex = 6
        Me.rata.Text = ".................................."
        '
        'hadiah
        '
        Me.hadiah.AutoSize = True
        Me.hadiah.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hadiah.Location = New System.Drawing.Point(139, 283)
        Me.hadiah.Name = "hadiah"
        Me.hadiah.Size = New System.Drawing.Size(180, 24)
        Me.hadiah.TabIndex = 7
        Me.hadiah.Text = ".................................."
        '
        'hitung
        '
        Me.hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitung.Location = New System.Drawing.Point(46, 368)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(112, 42)
        Me.hitung.TabIndex = 9
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(197, 368)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(121, 42)
        Me.clear.TabIndex = 10
        Me.clear.Text = "Keluar"
        Me.clear.UseVisualStyleBackColor = True
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(143, 65)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(143, 29)
        Me.nama.TabIndex = 11
        '
        'nilai1
        '
        Me.nilai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nilai1.Location = New System.Drawing.Point(143, 101)
        Me.nilai1.Name = "nilai1"
        Me.nilai1.Size = New System.Drawing.Size(143, 29)
        Me.nilai1.TabIndex = 12
        '
        'nilai2
        '
        Me.nilai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nilai2.Location = New System.Drawing.Point(143, 140)
        Me.nilai2.Name = "nilai2"
        Me.nilai2.Size = New System.Drawing.Size(143, 29)
        Me.nilai2.TabIndex = 13
        '
        'nilai3
        '
        Me.nilai3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nilai3.Location = New System.Drawing.Point(143, 182)
        Me.nilai3.Name = "nilai3"
        Me.nilai3.Size = New System.Drawing.Size(143, 29)
        Me.nilai3.TabIndex = 14
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 502)
        Me.Controls.Add(Me.nilai3)
        Me.Controls.Add(Me.nilai2)
        Me.Controls.Add(Me.nilai1)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.hadiah)
        Me.Controls.Add(Me.rata)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rata As System.Windows.Forms.Label
    Friend WithEvents hadiah As System.Windows.Forms.Label
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents nilai1 As System.Windows.Forms.TextBox
    Friend WithEvents nilai2 As System.Windows.Forms.TextBox
    Friend WithEvents nilai3 As System.Windows.Forms.TextBox
End Class
