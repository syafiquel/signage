<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.ButSync = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textip = New System.Windows.Forms.TextBox()
        Me.Textport = New System.Windows.Forms.TextBox()
        Me.Textid = New System.Windows.Forms.TextBox()
        Me.Textpass = New System.Windows.Forms.TextBox()
        Me.ButCon = New System.Windows.Forms.Button()
        Me.Textstat = New System.Windows.Forms.TextBox()
        Me.Lloc = New System.Windows.Forms.ListBox()
        Me.Lwhy = New System.Windows.Forms.ListBox()
        Me.ButPlay = New System.Windows.Forms.Button()
        Me.ButStop = New System.Windows.Forms.Button()
        Me.RadioD = New System.Windows.Forms.RadioButton()
        Me.RadioA = New System.Windows.Forms.RadioButton()
        Me.ButRef = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextVid = New System.Windows.Forms.TextBox()
        Me.ButCreate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButColor = New System.Windows.Forms.Button()
        Me.Textdur = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButPrev = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Textsz = New System.Windows.Forms.TextBox()
        Me.Buttexto = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioWH = New System.Windows.Forms.RadioButton()
        Me.RadioLO = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButSync
        '
        Me.ButSync.Location = New System.Drawing.Point(247, 136)
        Me.ButSync.Name = "ButSync"
        Me.ButSync.Size = New System.Drawing.Size(189, 27)
        Me.ButSync.TabIndex = 0
        Me.ButSync.Text = "SYNC FILES AS LOCAL ->"
        Me.ButSync.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "< LOCAL FILES >"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(486, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "< WHiSiC FILES >"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "IP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "PORT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(247, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "PSWD:"
        '
        'Textip
        '
        Me.Textip.Location = New System.Drawing.Point(58, 67)
        Me.Textip.Name = "Textip"
        Me.Textip.Size = New System.Drawing.Size(145, 20)
        Me.Textip.TabIndex = 9
        Me.Textip.Text = "192.168.239.101"
        '
        'Textport
        '
        Me.Textport.Location = New System.Drawing.Point(58, 96)
        Me.Textport.Name = "Textport"
        Me.Textport.Size = New System.Drawing.Size(145, 20)
        Me.Textport.TabIndex = 10
        Me.Textport.Text = "22"
        '
        'Textid
        '
        Me.Textid.Location = New System.Drawing.Point(323, 67)
        Me.Textid.Name = "Textid"
        Me.Textid.Size = New System.Drawing.Size(145, 20)
        Me.Textid.TabIndex = 11
        Me.Textid.Text = "pi"
        '
        'Textpass
        '
        Me.Textpass.Location = New System.Drawing.Point(323, 96)
        Me.Textpass.Name = "Textpass"
        Me.Textpass.Size = New System.Drawing.Size(145, 20)
        Me.Textpass.TabIndex = 12
        Me.Textpass.Text = "pi"
        '
        'ButCon
        '
        Me.ButCon.Location = New System.Drawing.Point(491, 67)
        Me.ButCon.Name = "ButCon"
        Me.ButCon.Size = New System.Drawing.Size(178, 50)
        Me.ButCon.TabIndex = 13
        Me.ButCon.Text = "TEST CONNECTION"
        Me.ButCon.UseVisualStyleBackColor = True
        '
        'Textstat
        '
        Me.Textstat.BackColor = System.Drawing.SystemColors.Info
        Me.Textstat.Location = New System.Drawing.Point(18, 19)
        Me.Textstat.Multiline = True
        Me.Textstat.Name = "Textstat"
        Me.Textstat.Size = New System.Drawing.Size(647, 46)
        Me.Textstat.TabIndex = 14
        Me.Textstat.Text = "STATUS"
        Me.Textstat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lloc
        '
        Me.Lloc.FormattingEnabled = True
        Me.Lloc.Location = New System.Drawing.Point(15, 84)
        Me.Lloc.Name = "Lloc"
        Me.Lloc.Size = New System.Drawing.Size(226, 108)
        Me.Lloc.TabIndex = 15
        '
        'Lwhy
        '
        Me.Lwhy.FormattingEnabled = True
        Me.Lwhy.Location = New System.Drawing.Point(442, 84)
        Me.Lwhy.Name = "Lwhy"
        Me.Lwhy.Size = New System.Drawing.Size(221, 108)
        Me.Lwhy.TabIndex = 16
        '
        'ButPlay
        '
        Me.ButPlay.Location = New System.Drawing.Point(247, 169)
        Me.ButPlay.Name = "ButPlay"
        Me.ButPlay.Size = New System.Drawing.Size(54, 23)
        Me.ButPlay.TabIndex = 17
        Me.ButPlay.Text = "PLAY"
        Me.ButPlay.UseVisualStyleBackColor = True
        '
        'ButStop
        '
        Me.ButStop.Location = New System.Drawing.Point(382, 169)
        Me.ButStop.Name = "ButStop"
        Me.ButStop.Size = New System.Drawing.Size(54, 23)
        Me.ButStop.TabIndex = 18
        Me.ButStop.Text = "STOP"
        Me.ButStop.UseVisualStyleBackColor = True
        '
        'RadioD
        '
        Me.RadioD.AutoSize = True
        Me.RadioD.Checked = True
        Me.RadioD.Location = New System.Drawing.Point(6, 19)
        Me.RadioD.Name = "RadioD"
        Me.RadioD.Size = New System.Drawing.Size(142, 17)
        Me.RadioD.TabIndex = 19
        Me.RadioD.TabStop = True
        Me.RadioD.Text = "HDMI CONNECTION"
        Me.RadioD.UseVisualStyleBackColor = True
        '
        'RadioA
        '
        Me.RadioA.AutoSize = True
        Me.RadioA.Location = New System.Drawing.Point(167, 19)
        Me.RadioA.Name = "RadioA"
        Me.RadioA.Size = New System.Drawing.Size(236, 17)
        Me.RadioA.TabIndex = 20
        Me.RadioA.Text = "COMPOSITE + AUDIO CONNECTION"
        Me.RadioA.UseVisualStyleBackColor = True
        '
        'ButRef
        '
        Me.ButRef.Location = New System.Drawing.Point(307, 169)
        Me.ButRef.Name = "ButRef"
        Me.ButRef.Size = New System.Drawing.Size(73, 23)
        Me.ButRef.TabIndex = 21
        Me.ButRef.Text = "REFRESH"
        Me.ButRef.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(14, 338)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(153, 17)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "CREATE TEXT VIDEO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextVid
        '
        Me.TextVid.ForeColor = System.Drawing.Color.Black
        Me.TextVid.Location = New System.Drawing.Point(6, 19)
        Me.TextVid.Multiline = True
        Me.TextVid.Name = "TextVid"
        Me.TextVid.Size = New System.Drawing.Size(212, 121)
        Me.TextVid.TabIndex = 23
        Me.TextVid.Text = "KEPADA PENDUDUK SRI LANGKA HARI INI MAKANAN TIADA JADI TAK PERLU DATANG LAGI"
        '
        'ButCreate
        '
        Me.ButCreate.Location = New System.Drawing.Point(561, 86)
        Me.ButCreate.Name = "ButCreate"
        Me.ButCreate.Size = New System.Drawing.Size(79, 51)
        Me.ButCreate.TabIndex = 24
        Me.ButCreate.Text = "CREATE VIDEO"
        Me.ButCreate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(390, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "(WRITE YOUR TEXT)"
        '
        'ButColor
        '
        Me.ButColor.BackColor = System.Drawing.Color.White
        Me.ButColor.ForeColor = System.Drawing.Color.Black
        Me.ButColor.Location = New System.Drawing.Point(224, 19)
        Me.ButColor.Name = "ButColor"
        Me.ButColor.Size = New System.Drawing.Size(155, 32)
        Me.ButColor.TabIndex = 27
        Me.ButColor.Text = "BACKGROUND COLOR"
        Me.ButColor.UseVisualStyleBackColor = False
        '
        'Textdur
        '
        Me.Textdur.Location = New System.Drawing.Point(561, 38)
        Me.Textdur.Name = "Textdur"
        Me.Textdur.Size = New System.Drawing.Size(79, 20)
        Me.Textdur.TabIndex = 28
        Me.Textdur.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(558, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "VID LENGTH:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(564, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "(SECONDS)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(436, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "(PREVIEW)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioD)
        Me.GroupBox1.Controls.Add(Me.RadioA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 49)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DISPLAY CONNECTOR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButPrev)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Textsz)
        Me.GroupBox2.Controls.Add(Me.Buttexto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextVid)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ButColor)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ButCreate)
        Me.GroupBox2.Controls.Add(Me.Textdur)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 361)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 172)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TEXT TO VIDEO SETTING"
        '
        'ButPrev
        '
        Me.ButPrev.Location = New System.Drawing.Point(227, 109)
        Me.ButPrev.Name = "ButPrev"
        Me.ButPrev.Size = New System.Drawing.Size(154, 35)
        Me.ButPrev.TabIndex = 35
        Me.ButPrev.Text = "PREVIEW"
        Me.ButPrev.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(224, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "TEXT SIZE:"
        '
        'Textsz
        '
        Me.Textsz.Location = New System.Drawing.Point(309, 86)
        Me.Textsz.Name = "Textsz"
        Me.Textsz.Size = New System.Drawing.Size(70, 20)
        Me.Textsz.TabIndex = 33
        Me.Textsz.Text = "35"
        '
        'Buttexto
        '
        Me.Buttexto.BackColor = System.Drawing.Color.Black
        Me.Buttexto.ForeColor = System.Drawing.Color.White
        Me.Buttexto.Location = New System.Drawing.Point(224, 55)
        Me.Buttexto.Name = "Buttexto"
        Me.Buttexto.Size = New System.Drawing.Size(157, 25)
        Me.Buttexto.TabIndex = 32
        Me.Buttexto.Text = "TEXT COLOR"
        Me.Buttexto.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Textstat)
        Me.GroupBox3.Controls.Add(Me.Lloc)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ButPlay)
        Me.GroupBox3.Controls.Add(Me.ButRef)
        Me.GroupBox3.Controls.Add(Me.ButStop)
        Me.GroupBox3.Controls.Add(Me.ButSync)
        Me.GroupBox3.Controls.Add(Me.Lwhy)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(672, 204)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "REMOTE MANAGER"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioWH)
        Me.GroupBox4.Controls.Add(Me.RadioLO)
        Me.GroupBox4.Location = New System.Drawing.Point(247, 84)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(189, 46)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SYNC OPTION (SAME AS)"
        '
        'RadioWH
        '
        Me.RadioWH.AutoSize = True
        Me.RadioWH.Location = New System.Drawing.Point(115, 20)
        Me.RadioWH.Name = "RadioWH"
        Me.RadioWH.Size = New System.Drawing.Size(68, 17)
        Me.RadioWH.TabIndex = 1
        Me.RadioWH.Text = "WHiSiC"
        Me.RadioWH.UseVisualStyleBackColor = True
        '
        'RadioLO
        '
        Me.RadioLO.AutoSize = True
        Me.RadioLO.Checked = True
        Me.RadioLO.Location = New System.Drawing.Point(7, 20)
        Me.RadioLO.Name = "RadioLO"
        Me.RadioLO.Size = New System.Drawing.Size(64, 17)
        Me.RadioLO.TabIndex = 0
        Me.RadioLO.TabStop = True
        Me.RadioLO.Text = "LOCAL"
        Me.RadioLO.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(491, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 37)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "RESTART WHiSiC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 540)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ButCon)
        Me.Controls.Add(Me.Textpass)
        Me.Controls.Add(Me.Textid)
        Me.Controls.Add(Me.Textport)
        Me.Controls.Add(Me.Textip)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "mainform"
        Me.Text = "WHiSiC MANAGER"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButSync As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Textip As System.Windows.Forms.TextBox
    Friend WithEvents Textport As System.Windows.Forms.TextBox
    Friend WithEvents Textid As System.Windows.Forms.TextBox
    Friend WithEvents Textpass As System.Windows.Forms.TextBox
    Friend WithEvents ButCon As System.Windows.Forms.Button
    Friend WithEvents Textstat As System.Windows.Forms.TextBox
    Friend WithEvents Lloc As System.Windows.Forms.ListBox
    Friend WithEvents Lwhy As System.Windows.Forms.ListBox
    Friend WithEvents ButPlay As System.Windows.Forms.Button
    Friend WithEvents ButStop As System.Windows.Forms.Button
    Friend WithEvents RadioD As System.Windows.Forms.RadioButton
    Friend WithEvents RadioA As System.Windows.Forms.RadioButton
    Friend WithEvents ButRef As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextVid As System.Windows.Forms.TextBox
    Friend WithEvents ButCreate As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButColor As System.Windows.Forms.Button
    Friend WithEvents Textdur As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Textsz As System.Windows.Forms.TextBox
    Friend WithEvents Buttexto As System.Windows.Forms.Button
    Friend WithEvents ButPrev As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioWH As System.Windows.Forms.RadioButton
    Friend WithEvents RadioLO As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
