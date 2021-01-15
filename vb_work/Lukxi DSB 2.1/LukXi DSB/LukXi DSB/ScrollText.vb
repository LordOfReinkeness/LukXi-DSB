Public Class ScrollText

    Private spacerScroll As Integer
    Private heightScroll As Integer

    Public Sub New(s As Integer, h As Integer)

        'Konstruktor für die Höhe des Scrolltextes und den Abstand zwischen den einzelnen Versionen
        spacerScroll = s
        heightScroll = h

    End Sub

    Public Sub Generate(f As String, s As Single, int As String)    'Argument: Adresse der Datei

        'Schreibt den den Text aus der Textdatei in drei Labels
        Form1.LblScroll1.Text = Form1.ScrollText
        Form1.LblScroll1.Location = New Point(20, heightScroll)
        Form1.LblScroll1.Font = New Font(f, s, FontStyle.Bold)
        Form1.LblScroll2.Text = Form1.LblScroll1.Text
        Form1.LblScroll2.Location = New Point(Form1.LblScroll1.Location.X + Form1.LblScroll1.Width + spacerScroll, heightScroll)
        Form1.LblScroll2.Font = New Font(f, s, FontStyle.Bold)
        Form1.LblScroll3.Text = Form1.LblScroll1.Text
        Form1.LblScroll3.Location = New Point(Form1.LblScroll2.Location.X + Form1.LblScroll2.Width + spacerScroll, heightScroll)
        Form1.LblScroll3.Font = New Font(f, s, FontStyle.Bold)

        'Geschwindigkeit laden
        Form1.TimScroll.Interval = int

    End Sub

    Public Sub Move()       'Argumnet: Pixel Bewegung pro tick

        'Bewegt alle drei Scrolltexte
        Form1.LblScroll1.Location = New Point(Form1.LblScroll1.Location.X - 1, heightScroll)
        Form1.LblScroll2.Location = New Point(Form1.LblScroll2.Location.X - 1, heightScroll)
        Form1.LblScroll3.Location = New Point(Form1.LblScroll3.Location.X - 1, heightScroll)

        'Zurücksetzen der Scrolltexte, wenn sie den Rand der Form verlassen
        If Form1.LblScroll1.Location.X + Form1.LblScroll1.Width < 100 Then
            Form1.LblScroll1.Location = New Point(Form1.LblScroll3.Location.X + Form1.LblScroll3.Width + spacerScroll, heightScroll)
        End If

        If Form1.LblScroll2.Location.X + Form1.LblScroll2.Width < 100 Then
            Form1.LblScroll2.Location = New Point(Form1.LblScroll1.Location.X + Form1.LblScroll1.Width + spacerScroll, heightScroll)
        End If

        If Form1.LblScroll3.Location.X + Form1.LblScroll3.Width < 100 Then
            Form1.LblScroll3.Location = New Point(Form1.LblScroll2.Location.X + Form1.LblScroll2.Width + spacerScroll, heightScroll)
        End If

    End Sub

End Class
