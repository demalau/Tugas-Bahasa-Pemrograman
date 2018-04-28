<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.bobot = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.hitung = New System.Windows.Forms.Button()
        Me.bersih = New System.Windows.Forms.Button()
        Me.txtntukel = New System.Windows.Forms.TextBox()
        Me.txtbtubes = New System.Windows.Forms.TextBox()
        Me.txtbtukel = New System.Windows.Forms.TextBox()
        Me.txtnuas = New System.Windows.Forms.TextBox()
        Me.txtnuts = New System.Windows.Forms.TextBox()
        Me.txtntubes = New System.Windows.Forms.TextBox()
        Me.txtbuts = New System.Windows.Forms.TextBox()
        Me.txtbuas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menghitung Huruf Mutu Mata Kuliah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai"
        '
        'bobot
        '
        Me.bobot.AutoSize = True
        Me.bobot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bobot.Location = New System.Drawing.Point(370, 60)
        Me.bobot.Name = "bobot"
        Me.bobot.Size = New System.Drawing.Size(59, 24)
        Me.bobot.TabIndex = 2
        Me.bobot.Text = "Bobot"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tugas Kecil:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tugas Besar:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "UTS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "UAS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(148, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(148, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Grade:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(528, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(528, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 24)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(528, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 24)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(528, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 24)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "%"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(240, 296)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(180, 24)
        Me.lbltotal.TabIndex = 13
        Me.lbltotal.Text = ".................................."
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrade.Location = New System.Drawing.Point(240, 353)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(180, 24)
        Me.lblgrade.TabIndex = 14
        Me.lblgrade.Text = ".................................."
        '
        'hitung
        '
        Me.hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitung.Location = New System.Drawing.Point(152, 432)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(89, 32)
        Me.hitung.TabIndex = 15
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'bersih
        '
        Me.bersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bersih.Location = New System.Drawing.Point(273, 432)
        Me.bersih.Name = "bersih"
        Me.bersih.Size = New System.Drawing.Size(88, 32)
        Me.bersih.TabIndex = 16
        Me.bersih.Text = "Keluar"
        Me.bersih.UseVisualStyleBackColor = True
        '
        'txtntukel
        '
        Me.txtntukel.Location = New System.Drawing.Point(152, 110)
        Me.txtntukel.Name = "txtntukel"
        Me.txtntukel.Size = New System.Drawing.Size(172, 20)
        Me.txtntukel.TabIndex = 17
        '
        'txtbtubes
        '
        Me.txtbtubes.Location = New System.Drawing.Point(330, 159)
        Me.txtbtubes.Name = "txtbtubes"
        Me.txtbtubes.Size = New System.Drawing.Size(172, 20)
        Me.txtbtubes.TabIndex = 18
        '
        'txtbtukel
        '
        Me.txtbtukel.Location = New System.Drawing.Point(330, 110)
        Me.txtbtukel.Name = "txtbtukel"
        Me.txtbtukel.Size = New System.Drawing.Size(172, 20)
        Me.txtbtukel.TabIndex = 19
        '
        'txtnuas
        '
        Me.txtnuas.Location = New System.Drawing.Point(152, 244)
        Me.txtnuas.Name = "txtnuas"
        Me.txtnuas.Size = New System.Drawing.Size(172, 20)
        Me.txtnuas.TabIndex = 20
        '
        'txtnuts
        '
        Me.txtnuts.Location = New System.Drawing.Point(152, 202)
        Me.txtnuts.Name = "txtnuts"
        Me.txtnuts.Size = New System.Drawing.Size(172, 20)
        Me.txtnuts.TabIndex = 21
        '
        'txtntubes
        '
        Me.txtntubes.Location = New System.Drawing.Point(152, 159)
        Me.txtntubes.Name = "txtntubes"
        Me.txtntubes.Size = New System.Drawing.Size(172, 20)
        Me.txtntubes.TabIndex = 22
        '
        'txtbuts
        '
        Me.txtbuts.Location = New System.Drawing.Point(330, 202)
        Me.txtbuts.Name = "txtbuts"
        Me.txtbuts.Size = New System.Drawing.Size(172, 20)
        Me.txtbuts.TabIndex = 23
        '
        'txtbuas
        '
        Me.txtbuas.Location = New System.Drawing.Point(330, 244)
        Me.txtbuas.Name = "txtbuas"
        Me.txtbuas.Size = New System.Drawing.Size(172, 20)
        Me.txtbuas.TabIndex = 24
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 526)
        Me.Controls.Add(Me.txtbuas)
        Me.Controls.Add(Me.txtbuts)
        Me.Controls.Add(Me.txtntubes)
        Me.Controls.Add(Me.txtnuts)
        Me.Controls.Add(Me.txtnuas)
        Me.Controls.Add(Me.txtbtukel)
        Me.Controls.Add(Me.txtbtubes)
        Me.Controls.Add(Me.txtntukel)
        Me.Controls.Add(Me.bersih)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.lblgrade)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bobot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bobot As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblgrade As System.Windows.Forms.Label
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents bersih As System.Windows.Forms.Button
    Friend WithEvents txtntukel As System.Windows.Forms.TextBox
    Friend WithEvents txtbtubes As System.Windows.Forms.TextBox
    Friend WithEvents txtbtukel As System.Windows.Forms.TextBox
    Friend WithEvents txtnuas As System.Windows.Forms.TextBox
    Friend WithEvents txtnuts As System.Windows.Forms.TextBox
    Friend WithEvents txtntubes As System.Windows.Forms.TextBox
    Friend WithEvents txtbuts As System.Windows.Forms.TextBox
    Friend WithEvents txtbuas As System.Windows.Forms.TextBox
End Class
