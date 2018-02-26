Imports System.Xml


Public Class PiPo_Data
    Public bildname As String
    Dim spielts As Boolean = False

    Private Sub Button_save_Click(sender As Object, e As EventArgs)
        'writes back changed data in array and XML file
        'PiPo.PiPo_first_Screen.textfield(1) = TextBox1.Text
        'PiPo.PiPo_first_Screen.textfield(2) = TextBox2.Text
        'PiPo.PiPo_first_Screen.textfield(3) = TextBox3.Text
        'PiPo.PiPo_first_Screen.textfield(4) = TextBox4.Text
        'PiPo.PiPo_first_Screen.textfield(5) = TextBox5.Text
        'PiPo.PiPo_first_Screen.textfield(6) = TextBox6.Text
        'PiPo.PiPo_first_Screen.textfield(7) = TextBox7.Text
        'PiPo.PiPo_first_Screen.textfield(8) = TextBox8.Text
        'PiPo.PiPo_first_Screen.textfield(9) = TextBox9.Text
        'PiPo.PiPo_first_Screen.textfield(10) = TextBox10.Text
        PiPo_first_Screen.Write_Init()
        PiPo_first_Screen.set_labels()
        Me.Hide()
    End Sub

    Private Sub Button_cancel_Click(sender As Object, e As EventArgs) Handles Button_cancel.Click
        PiPo.PiPo_first_Screen.textfield(8) = TextBox8.Text
        PiPo_first_Screen.Write_Init()
        PiPo_first_Screen.set_labels()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Hintergrundbild festlegen
        OpenFileDialog1.Filter = "Alle Dateien (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim filename_background As String = OpenFileDialog1.FileName
            bildname = OpenFileDialog1.FileName
        End If
        'saves background to file SMS_Background in Caspar Server directory
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield11", bild3.Text)
    End Sub

    Sub update_data(filename_update, node, updated_data)
        'sub, receives filename, number of dataset, value to change, saves a specific XML dataset back
        If Trim(updated_data) = "" Then updated_data = "not used"
        Dim MyXML As New XmlDocument()
        Dim MyXMLNode As XmlNode
        MyXML.Load(filename_update)
        MyXMLNode = MyXML.SelectSingleNode(node)
        If MyXMLNode IsNot Nothing Then
            MyXMLNode.ChildNodes(0).InnerText = updated_data
            MyXML.Save(filename_update)
        Else
            MessageBox.Show("update Fehler")
        End If ' Save the Xml.
    End Sub

    Private Sub PiPo_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub openfiledialog()
        bildname = "not used"
        'Hintergrundbild festlegen
        OpenFileDialog1.Filter = "Alle Dateien (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim filename_background As String = OpenFileDialog1.FileName
            bildname = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub bild1_Click(sender As Object, e As EventArgs) Handles bild1.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild1.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield11", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield11", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild2_Click(sender As Object, e As EventArgs) Handles bild2.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild2.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield12", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield12", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild3_Click(sender As Object, e As EventArgs) Handles bild3.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild3.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield13", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield13", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild4_Click(sender As Object, e As EventArgs) Handles bild4.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild4.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield14", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield14", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild5_Click(sender As Object, e As EventArgs) Handles bild5.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild5.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield15", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield15", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild6_Click(sender As Object, e As EventArgs) Handles bild6.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild6.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield16", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield16", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild7_Click(sender As Object, e As EventArgs) Handles bild7.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild7.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield17", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield17", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild8_Click(sender As Object, e As EventArgs) Handles bild8.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild8.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield18", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield18", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild9_Click(sender As Object, e As EventArgs) Handles bild9.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild9.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield19", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield19", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub bild10_Click(sender As Object, e As EventArgs) Handles bild10.Click
        'Hintergrundbild festlegen
        openfiledialog()
        If bildname = "not used" Then 'falls openfiledialog abgebrochen wird
            bild10.Text = bildname
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield20", bildname)
            PiPo_first_Screen.Read_Init()
        Else 'sonst neues bild einpflegen
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield20", bildname)
            PiPo_first_Screen.Read_Init()
        End If
    End Sub

    Private Sub Button_clear_all_Click(sender As Object, e As EventArgs) Handles Button_clear_all.Click
        For i = 11 To 20
            bildname = "not used"
            update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield" + Trim(Str(i)), bildname)
        Next
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub Button_colorbars75_Click(sender As Object, e As EventArgs) Handles Button_colorbars75.Click
        PiPo_first_Screen.all_labels_invisible()
        PiPo_second_Screen.PictureBox1.Image = New System.Drawing.Bitmap(My.Resources.Colourbars_75)
        PiPo_second_Screen.PictureBox1.BorderStyle = BorderStyle.None ' hide picturebox border
        PiPo_second_Screen.PictureBox1.Dock = DockStyle.Fill
        PiPo_second_Screen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PiPo_second_Screen.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button_colors_Click(sender As Object, e As EventArgs) Handles Button_colors.Click
        PiPo_first_Screen.all_labels_invisible()
        PiPo_second_Screen.PictureBox1.Image = New System.Drawing.Bitmap(My.Resources.Color)
        PiPo_second_Screen.PictureBox1.BorderStyle = BorderStyle.None ' hide picturebox border
        PiPo_second_Screen.PictureBox1.Dock = DockStyle.Fill
        PiPo_second_Screen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PiPo_second_Screen.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button_testchart_Click(sender As Object, e As EventArgs) Handles Button_testchart.Click
        PiPo_first_Screen.all_labels_invisible()
        PiPo_second_Screen.PictureBox1.Image = New System.Drawing.Bitmap(My.Resources.testbild_HD)
        PiPo_second_Screen.PictureBox1.BorderStyle = BorderStyle.None ' hide picturebox border
        PiPo_second_Screen.PictureBox1.Dock = DockStyle.Fill
        PiPo_second_Screen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PiPo_second_Screen.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button_colorbars_time_Click(sender As Object, e As EventArgs) Handles Button_colorbars_time.Click
        PiPo_first_Screen.all_labels_invisible()
        PiPo_first_Screen.Timer1.Start()
        PiPo_second_Screen.Label_room.BringToFront()
        PiPo_second_Screen.label_date.BringToFront()
        PiPo_second_Screen.label_time.BringToFront()
        PiPo_second_Screen.Label_room.Text = PiPo_first_Screen.textfield(8)
        PiPo_second_Screen.Label_room.Location = New Point(640, 520)
        PiPo_second_Screen.Label_room.ForeColor = Drawing.Color.Black
        PiPo_second_Screen.Label_room.TextAlign = ContentAlignment.TopCenter
        PiPo_second_Screen.label_time.Location = New Point(640, 610)
        PiPo_second_Screen.label_time.ForeColor = Drawing.Color.Black
        PiPo_second_Screen.label_time.TextAlign = ContentAlignment.TopCenter
        PiPo_second_Screen.label_date.Location = New Point(640, 660)
        PiPo_second_Screen.label_date.ForeColor = Drawing.Color.Black
        PiPo_second_Screen.label_date.TextAlign = ContentAlignment.TopCenter
        PiPo_second_Screen.PictureBox1.SendToBack()
        PiPo_second_Screen.PictureBox1.Image = New System.Drawing.Bitmap(My.Resources.testbild_HD)
        PiPo_second_Screen.PictureBox1.BorderStyle = BorderStyle.None ' hide picturebox border
        PiPo_second_Screen.PictureBox1.Dock = DockStyle.Fill
        PiPo_second_Screen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PiPo_second_Screen.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button_sharpnes_Click(sender As Object, e As EventArgs) Handles Button_sharpnes.Click
        PiPo_first_Screen.all_labels_invisible()
        PiPo_second_Screen.PictureBox1.Image = New System.Drawing.Bitmap(My.Resources.Focus_Beamer)
        PiPo_second_Screen.PictureBox1.BorderStyle = BorderStyle.None ' hide picturebox border
        PiPo_second_Screen.PictureBox1.Dock = DockStyle.Fill
        PiPo_second_Screen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PiPo_second_Screen.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bild1_clear_Click(sender As Object, e As EventArgs) Handles bild1_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield11", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild2_clear_Click(sender As Object, e As EventArgs) Handles bild2_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield12", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild3_clear_Click(sender As Object, e As EventArgs) Handles bild3_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield13", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild4_clear_Click(sender As Object, e As EventArgs) Handles bild4_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield14", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild5_clear_Click(sender As Object, e As EventArgs) Handles bild5_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield15", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild6_clear_Click(sender As Object, e As EventArgs) Handles bild6_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield16", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild7_clear_Click(sender As Object, e As EventArgs) Handles bild7_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield17", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild8_clear_Click(sender As Object, e As EventArgs) Handles bild8_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield18", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild9_clear_Click(sender As Object, e As EventArgs) Handles bild9_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield19", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub bild10_clear_Click(sender As Object, e As EventArgs) Handles bild10_clear.Click
        bildname = "not used"
        update_data(PiPo_first_Screen.filename, "Data/PiPo/textfield20", bildname)
        PiPo_first_Screen.Read_Init()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If spielts = False Then
            My.Computer.Audio.Play(My.Resources._1kHz__30sec, AudioPlayMode.Background)
            spielts = True
        Else
            spielts = False
            My.Computer.Audio.Stop()
        End If
    End Sub

End Class