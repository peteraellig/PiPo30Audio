'Imports Casparobjects
Imports System.Globalization
Imports System.Threading
Imports System.Xml
Imports System.IO


Public Class PiPo_first_Screen
    'Private _Caspar As CasparCG = New CasparCG()

    Private toggle As Boolean = False
    Private myColor As Color
    Private webbrowserLocation1 As Point
    Private webbrowserLocation2 As Point

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    Public numberofmonitors As Integer = Screen.AllScreens.Length
    Dim time As DateTime = DateTime.Now
    Dim format As String = "HH:mm:ss"
    Dim uhrläuft As Integer

    'variables for xml init file
    Public channel(10) As String
    Public textfield(100) As String
    Public numfield(100) As Single
    Public color(100) As String
    Public checked(100) As Boolean

    Public kanal As Integer

    'variable for filename of the initial settings (ip, color, channel)
    Public Shared filename As String = "C:\PiPo\PiPo_Data.xml"
    Public directory As String = "C:\PiPo"

    'variables for caspar ip and channels
    Public IP As String = "localhost"

    'variables if caspar is connected and caspar ip and variable to clearscreen the "kanal"-channel
    Public connected As Integer = 0
    Public bildname As String = "not used"



    Private Sub PiPo_first_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.AllowDrop = True
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        If numberofmonitors > 1 Then PiPo_second_Screen.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        If numberofmonitors > 1 Then show_form2_on_secondscreen()
        screen2res()
        'set date time to english
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")

        'set date time to german
        'Thread.CurrentThread.CurrentCulture = New CultureInfo("de-CH")

        'set default values to all variables
        fill_xlm_variables()

        'read XML file
        Read_Init()

        If numberofmonitors > 1 Then show_form2_on_secondscreen()

        Me.ShowIcon = True
        Me.Icon = My.Resources.touch
        Me.Text = My.Application.Info.Title & " " & My.Application.Info.Version.ToString + " - " & My.Application.Info.Description

        If Label12.Text = "" Then
            Label40.Text = "no second monitor found, end program"
            wait(2)
            End
        End If

    End Sub

    Sub fill_xlm_variables()
        'could not find another way as filling all variables with empty values, to avoid errors, replacing data with empty fields
        For i = 1 To 10
            channel(i) = "not used"
        Next
        For i = 1 To 100
            textfield(i) = "not used"
            numfield(i) = 0
            color(i) = "not used"
            checked(i) = False
        Next

    End Sub

    Sub Read_Init()
        ' checks directory
        If (Not System.IO.Directory.Exists(directory)) Then
            System.IO.Directory.CreateDirectory(directory)
        End If

        'if file not exits, create empty file
        If (Not System.IO.File.Exists(filename)) Then
            My.Computer.FileSystem.WriteAllText(filename, " ", True)
            IP = "localhost"
            channel(1) = "1"
            'System.Windows.Forms.MessageBox.Show("No Record has been Found")
            Write_Init()
        End If

        'fills all variables textfield out of Datafile
        Try
            Dim Contactlist As XDocument = XDocument.Load(filename)

            For Each contact As XElement In Contactlist...<PiPo>
                IP = contact.Element("IP")
                For i = 1 To 10
                    channel(i) = contact.Element("channel" + Trim(i))
                Next

                For i = 1 To 100
                    textfield(i) = (contact.Element("textfield" + Trim(i)))
                    numfield(i) = contact.Element("numfield" + Trim(i))
                    color(i) = contact.Element("color" + Trim(i))
                    checked(i) = contact.Element("checked" + Trim(i))
                Next
            Next
        Catch ex As System.IO.IOException
            MessageBox.Show("File nicht vorhanden")
        Catch ex As NullReferenceException
            MessageBox.Show("NullReferenceException: " & ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        Catch ex As Exception
        End Try

        For i = 1 To 10
            If textfield(i) = "not used" Then textfield(i) = ""
        Next

        set_labels()
    End Sub

    Sub set_labels()

        'text for testchart
        PiPo.PiPo_Data.TextBox8.Text = textfield(8)

        PiPo.PiPo_Data.bild1.Text = textfield(11) ' image 1 
        PiPo.PiPo_Data.bild2.Text = textfield(12) ' image 2....
        PiPo.PiPo_Data.bild3.Text = textfield(13)
        PiPo.PiPo_Data.bild4.Text = textfield(14)
        PiPo.PiPo_Data.bild5.Text = textfield(15)
        PiPo.PiPo_Data.bild6.Text = textfield(16)
        PiPo.PiPo_Data.bild7.Text = textfield(17)
        PiPo.PiPo_Data.bild8.Text = textfield(18)
        PiPo.PiPo_Data.bild9.Text = textfield(19)
        PiPo.PiPo_Data.bild10.Text = textfield(20)

        For i = 1 To 10
            If Trim(textfield(i + 10)) = "not used" Then
                Controls.Item("Button_bild" & i).BackgroundImage = Nothing
                Controls.Item("Label" & i).Text = "not used"
            Else
                Try
                    Controls.Item("Button_bild" & i).BackgroundImage = Image.FromFile(textfield(i + 10))
                    'PiPo_Data.Controls.Item("Bild" + Trim(Str(i)) + "_clear").BackgroundImage = Image.FromFile(textfield(i + 10))
                    Dim FileInfo As New FileInfo(textfield(i + 10))
                    Controls.Item("Button_bild" & i).Text = ""
                    Controls.Item("Label" & i).Text = (FileInfo.Name)
                Catch ex As System.IO.IOException
                    Controls.Item("Button_bild" & i).Text = "file missing"
                    Controls.Item("Label" & i).Text = "file missing"
                End Try
            End If

        Next

    End Sub

    Sub Write_Init()
        Dim settings As New XmlWriterSettings()
        settings.Indent = True
        ' Initialize the XmlWriter.
        Dim XmlWrt As XmlWriter = XmlWriter.Create(filename, settings)
        With XmlWrt
            ' Write the Xml declaration.
            .WriteStartDocument()
            ' Write a comment.
            .WriteComment("XML Database.")
            ' Write the root element.
            .WriteStartElement("Data")
            ' Start Caspar Dataset
            .WriteStartElement("PiPo")

            .WriteComment("IP for Caspar Server")
            .WriteStartElement("IP")
            .WriteString(IP.ToString())
            .WriteEndElement()

            .WriteComment("Channel Numbers for 10 Channels")
            For i = 1 To 10
                .WriteStartElement("channel" + Trim(Str(i)))
                .WriteString(channel(i).ToString())
                .WriteEndElement()
            Next
            .WriteComment("Numbers (for example buttons, names etc.")
            For i = 1 To 100
                If Trim(textfield(i)) = "" Then textfield(i) = "not used"
                .WriteStartElement("textfield" + Trim(Str(i)))
                .WriteString(textfield(i).ToString())
                .WriteEndElement()
            Next
            .WriteComment("Numbers (for example xy-pos etc.")
            For i = 1 To 100
                .WriteStartElement("numfield" + Trim(Str(i)))
                .WriteString(numfield(i).ToString())
                .WriteEndElement()
            Next
            .WriteComment("colors (for example buttons, fonts etc.) ")
            For i = 1 To 100
                .WriteStartElement("color" + Trim(Str(i)))
                .WriteString(color(i).ToString())
                .WriteEndElement()
            Next
            .WriteComment("Boolean (for example checkbox=true etc.) ")
            For i = 1 To 100
                .WriteStartElement("checked" + Trim(Str(i)))
                .WriteString(checked(i).ToString())
                .WriteEndElement()
            Next
            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()
        End With
    End Sub

    Sub show_form2_on_secondscreen()
        Dim screen As Screen
        'Show the form on second screen
        screen = Screen.AllScreens(1)
        PiPo_second_Screen.StartPosition = FormStartPosition.Manual
        PiPo_second_Screen.Location = screen.Bounds.Location + New Point(0, 0)
        PiPo_second_Screen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PiPo_second_Screen.WindowState = FormWindowState.Maximized
        PiPo_second_Screen.Show()
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'shows daytime on Label Daytime
        time = DateTime.Now
        PiPo_second_Screen.label_time.Text = (time.ToString(format))
        PiPo_second_Screen.label_date.Text = Now.ToString("ddd. dd. MMM.")
    End Sub

    Private Sub Button_save_data_Click(sender As Object, e As EventArgs) Handles Button_save_data.Click
        PiPo.PiPo_Data.Show()
    End Sub

    Sub all_labels_invisible()
        Timer1.Stop()
        PiPo_second_Screen.label_text1.Text = ""
        PiPo_second_Screen.label_text2.Text = ""
        PiPo_second_Screen.Label_room.Text = ""
        PiPo_second_Screen.label_feed.Text = ""
        PiPo_second_Screen.label_time.Text = ""
        PiPo_second_Screen.label_date.Text = ""
    End Sub

    Sub set_labels_original()
        'sets room time/date back to original position, if moved to middle after clicking testchart time
        PiPo_second_Screen.Label_room.Location = New Point(18, 38)
        PiPo_second_Screen.Label_room.ForeColor = Drawing.Color.LightGray
        PiPo_second_Screen.Label_room.TextAlign = ContentAlignment.TopLeft
        PiPo_second_Screen.label_time.Location = New Point(18, 164)
        PiPo_second_Screen.label_time.ForeColor = Drawing.Color.LightGray
        PiPo_second_Screen.label_time.TextAlign = ContentAlignment.TopLeft
        PiPo_second_Screen.label_date.Location = New Point(25, 215)
        PiPo_second_Screen.label_date.ForeColor = Drawing.Color.LightGray
        PiPo_second_Screen.label_date.TextAlign = ContentAlignment.TopLeft
    End Sub

    Private Sub PictureBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragDrop
        Try
            'shows image on second screen
            all_labels_invisible()
            PictureBox1.Image = Image.FromFile(CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString)
            If numberofmonitors > 1 Then PiPo_second_Screen.PictureBox1.Image = Image.FromFile(CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString)
            PiPo_second_Screen.PictureBox1.Visible = True
        Catch ex As Exception
            'warning if wrong image format
            Me.Label40.Visible = True
            Me.Label40.BringToFront()
            Me.PictureBox1.Image = My.Resources.achtung
            Me.Label40.Text = "nur JPG, PNG oder TIF erlaubt"
            wait(2)
            Me.Label40.Visible = False
            Me.PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub PictureBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragEnter
        e.Effect = DragDropEffects.Copy
        PiPo_second_Screen.PictureBox1.BorderStyle = BorderStyle.None ' hide picturebox border
        PiPo_second_Screen.PictureBox1.Dock = DockStyle.Fill
        PiPo_second_Screen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PiPo_second_Screen.WindowState = FormWindowState.Maximized
        PiPo_second_Screen.PictureBox1.BringToFront()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Nothing
        PiPo_second_Screen.PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild1_Click(sender As Object, e As EventArgs) Handles Button_bild1.Click
        If Trim(Label1.Text) <> "not used" Then
            show_picture(PiPo_Data.bild1.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild2_Click(sender As Object, e As EventArgs) Handles Button_bild2.Click
        If Trim(Label2.Text) <> "not used" Then
            show_picture(PiPo_Data.bild2.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild3_Click(sender As Object, e As EventArgs) Handles Button_bild3.Click
        If Trim(Label3.Text) <> "not used" Then
            show_picture(PiPo_Data.bild3.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild4_Click(sender As Object, e As EventArgs) Handles Button_bild4.Click
        If Trim(Label4.Text) <> "not used" Then
            show_picture(PiPo_Data.bild4.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild5_Click(sender As Object, e As EventArgs) Handles Button_bild5.Click
        If Trim(Label5.Text) <> "not used" Then
            show_picture(PiPo_Data.bild5.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild6_Click(sender As Object, e As EventArgs) Handles Button_bild6.Click
        If Trim(Label6.Text) <> "not used" Then
            show_picture(PiPo_Data.bild6.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild7_Click(sender As Object, e As EventArgs) Handles Button_bild7.Click
        If Trim(Label7.Text) <> "not used" Then
            show_picture(PiPo_Data.bild7.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild8_Click(sender As Object, e As EventArgs) Handles Button_bild8.Click
        If Trim(Label8.Text) <> "not used" Then
            show_picture(PiPo_Data.bild8.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild9_Click(sender As Object, e As EventArgs) Handles Button_bild9.Click
        If Trim(Label9.Text) <> "not used" Then
            show_picture(PiPo_Data.bild9.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button_bild10_Click(sender As Object, e As EventArgs) Handles Button_bild10.Click
        If Trim(Label10.Text) <> "not used" Then
            show_picture(PiPo_Data.bild10.Text)
        Else
            PiPo.PiPo_Data.Show()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Sub show_picture(bild)
        all_labels_invisible()
        PiPo_second_Screen.PictureBox1.ImageLocation = bild
        PiPo_second_Screen.PictureBox1.Load()
        PiPo_second_Screen.PictureBox1.Visible = True
        PiPo_second_Screen.PictureBox1.BorderStyle = BorderStyle.None ' hide picturebox border
        PiPo_second_Screen.PictureBox1.Dock = DockStyle.Fill
        PiPo_second_Screen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PiPo_second_Screen.WindowState = FormWindowState.Maximized
        PiPo_second_Screen.PictureBox1.BringToFront()
    End Sub

    Private Sub Button_END_Click(sender As Object, e As EventArgs) Handles Button_END.Click
        If MessageBox.Show("Programm wirklich beenden ?", "EXIT", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then Application.Exit()
    End Sub

    Sub screen2res()
        Dim screen As Screen
        screen = Screen.AllScreens(0)

        Dim x = screen.Bounds.Width
        Dim y = screen.Bounds.Height
        If numberofmonitors > 1 Then Label11.Text = "Auflösung Monitor1 " + Str(x) + " x " + Str(y)
        If numberofmonitors = 1 Then Label11.Text = ""

        'Show the form on second screen
        screen = Screen.AllScreens(1)

        x = screen.Bounds.Width
        y = screen.Bounds.Height
        If numberofmonitors > 1 Then Label12.Text = "Auflösung Monitor2 " + Str(x) + " x " + Str(y)
        If numberofmonitors = 1 Then Label12.Text = ""
    End Sub

End Class
