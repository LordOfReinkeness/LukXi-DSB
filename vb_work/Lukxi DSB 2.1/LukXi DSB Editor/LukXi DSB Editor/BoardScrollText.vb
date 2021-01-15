Public Class BoardScrollText

    Private spacerScroll As Integer
    Private heightScroll As Integer

    Public Sub New(s As Integer, h As Integer)

        'Konstruktor für die Höhe des Scrolltextes und den Abstand zwischen den einzelnen Versionen
        spacerScroll = s
        heightScroll = h

    End Sub

    Public Sub Generate(f As String, s As Single, int As String)    'Argument: Adresse der Datei

        'Schreibt den den Text aus der Textdatei in drei Labels
        DepMain.LblScroll1.Text = DepMain.ScrollText
        DepMain.LblScroll1.Location = New Point(20, heightScroll)
        DepMain.LblScroll1.Font = New Font(f, s, FontStyle.Bold)
        DepMain.LblScroll2.Text = DepMain.LblScroll1.Text
        DepMain.LblScroll2.Location = New Point(DepMain.LblScroll1.Location.X + DepMain.LblScroll1.Width + spacerScroll, heightScroll)
        DepMain.LblScroll2.Font = New Font(f, s, FontStyle.Bold)
        DepMain.LblScroll3.Text = DepMain.LblScroll1.Text
        DepMain.LblScroll3.Location = New Point(DepMain.LblScroll2.Location.X + DepMain.LblScroll2.Width + spacerScroll, heightScroll)
        DepMain.LblScroll3.Font = New Font(f, s, FontStyle.Bold)

        'Geschwindigkeit laden
        DepMain.TimScroll.Interval = int

    End Sub

    Public Sub Move()       'Argumnet: Pixel Bewegung pro tick

        'Bewegt alle drei Scrolltexte
        DepMain.LblScroll1.Location = New Point(DepMain.LblScroll1.Location.X - 1, heightScroll)
        DepMain.LblScroll2.Location = New Point(DepMain.LblScroll2.Location.X - 1, heightScroll)
        DepMain.LblScroll3.Location = New Point(DepMain.LblScroll3.Location.X - 1, heightScroll)

        'Zurücksetzen der Scrolltexte, wenn sie den Rand der Form verlassen
        If DepMain.LblScroll1.Location.X + DepMain.LblScroll1.Width < 100 Then
            DepMain.LblScroll1.Location = New Point(DepMain.LblScroll3.Location.X + DepMain.LblScroll3.Width + spacerScroll, heightScroll)
        End If

        If DepMain.LblScroll2.Location.X + DepMain.LblScroll2.Width < 100 Then
            DepMain.LblScroll2.Location = New Point(DepMain.LblScroll1.Location.X + DepMain.LblScroll1.Width + spacerScroll, heightScroll)
        End If

        If DepMain.LblScroll3.Location.X + DepMain.LblScroll3.Width < 100 Then
            DepMain.LblScroll3.Location = New Point(DepMain.LblScroll2.Location.X + DepMain.LblScroll2.Width + spacerScroll, heightScroll)
        End If

    End Sub

End Class
