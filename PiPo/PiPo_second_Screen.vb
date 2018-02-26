Public Class PiPo_second_Screen
    Private Sub PiPo_second_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_text1.Parent = PictureBox1
        label_text2.Parent = PictureBox1
        Label_room.Parent = PictureBox1
        label_feed.Parent = PictureBox1
        label_date.Parent = PictureBox1
        label_time.Parent = PictureBox1
    End Sub
End Class