<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.erkekbtn = New System.Windows.Forms.RadioButton()
        Me.kadinbtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.muaf = New System.Windows.Forms.RadioButton()
        Me.yapmadi = New System.Windows.Forms.RadioButton()
        Me.yapti = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'erkekbtn
        '
        Me.erkekbtn.AutoSize = True
        Me.erkekbtn.Location = New System.Drawing.Point(11, 17)
        Me.erkekbtn.Name = "erkekbtn"
        Me.erkekbtn.Size = New System.Drawing.Size(63, 20)
        Me.erkekbtn.TabIndex = 0
        Me.erkekbtn.TabStop = True
        Me.erkekbtn.Text = "Erkek"
        Me.erkekbtn.UseVisualStyleBackColor = True
        '
        'kadinbtn
        '
        Me.kadinbtn.AutoSize = True
        Me.kadinbtn.Location = New System.Drawing.Point(11, 43)
        Me.kadinbtn.Name = "kadinbtn"
        Me.kadinbtn.Size = New System.Drawing.Size(62, 20)
        Me.kadinbtn.TabIndex = 1
        Me.kadinbtn.TabStop = True
        Me.kadinbtn.Text = "Kadın"
        Me.kadinbtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.kadinbtn)
        Me.GroupBox1.Controls.Add(Me.erkekbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 105)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cinsiyet"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.muaf)
        Me.GroupBox2.Controls.Add(Me.yapmadi)
        Me.GroupBox2.Controls.Add(Me.yapti)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 105)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Askerlik Durumu"
        '
        'muaf
        '
        Me.muaf.AutoSize = True
        Me.muaf.Location = New System.Drawing.Point(11, 69)
        Me.muaf.Name = "muaf"
        Me.muaf.Size = New System.Drawing.Size(57, 20)
        Me.muaf.TabIndex = 2
        Me.muaf.TabStop = True
        Me.muaf.Text = "Muaf"
        Me.muaf.UseVisualStyleBackColor = True
        '
        'yapmadi
        '
        Me.yapmadi.AutoSize = True
        Me.yapmadi.Location = New System.Drawing.Point(11, 43)
        Me.yapmadi.Name = "yapmadi"
        Me.yapmadi.Size = New System.Drawing.Size(83, 20)
        Me.yapmadi.TabIndex = 1
        Me.yapmadi.TabStop = True
        Me.yapmadi.Text = "Yapmadı"
        Me.yapmadi.UseVisualStyleBackColor = True
        '
        'yapti
        '
        Me.yapti.AutoSize = True
        Me.yapti.Location = New System.Drawing.Point(11, 17)
        Me.yapti.Name = "yapti"
        Me.yapti.Size = New System.Drawing.Size(59, 20)
        Me.yapti.TabIndex = 0
        Me.yapti.TabStop = True
        Me.yapti.Text = "Yaptı"
        Me.yapti.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Soyad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tc:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(103, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Bilgileri Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(101, 78)
        Me.MaskedTextBox1.Mask = "00000000000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox1.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(269, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(254, 388)
        Me.ListBox1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 482)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents erkekbtn As RadioButton
    Friend WithEvents kadinbtn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents muaf As RadioButton
    Friend WithEvents yapmadi As RadioButton
    Friend WithEvents yapti As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ListBox1 As ListBox
End Class
