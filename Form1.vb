Imports System.IO
Imports System.Xml
Imports System.Xml.XPath
Imports System.Text.RegularExpressions




Public Class mainform
    Dim bcol As Color = Color.FromArgb(255, 255, 255)
    Dim tcol As Color = Color.FromArgb(0, 0, 0)
    Dim id, psw, ip, port As String
    Dim img As Bitmap
    Dim winscp, proc As New Process()
    Dim lpath As String = "C:\vids"
    Dim rpath As String = "/home/pi/whibicplay"
    Dim filen As String = "whibicplay"
    'Dim rpath As String = "/Users/sitinorhidayah/whisic"
    'Dim filen As String = "whisic"
    Const logname As String = "log.xml"
    Dim sync As Boolean = True

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSync.Click


        Try                ' Get the path that stores user documents.

            winscp.StartInfo.FileName = "winscp.com"
            winscp.StartInfo.Arguments = "/xmllog=" + logname
            winscp.StartInfo.UseShellExecute = False
            winscp.StartInfo.RedirectStandardInput = True
            winscp.StartInfo.RedirectStandardOutput = True
            winscp.StartInfo.CreateNoWindow = True
            winscp.Start()


        Catch ek As Exception
            Console.WriteLine((ek.Message))
        End Try
        winscp.StandardInput.WriteLine("option batch abort")
        winscp.StandardInput.WriteLine("option confirm off")
        id = Textid.Text
        psw = Textpass.Text
        ip = Textip.Text
        port = Textport.Text
        Dim lines As String
        lines = "open sftp://" + id + ":" + psw + "@" + ip + ":" + port
        winscp.StandardInput.WriteLine(lines)
        Dim cmd As String = "synchronize remote -delete " + lpath + " " + rpath
        If sync Then
            cmd = "synchronize remote -delete " + lpath + " " + rpath
        Else
            cmd = "synchronize local -delete " + lpath + " " + rpath
        End If

        winscp.StandardInput.WriteLine(cmd)
        winscp.StandardInput.Close()

        Dim ser As String = winscp.StandardOutput.ReadToEnd()
        Textstat.Text = ser
        Dim Fi As Integer = ser.IndexOf("rror")
        Dim Fi2 As Integer = ser.IndexOf("ailed")
        If Fi = -1 And Fi2 = -1 Then
            MsgBox("Sync OK", MsgBoxStyle.Information)
        Else
            MsgBox("Sync Fail", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCon.Click

        Try                ' Get the path that stores user documents.

            winscp.StartInfo.FileName = "winscp.com"
            winscp.StartInfo.Arguments = "/xmllog=" + logname
            winscp.StartInfo.UseShellExecute = False
            winscp.StartInfo.RedirectStandardInput = True
            winscp.StartInfo.RedirectStandardOutput = True
            winscp.StartInfo.CreateNoWindow = True
            winscp.Start()


        Catch ek As Exception
            Console.WriteLine((ek.Message))
        End Try
        winscp.StandardInput.WriteLine("option batch abort")
        winscp.StandardInput.WriteLine("option confirm off")
        id = Textid.Text
        psw = Textpass.Text
        ip = Textip.Text
        port = Textport.Text
        Dim lines As String
        lines = "open sftp://" + id + ":" + psw + "@" + ip + ":" + port
        winscp.StandardInput.WriteLine(lines)
        winscp.StandardInput.Close()

        Dim ser As String = winscp.StandardOutput.ReadToEnd()
        Textstat.Text = ser
        Dim Fi As Integer = ser.IndexOf("rror")
        Dim Fi2 As Integer = ser.IndexOf("ailed")
        If Fi = -1 And Fi2 = -1 Then
            MsgBox("Connection OK", MsgBoxStyle.Information)
            GroupBox3.Enabled = True
        Else
            MsgBox("Connection Fail", MsgBoxStyle.Critical)
        End If






        'Dim log As XPathDocument = New XPathDocument(logname)
        'Dim ns As XmlNamespaceManager = New XmlNamespaceManager(New NameTable())
        'ns.AddNamespace("w", "http://winscp.net/schema/session/1.0")
        'Dim nav As XPathNavigator = log.CreateNavigator()



        'Dim files As XPathNodeIterator = nav.Select("//w:call", ns)
        'Textstat.Text = files(0).SelectSingleNode("w:output/@value", ns).Value.ToString

        'Try                ' Get the path that stores user documents.

        '    winscp.StartInfo.FileName = "winscp.com"
        '    winscp.StartInfo.Arguments = "/xmllog=" + logname
        '    winscp.StartInfo.UseShellExecute = False
        '    winscp.StartInfo.RedirectStandardInput = True
        '    winscp.StartInfo.RedirectStandardOutput = True
        '    winscp.StartInfo.CreateNoWindow = True
        '    winscp.Start()

        '    ' This code assumes the process you are starting will terminate itself.  
        '    ' Given that is is started without a window so you cannot terminate it  
        '    ' on the desktop, it must terminate itself or you can do it programmatically 
        '    ' from this application using the Kill method. 
        'Catch ek As Exception
        '    Console.WriteLine((ek.Message))
        'End Try
        'winscp.StandardInput.WriteLine("option batch abort")
        'winscp.StandardInput.WriteLine("option confirm off")
        'id = Textid.Text
        'psw = Textpass.Text
        'ip = Textip.Text
        'port = Textport.Text
        'Dim lines As String
        'lines = "open sftp://" + id + ":" + psw + "@" + ip + ":" + port
        'winscp.StandardInput.WriteLine(lines)
        ''winscp.StandardInput.WriteLine("open sftp://sitinorhidayah:103103@192.168.43.55:22")
        ''TextBox1.Text = winscp.StandardOutput.ReadLine()
        ''TextBox1.Text = winscp.StandardOutput.ReadToEnd()
        ''winscp.StandardInput.WriteLine("call open example.txt")
        ''winscp.StandardInput.WriteLine("put C:\example.txt")
        ''TextBox1.Text = winscp.StandardOutput.ReadLine()
        'winscp.StandardInput.Close()
        'Textstat.Text = winscp.StandardOutput.ReadToEnd()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButRef.Click
        Lloc.Items.Clear()
        Lwhy.Items.Clear()

        'Get filename is whisic and save in log.xml
        Try

            winscp.StartInfo.FileName = "winscp.com"
            winscp.StartInfo.Arguments = "/xmllog=" + logname
            winscp.StartInfo.UseShellExecute = False
            winscp.StartInfo.RedirectStandardInput = True
            winscp.StartInfo.RedirectStandardOutput = True
            winscp.StartInfo.CreateNoWindow = True

            winscp.Start()

        Catch ek As Exception
            Console.WriteLine((ek.Message))
        End Try
        winscp.StandardInput.WriteLine("option batch abort")
        winscp.StandardInput.WriteLine("option confirm off")
        id = Textid.Text
        psw = Textpass.Text
        ip = Textip.Text
        port = Textport.Text
        Dim lines As String
        lines = "open sftp://" + id + ":" + psw + "@" + ip + ":" + port
        winscp.StandardInput.WriteLine(lines)
        Dim cm As String = "call ls " + filen
        winscp.StandardInput.WriteLine(cm)
        winscp.StandardInput.Close()

        Dim ser As String = winscp.StandardOutput.ReadToEnd()
        Textstat.Text = ser
        Dim Fi As Integer = ser.IndexOf("rror")
        Dim Fi2 As Integer = ser.IndexOf("ailed")
        If Fi = -1 And Fi2 = -1 Then
            MsgBox("Refresh OK", MsgBoxStyle.Information)
        Else
            MsgBox("Refresh Fail", MsgBoxStyle.Critical)
        End If

        'write local files
        Dim allfiles As String() = Directory.GetFiles(lpath)
        Dim s, out As String
        For v As Integer = 1 To allfiles.Length
            s = allfiles(v - 1)
            out = s.Replace(lpath + "\", "")
            If String.Equals(out.Trim, ".DS_Store") Then
                Continue For
            Else
                Lloc.Items.Add(out)
            End If
        Next
        'write whisic files
        Dim reader As XmlTextReader = New XmlTextReader(logname)
        Do While (reader.Read())
            If reader.Name = "output" Then
                Dim att As String = reader("value")

                Dim parts As String() = att.Split(New Char() {Chr(10)})

                Dim part As String
                For Each part In parts
                    Lwhy.Items.Add(part)
                Next

                Exit Do
            End If
        Loop
        reader.Close()


    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
    End Sub


    Private Sub ButCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCreate.Click
        If Not IsNumeric(Textdur.Text) Then
            MsgBox("Value you insert is not numeric")
        End If
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.RunWorkerAsync()



    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        startConversion()
        'Dim patho As String = Directory.GetCurrentDirectory()
        'Dim files = From f In Directory.GetFiles(patho, "*.mp4")
        'For Each f In files

        '    File.Move(f, Path.Combine(lpath, Path.GetFileName(f)))
        'Next
        MsgBox("Completed!", MsgBoxStyle.Exclamation)
    End Sub



    Function startConversion()
        Control.CheckForIllegalCrossThreadCalls = False

        Dim startinfo As New System.Diagnostics.ProcessStartInfo

        'Dim cmd As String = "-loop 1 -f image2 -i vid.jpg -t 10 -vcodec libx264 out.mp4"
        Dim cmd As String = "-loop 1 -f image2 -i vid.jpg -t " + Textdur.Text + " -vcodec libx264 " + lpath + "\" + System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".mp4"
        Textstat.Text = cmd
        Dim ffmpegOutput As String
        Dim sr As StreamReader

        startinfo.FileName = "ffmpeg.exe"
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.RedirectStandardOutput = True
        startinfo.CreateNoWindow = True
        proc.StartInfo = startinfo
        proc.Start() ' start the process


        sr = proc.StandardError 'standard error is used by ffmpeg

        Do
            ffmpegOutput = sr.ReadLine

        Loop Until proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""



        Return 0
    End Function

    Private Sub ButColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButColor.Click

        Dim cDialog As New ColorDialog()
        cDialog.Color = ButColor.BackColor

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Dim rD As Integer = cDialog.Color.R
            Dim gD As Integer = cDialog.Color.G
            Dim bD As Integer = cDialog.Color.B

            Dim rT As Integer = ButColor.ForeColor.R
            Dim gT As Integer = ButColor.ForeColor.G
            Dim bT As Integer = ButColor.ForeColor.B

            Dim diff As Integer = Math.Abs(rD - rT) + Math.Abs(gD - gT) + Math.Abs(bD - bT)

            If diff < 200 Then
                ButColor.ForeColor = Color.FromArgb(255 - rD, 255 - gD, 255 - bD)
                ButColor.BackColor = cDialog.Color
            Else
                ButColor.BackColor = cDialog.Color
            End If
            bcol = cDialog.Color
        End If
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButPrev.Click
        If Not IsNumeric(Textsz.Text) Then
            MsgBox("Value you insert is not numeric")
        End If


        Using Bmp As New Bitmap(1280, 720, Imaging.PixelFormat.Format32bppPArgb)
            'Set the resolution to 300 DPI
            Bmp.SetResolution(100, 100)
            'Create a graphics object from the bitmap
            Using G = Graphics.FromImage(Bmp)
                'Paint the canvas white
                G.Clear(bcol)
                'Set various modes to higher quality
                G.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

                Dim F As New Font("Arial", Val(Textsz.Text))
                Dim B As New SolidBrush(tcol)
                Dim format1 As New StringFormat
                format1.Alignment = StringAlignment.Center
                format1.LineAlignment = StringAlignment.Center

                Dim x As Single = 0.0F
                Dim y As Single = 0.0F
                Dim width As Single = 1280.0F
                Dim height As Single = 720.0F
                Dim drawRect As New RectangleF(x, y, width, height)

                G.DrawString(TextVid.Text, F, B, drawRect, format1)

            End Using
            img = Bmp.Clone()
            PictureBox1.Image = img
            'Bmp.Save("C:\Documents and Settings\MEL\Desktop\Signature.bmp", Imaging.ImageFormat.Bmp)
            Bmp.Save("vid.jpg", Imaging.ImageFormat.Jpeg)
        End Using
    End Sub


    Private Sub Buttexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttexto.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = Buttexto.BackColor

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Dim rD As Integer = cDialog.Color.R
            Dim gD As Integer = cDialog.Color.G
            Dim bD As Integer = cDialog.Color.B

            Dim rT As Integer = Buttexto.ForeColor.R
            Dim gT As Integer = Buttexto.ForeColor.G
            Dim bT As Integer = Buttexto.ForeColor.B

            Dim diff As Integer = Math.Abs(rD - rT) + Math.Abs(gD - gT) + Math.Abs(bD - bT)

            If diff < 200 Then
                Buttexto.ForeColor = Color.FromArgb(255 - rD, 255 - gD, 255 - bD)
                Buttexto.BackColor = cDialog.Color
            Else
                Buttexto.BackColor = cDialog.Color
            End If
            tcol = cDialog.Color
        End If
    End Sub

    Private Sub ButPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButPlay.Click

        Try                ' Get the path that stores user documents.

            winscp.StartInfo.FileName = "winscp.com"
            winscp.StartInfo.Arguments = "/xmllog=" + logname
            winscp.StartInfo.UseShellExecute = False
            winscp.StartInfo.RedirectStandardInput = True
            winscp.StartInfo.RedirectStandardOutput = True
            winscp.StartInfo.CreateNoWindow = True
            winscp.Start()


        Catch ek As Exception
            Console.WriteLine((ek.Message))
        End Try
        winscp.StandardInput.WriteLine("option batch abort")
        winscp.StandardInput.WriteLine("option confirm off")
        id = Textid.Text
        psw = Textpass.Text
        ip = Textip.Text
        port = Textport.Text
        Dim lines As String
        lines = "open sftp://" + id + ":" + psw + "@" + ip + ":" + port
        winscp.StandardInput.WriteLine(lines)

        Dim cmd As String = "call sudo ./runwhibic.sh"
        winscp.StandardInput.WriteLine(cmd)
        winscp.StandardInput.Close()

        Dim ser As String = winscp.StandardOutput.ReadToEnd()
        Textstat.Text = ser
        Dim Fi As Integer = ser.IndexOf("rror")
        Dim Fi2 As Integer = ser.IndexOf("ailed")
        If Fi = -1 And Fi2 = -1 Then
            MsgBox("Play OK", MsgBoxStyle.Information)
        Else
            MsgBox("Play Fail", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ButStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButStop.Click
        Try                ' Get the path that stores user documents.

            winscp.StartInfo.FileName = "winscp.com"
            winscp.StartInfo.Arguments = "/xmllog=" + logname
            winscp.StartInfo.UseShellExecute = False
            winscp.StartInfo.RedirectStandardInput = True
            winscp.StartInfo.RedirectStandardOutput = True
            winscp.StartInfo.CreateNoWindow = True
            winscp.Start()


        Catch ek As Exception
            Console.WriteLine((ek.Message))
        End Try
        winscp.StandardInput.WriteLine("option batch abort")
        winscp.StandardInput.WriteLine("option confirm off")
        id = Textid.Text
        psw = Textpass.Text
        ip = Textip.Text
        port = Textport.Text
        Dim lines As String
        lines = "open sftp://" + id + ":" + psw + "@" + ip + ":" + port
        winscp.StandardInput.WriteLine(lines)

        Dim cmd As String = "call sudo pkill runwhibic.sh"
        winscp.StandardInput.WriteLine(cmd)
        cmd = "call sudo pkill omxplayer"
        winscp.StandardInput.WriteLine(cmd)
        winscp.StandardInput.Close()

        Dim ser As String = winscp.StandardOutput.ReadToEnd()
        Textstat.Text = ser
        Dim Fi As Integer = ser.IndexOf("rror")
        Dim Fi2 As Integer = ser.IndexOf("ailed")
        If Fi = -1 And Fi2 = -1 Then
            MsgBox("Stop OK", MsgBoxStyle.Information)
        Else
            MsgBox("Stop Fail", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub RadioLO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioLO.CheckedChanged
        ButSync.Text = "SYNC FILES AS LOCAL ->"
        sync = True
    End Sub

    Private Sub RadioWH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioWH.CheckedChanged
        ButSync.Text = "<- SYNC FILES AS WHiSiC"
        sync = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try                ' Get the path that stores user documents.

            winscp.StartInfo.FileName = "winscp.com"
            winscp.StartInfo.Arguments = "/xmllog=" + logname
            winscp.StartInfo.UseShellExecute = False
            winscp.StartInfo.RedirectStandardInput = True
            winscp.StartInfo.RedirectStandardOutput = True
            winscp.StartInfo.CreateNoWindow = True
            winscp.Start()


        Catch ek As Exception
            Console.WriteLine((ek.Message))
        End Try
        winscp.StandardInput.WriteLine("option batch abort")
        winscp.StandardInput.WriteLine("option confirm off")
        id = Textid.Text
        psw = Textpass.Text
        ip = Textip.Text
        port = Textport.Text
        Dim lines As String
        lines = "open sftp://" + id + ":" + psw + "@" + ip + ":" + port
        winscp.StandardInput.WriteLine(lines)

        Dim cmd As String = "call sudo reboot"
        winscp.StandardInput.WriteLine(cmd)
        winscp.StandardInput.Close()

    End Sub
End Class
