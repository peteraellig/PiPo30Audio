<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PiPo_second_Screen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label_room = New System.Windows.Forms.Label()
        Me.label_feed = New System.Windows.Forms.Label()
        Me.label_time = New System.Windows.Forms.Label()
        Me.label_date = New System.Windows.Forms.Label()
        Me.label_text2 = New System.Windows.Forms.Label()
        Me.label_text1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_room
        '
        Me.Label_room.BackColor = System.Drawing.Color.Transparent
        Me.Label_room.Font = New System.Drawing.Font("Open Sans", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_room.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label_room.Location = New System.Drawing.Point(16, 26)
        Me.Label_room.Name = "Label_room"
        Me.Label_room.Size = New System.Drawing.Size(645, 69)
        Me.Label_room.TabIndex = 10
        Me.Label_room.Text = "Sanada"
        '
        'label_feed
        '
        Me.label_feed.BackColor = System.Drawing.Color.Transparent
        Me.label_feed.Font = New System.Drawing.Font("Open Sans", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_feed.ForeColor = System.Drawing.Color.Gainsboro
        Me.label_feed.Location = New System.Drawing.Point(18, 95)
        Me.label_feed.Name = "label_feed"
        Me.label_feed.Size = New System.Drawing.Size(643, 50)
        Me.label_feed.TabIndex = 11
        Me.label_feed.Text = "feed 2"
        '
        'label_time
        '
        Me.label_time.BackColor = System.Drawing.Color.Transparent
        Me.label_time.Font = New System.Drawing.Font("Open Sans Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_time.ForeColor = System.Drawing.Color.Gainsboro
        Me.label_time.Location = New System.Drawing.Point(18, 162)
        Me.label_time.Name = "label_time"
        Me.label_time.Size = New System.Drawing.Size(643, 50)
        Me.label_time.TabIndex = 12
        Me.label_time.Text = "time"
        '
        'label_date
        '
        Me.label_date.BackColor = System.Drawing.Color.Transparent
        Me.label_date.Font = New System.Drawing.Font("Open Sans Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_date.ForeColor = System.Drawing.Color.Gainsboro
        Me.label_date.Location = New System.Drawing.Point(26, 212)
        Me.label_date.Name = "label_date"
        Me.label_date.Size = New System.Drawing.Size(636, 50)
        Me.label_date.TabIndex = 13
        Me.label_date.Text = "date"
        '
        'label_text2
        '
        Me.label_text2.BackColor = System.Drawing.Color.Transparent
        Me.label_text2.Font = New System.Drawing.Font("Open Sans Light", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_text2.ForeColor = System.Drawing.Color.Gainsboro
        Me.label_text2.Location = New System.Drawing.Point(14, 698)
        Me.label_text2.Name = "label_text2"
        Me.label_text2.Size = New System.Drawing.Size(1896, 94)
        Me.label_text2.TabIndex = 14
        Me.label_text2.Text = "text2"
        Me.label_text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_text1
        '
        Me.label_text1.BackColor = System.Drawing.Color.Transparent
        Me.label_text1.Font = New System.Drawing.Font("Open Sans Light", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_text1.ForeColor = System.Drawing.Color.Gainsboro
        Me.label_text1.Location = New System.Drawing.Point(10, 520)
        Me.label_text1.Name = "label_text1"
        Me.label_text1.Size = New System.Drawing.Size(1896, 135)
        Me.label_text1.TabIndex = 9
        Me.label_text1.Text = "text1"
        Me.label_text1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(882, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PiPo_second_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.label_date)
        Me.Controls.Add(Me.label_time)
        Me.Controls.Add(Me.label_feed)
        Me.Controls.Add(Me.Label_room)
        Me.Controls.Add(Me.label_text2)
        Me.Controls.Add(Me.label_text1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "PiPo_second_Screen"
        Me.Text = "PiPo_second_Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_room As Label
    Friend WithEvents label_feed As Label
    Friend WithEvents label_time As Label
    Friend WithEvents label_date As Label
    Friend WithEvents label_text2 As Label
    Friend WithEvents label_text1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
