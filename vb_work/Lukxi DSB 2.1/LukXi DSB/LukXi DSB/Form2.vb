Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim add As New Adresslist

        'Form1 Größe festlegen
        Me.Size = New Size(1920, 1080)
        Me.Location = New Point(0, 0)

        'Hintergund laden
        'PicBack.Location = New Point(0, 0)
        'PicBack.Size = New Size(1920, 1080)

        'PicBack.ImageLocation = Form1.addrMask
        'PicBack.Load()

        'Bild laden
        PicMed.BackColor = Color.Transparent
        PicMed.BackgroundImage = Nothing
        PicMed.SizeMode = PictureBoxSizeMode.AutoSize
        PicMed.Location = New Point(0, 0)

        PicMed.ImageLocation = add.getRelativPath("meF") & Form1.mediaArray(Form1.nMedia)
        PicMed.Load()

        Me.Size = New Size(PicMed.Width, PicMed.Height)
        Me.Location = New Point(1920 / 2 - (Me.Width / 2), 1080 / 2 - (Me.Height / 2))

        'nMedia hochzählen
        Form1.nMedia += 1
        If Form1.nMedia > Form1.mediaArray.Length - 1 Then
            Form1.nMedia = 0
        End If

        'Timer einstellen
        Timer1.Interval = Form1.config(6)
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form1.TimForm2.Enabled = True
        Me.Close()
    End Sub
End Class