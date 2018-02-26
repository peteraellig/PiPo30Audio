<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PiPo_first_Screen
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
        Me.components = New System.ComponentModel.Container()
        Me.Button_save_data = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button_END = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Button_bild1 = New System.Windows.Forms.Button()
        Me.Button_bild2 = New System.Windows.Forms.Button()
        Me.Button_bild3 = New System.Windows.Forms.Button()
        Me.Button_bild4 = New System.Windows.Forms.Button()
        Me.Button_bild5 = New System.Windows.Forms.Button()
        Me.Button_bild6 = New System.Windows.Forms.Button()
        Me.Button_bild7 = New System.Windows.Forms.Button()
        Me.Button_bild8 = New System.Windows.Forms.Button()
        Me.Button_bild9 = New System.Windows.Forms.Button()
        Me.Button_bild10 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_save_data
        '
        Me.Button_save_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_save_data.FlatAppearance.BorderSize = 0
        Me.Button_save_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_save_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_save_data.ForeColor = System.Drawing.Color.White
        Me.Button_save_data.Location = New System.Drawing.Point(465, 10)
        Me.Button_save_data.Name = "Button_save_data"
        Me.Button_save_data.Size = New System.Drawing.Size(161, 113)
        Me.Button_save_data.TabIndex = 2
        Me.Button_save_data.Text = "change Data"
        Me.Button_save_data.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button_END
        '
        Me.Button_END.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_END.FlatAppearance.BorderSize = 0
        Me.Button_END.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_END.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_END.ForeColor = System.Drawing.Color.OrangeRed
        Me.Button_END.Location = New System.Drawing.Point(685, 12)
        Me.Button_END.Name = "Button_END"
        Me.Button_END.Size = New System.Drawing.Size(159, 111)
        Me.Button_END.TabIndex = 11
        Me.Button_END.Text = "END"
        Me.Button_END.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.Control
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(62, 92)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(235, 18)
        Me.Label40.TabIndex = 16
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.PiPo.My.Resources.Resources.drop
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 183)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label100
        '
        Me.Label100.BackColor = System.Drawing.Color.Black
        Me.Label100.ForeColor = System.Drawing.Color.DimGray
        Me.Label100.Location = New System.Drawing.Point(29, 198)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(328, 18)
        Me.Label100.TabIndex = 17
        Me.Label100.Text = "drag and drop 16:9 image here and display immediately"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_bild1
        '
        Me.Button_bild1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild1.FlatAppearance.BorderSize = 0
        Me.Button_bild1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild1.ForeColor = System.Drawing.Color.Black
        Me.Button_bild1.Location = New System.Drawing.Point(17, 296)
        Me.Button_bild1.Name = "Button_bild1"
        Me.Button_bild1.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild1.TabIndex = 18
        Me.Button_bild1.UseVisualStyleBackColor = False
        '
        'Button_bild2
        '
        Me.Button_bild2.AutoSize = True
        Me.Button_bild2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild2.FlatAppearance.BorderSize = 0
        Me.Button_bild2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild2.ForeColor = System.Drawing.Color.Black
        Me.Button_bild2.Location = New System.Drawing.Point(184, 296)
        Me.Button_bild2.Name = "Button_bild2"
        Me.Button_bild2.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild2.TabIndex = 19
        Me.Button_bild2.UseVisualStyleBackColor = False
        '
        'Button_bild3
        '
        Me.Button_bild3.AutoSize = True
        Me.Button_bild3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild3.FlatAppearance.BorderSize = 0
        Me.Button_bild3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild3.ForeColor = System.Drawing.Color.Black
        Me.Button_bild3.Location = New System.Drawing.Point(351, 296)
        Me.Button_bild3.Name = "Button_bild3"
        Me.Button_bild3.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild3.TabIndex = 20
        Me.Button_bild3.UseVisualStyleBackColor = False
        '
        'Button_bild4
        '
        Me.Button_bild4.AutoSize = True
        Me.Button_bild4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild4.FlatAppearance.BorderSize = 0
        Me.Button_bild4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild4.ForeColor = System.Drawing.Color.Black
        Me.Button_bild4.Location = New System.Drawing.Point(518, 295)
        Me.Button_bild4.Name = "Button_bild4"
        Me.Button_bild4.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild4.TabIndex = 21
        Me.Button_bild4.UseVisualStyleBackColor = False
        '
        'Button_bild5
        '
        Me.Button_bild5.AutoSize = True
        Me.Button_bild5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild5.FlatAppearance.BorderSize = 0
        Me.Button_bild5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild5.ForeColor = System.Drawing.Color.Black
        Me.Button_bild5.Location = New System.Drawing.Point(685, 295)
        Me.Button_bild5.Name = "Button_bild5"
        Me.Button_bild5.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild5.TabIndex = 22
        Me.Button_bild5.UseVisualStyleBackColor = False
        '
        'Button_bild6
        '
        Me.Button_bild6.AutoSize = True
        Me.Button_bild6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild6.FlatAppearance.BorderSize = 0
        Me.Button_bild6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild6.ForeColor = System.Drawing.Color.Black
        Me.Button_bild6.Location = New System.Drawing.Point(16, 443)
        Me.Button_bild6.Name = "Button_bild6"
        Me.Button_bild6.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild6.TabIndex = 23
        Me.Button_bild6.UseVisualStyleBackColor = False
        '
        'Button_bild7
        '
        Me.Button_bild7.AutoSize = True
        Me.Button_bild7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild7.FlatAppearance.BorderSize = 0
        Me.Button_bild7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild7.ForeColor = System.Drawing.Color.Black
        Me.Button_bild7.Location = New System.Drawing.Point(184, 443)
        Me.Button_bild7.Name = "Button_bild7"
        Me.Button_bild7.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild7.TabIndex = 24
        Me.Button_bild7.UseVisualStyleBackColor = False
        '
        'Button_bild8
        '
        Me.Button_bild8.AutoSize = True
        Me.Button_bild8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild8.FlatAppearance.BorderSize = 0
        Me.Button_bild8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild8.ForeColor = System.Drawing.Color.Black
        Me.Button_bild8.Location = New System.Drawing.Point(351, 443)
        Me.Button_bild8.Name = "Button_bild8"
        Me.Button_bild8.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild8.TabIndex = 25
        Me.Button_bild8.UseVisualStyleBackColor = False
        '
        'Button_bild9
        '
        Me.Button_bild9.AutoSize = True
        Me.Button_bild9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild9.FlatAppearance.BorderSize = 0
        Me.Button_bild9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild9.ForeColor = System.Drawing.Color.Black
        Me.Button_bild9.Location = New System.Drawing.Point(518, 443)
        Me.Button_bild9.Name = "Button_bild9"
        Me.Button_bild9.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild9.TabIndex = 26
        Me.Button_bild9.UseVisualStyleBackColor = False
        '
        'Button_bild10
        '
        Me.Button_bild10.AutoSize = True
        Me.Button_bild10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_bild10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_bild10.FlatAppearance.BorderSize = 0
        Me.Button_bild10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bild10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bild10.ForeColor = System.Drawing.Color.Black
        Me.Button_bild10.Location = New System.Drawing.Point(685, 443)
        Me.Button_bild10.Name = "Button_bild10"
        Me.Button_bild10.Size = New System.Drawing.Size(161, 111)
        Me.Button_bild10.TabIndex = 27
        Me.Button_bild10.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(184, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(355, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(687, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 23)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(20, 418)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(184, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 23)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(352, 418)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(514, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 23)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(692, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 23)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(17, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(515, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 23)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(462, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(272, 23)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(462, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(272, 23)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Label12"
        '
        'PiPo_first_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(857, 566)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button_bild10)
        Me.Controls.Add(Me.Button_bild9)
        Me.Controls.Add(Me.Button_bild8)
        Me.Controls.Add(Me.Button_bild7)
        Me.Controls.Add(Me.Button_bild6)
        Me.Controls.Add(Me.Button_bild5)
        Me.Controls.Add(Me.Button_bild4)
        Me.Controls.Add(Me.Button_bild3)
        Me.Controls.Add(Me.Button_bild2)
        Me.Controls.Add(Me.Button_bild1)
        Me.Controls.Add(Me.Label100)
        Me.Controls.Add(Me.Button_END)
        Me.Controls.Add(Me.Button_save_data)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.KeyPreview = True
        Me.Name = "PiPo_first_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PiPo WEF"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_save_data As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button_END As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Button_bild1 As Button
    Friend WithEvents Button_bild2 As Button
    Friend WithEvents Button_bild3 As Button
    Friend WithEvents Button_bild4 As Button
    Friend WithEvents Button_bild5 As Button
    Friend WithEvents Button_bild6 As Button
    Friend WithEvents Button_bild7 As Button
    Friend WithEvents Button_bild8 As Button
    Friend WithEvents Button_bild9 As Button
    Friend WithEvents Button_bild10 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
