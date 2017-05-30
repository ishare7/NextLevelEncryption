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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbText = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.tbEncrypted = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSuperEncrypt = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSuperDecrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.GroupText = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btn_fromBinary = New System.Windows.Forms.Button()
        Me.btn_toBinary = New System.Windows.Forms.Button()
        Me.GroupFiles = New System.Windows.Forms.GroupBox()
        Me.tbPassword2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRansomwareUnprotect = New System.Windows.Forms.Button()
        Me.btnRansomwareProtect = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupText.SuspendLayout()
        Me.GroupFiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text:"
        '
        'tbText
        '
        Me.tbText.Location = New System.Drawing.Point(19, 45)
        Me.tbText.Multiline = True
        Me.tbText.Name = "tbText"
        Me.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbText.Size = New System.Drawing.Size(719, 152)
        Me.tbText.TabIndex = 0
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(650, 203)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(88, 27)
        Me.btnEncrypt.TabIndex = 3
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'tbEncrypted
        '
        Me.tbEncrypted.Location = New System.Drawing.Point(19, 300)
        Me.tbEncrypted.Multiline = True
        Me.tbEncrypted.Name = "tbEncrypted"
        Me.tbEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbEncrypted.Size = New System.Drawing.Size(719, 152)
        Me.tbEncrypted.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Encrypted text:"
        '
        'btnSuperEncrypt
        '
        Me.btnSuperEncrypt.Location = New System.Drawing.Point(520, 203)
        Me.btnSuperEncrypt.Name = "btnSuperEncrypt"
        Me.btnSuperEncrypt.Size = New System.Drawing.Size(124, 27)
        Me.btnSuperEncrypt.TabIndex = 4
        Me.btnSuperEncrypt.Text = "Super Encrypt"
        Me.btnSuperEncrypt.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(19, 247)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(719, 24)
        Me.tbPassword.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password:"
        '
        'btnSuperDecrypt
        '
        Me.btnSuperDecrypt.Location = New System.Drawing.Point(520, 458)
        Me.btnSuperDecrypt.Name = "btnSuperDecrypt"
        Me.btnSuperDecrypt.Size = New System.Drawing.Size(124, 27)
        Me.btnSuperDecrypt.TabIndex = 6
        Me.btnSuperDecrypt.Text = "Super Decrypt"
        Me.btnSuperDecrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(650, 458)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(88, 27)
        Me.btnDecrypt.TabIndex = 5
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'GroupText
        '
        Me.GroupText.BackColor = System.Drawing.Color.White
        Me.GroupText.Controls.Add(Me.LinkLabel2)
        Me.GroupText.Controls.Add(Me.LinkLabel1)
        Me.GroupText.Controls.Add(Me.btn_fromBinary)
        Me.GroupText.Controls.Add(Me.btn_toBinary)
        Me.GroupText.Controls.Add(Me.tbText)
        Me.GroupText.Controls.Add(Me.Label1)
        Me.GroupText.Controls.Add(Me.btnSuperDecrypt)
        Me.GroupText.Controls.Add(Me.btnEncrypt)
        Me.GroupText.Controls.Add(Me.btnDecrypt)
        Me.GroupText.Controls.Add(Me.Label2)
        Me.GroupText.Controls.Add(Me.tbPassword)
        Me.GroupText.Controls.Add(Me.tbEncrypted)
        Me.GroupText.Controls.Add(Me.Label3)
        Me.GroupText.Controls.Add(Me.btnSuperEncrypt)
        Me.GroupText.Location = New System.Drawing.Point(12, 12)
        Me.GroupText.Name = "GroupText"
        Me.GroupText.Size = New System.Drawing.Size(752, 501)
        Me.GroupText.TabIndex = 12
        Me.GroupText.TabStop = False
        Me.GroupText.Text = "Text"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(607, 279)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(131, 18)
        Me.LinkLabel2.TabIndex = 12
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Copy to Clipboard "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(607, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(131, 18)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Copy to Clipboard "
        '
        'btn_fromBinary
        '
        Me.btn_fromBinary.Location = New System.Drawing.Point(360, 459)
        Me.btn_fromBinary.Name = "btn_fromBinary"
        Me.btn_fromBinary.Size = New System.Drawing.Size(154, 26)
        Me.btn_fromBinary.TabIndex = 10
        Me.btn_fromBinary.Text = "Convert from Binary"
        Me.btn_fromBinary.UseVisualStyleBackColor = True
        '
        'btn_toBinary
        '
        Me.btn_toBinary.Location = New System.Drawing.Point(360, 203)
        Me.btn_toBinary.Name = "btn_toBinary"
        Me.btn_toBinary.Size = New System.Drawing.Size(154, 27)
        Me.btn_toBinary.TabIndex = 9
        Me.btn_toBinary.Text = "Convert to Binary"
        Me.btn_toBinary.UseVisualStyleBackColor = True
        '
        'GroupFiles
        '
        Me.GroupFiles.BackColor = System.Drawing.Color.White
        Me.GroupFiles.Controls.Add(Me.tbPassword2)
        Me.GroupFiles.Controls.Add(Me.Label4)
        Me.GroupFiles.Controls.Add(Me.btnRansomwareUnprotect)
        Me.GroupFiles.Controls.Add(Me.btnRansomwareProtect)
        Me.GroupFiles.Location = New System.Drawing.Point(12, 519)
        Me.GroupFiles.Name = "GroupFiles"
        Me.GroupFiles.Size = New System.Drawing.Size(752, 96)
        Me.GroupFiles.TabIndex = 13
        Me.GroupFiles.TabStop = False
        Me.GroupFiles.Text = "Files"
        '
        'tbPassword2
        '
        Me.tbPassword2.Location = New System.Drawing.Point(308, 44)
        Me.tbPassword2.Name = "tbPassword2"
        Me.tbPassword2.Size = New System.Drawing.Size(226, 24)
        Me.tbPassword2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password:"
        '
        'btnRansomwareUnprotect
        '
        Me.btnRansomwareUnprotect.Location = New System.Drawing.Point(540, 39)
        Me.btnRansomwareUnprotect.Name = "btnRansomwareUnprotect"
        Me.btnRansomwareUnprotect.Size = New System.Drawing.Size(198, 34)
        Me.btnRansomwareUnprotect.TabIndex = 9
        Me.btnRansomwareUnprotect.Text = "Ransomware Unprotect"
        Me.btnRansomwareUnprotect.UseVisualStyleBackColor = True
        '
        'btnRansomwareProtect
        '
        Me.btnRansomwareProtect.Location = New System.Drawing.Point(19, 39)
        Me.btnRansomwareProtect.Name = "btnRansomwareProtect"
        Me.btnRansomwareProtect.Size = New System.Drawing.Size(198, 34)
        Me.btnRansomwareProtect.TabIndex = 7
        Me.btnRansomwareProtect.Text = "Ransowmare Protect"
        Me.btnRansomwareProtect.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 630)
        Me.Controls.Add(Me.GroupFiles)
        Me.Controls.Add(Me.GroupText)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NextLevelEncryption"
        Me.GroupText.ResumeLayout(False)
        Me.GroupText.PerformLayout()
        Me.GroupFiles.ResumeLayout(False)
        Me.GroupFiles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbText As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents tbEncrypted As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSuperEncrypt As System.Windows.Forms.Button
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSuperDecrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents GroupText As System.Windows.Forms.GroupBox
    Friend WithEvents GroupFiles As System.Windows.Forms.GroupBox
    Friend WithEvents btnRansomwareUnprotect As System.Windows.Forms.Button
    Friend WithEvents btnRansomwareProtect As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_fromBinary As System.Windows.Forms.Button
    Friend WithEvents btn_toBinary As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
