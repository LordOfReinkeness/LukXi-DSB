Public Class DepMain
    '///////////////////////Gobale variablen\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    '////////////Absolute Adressen\\\\\\\\\\\\\\\\\\
    Public root As String = "data\"
    Public dSrc As String '= "\\10.16.1.1\xibo\Lukxi DSB 2.0\data"
    Public addrMask As String '= "maskDSB.png"
    Public addCptbr As String '= "captionbar.png"


    '//////////////Datenspeicher\\\\\\\\\\\\\\\\\\\\
    Public photosArray(,) As String
    Public mediaArray() As String
    Public Timetable() As String
    Public Calendar() As String
    Public ScrollText As String
    Public config() As String

    '/////////////Kontrollvariablen\\\\\\\\\\\\\\\\\
    'Kontrollvariablen
    Private heightScroll As Integer = 1010
    Private spacerScroll As Integer = 100

    Private vertTimetable As Integer = 105
    Private spacerTimetable As Integer = 100

    Private vertInfo As Integer = 1315
    Private spacerInfo As Integer = 100

    Private heightCaptionbar As Integer = 30
    Private withCaptionbar As Integer = 490
    Private captionbarPosition As Integer = 2

    Private sizeCapital As Single = 15
    Private sizeLower As Single = 15
    Private sizeScrolltext As Single = 30
    Private sizeClock As Single = 40
    Private spacerDate As Integer = -5
    Private sizeDate As Integer = 15
    Private sizeFotocaption As Single = 15

    Public T1Tick As Integer = 0

    Private reload As Integer = 0

    Dim nPhoto As Integer = 0
    Public nMedia As Integer = 0

    Public restart As Boolean = False

    'Instanzen anlegen
    Dim loading As New BoardLoad
    Dim adress As New BoardAdresslist
    Dim met As New BoardWorkingClass

    Dim sc As New BoardScrollText(spacerScroll, heightScroll)
    Dim timetabele As New BoardTimetabelText(vertTimetable, spacerTimetable)
    Dim info As New BoardInfoText(vertInfo, spacerInfo)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tempA() As String = loading.TxtToSimpleArray("startupLocD.txt")
        dSrc = tempA(0)
        addrMask = tempA(1)
        addCptbr = tempA(2)

        startup()

        'Form1 Größe festlegen
        Me.Size = New Size(1920, 1080)
        Me.Location = New Point(0, 0)

        'Anzeigeobjekte Laden
        sc.Generate(config(4), sizeScrolltext, config(0))
        timetabele.Generate(config(4), sizeLower, sizeCapital, config(1), heightCaptionbar, withCaptionbar, captionbarPosition)
        info.Generate(config(4), sizeLower, sizeCapital, config(2), heightCaptionbar, withCaptionbar, captionbarPosition)

        TimScroll.Enabled = True
        TimTimetable.Enabled = True
        TimInfo.Enabled = True

        'Maske Laden
        PicMask.Location = New Point(0, 0)
        PicMask.Size = New Size(1920, 1080)

        PicMask.ImageLocation = "maskDSB.png"
        PicMask.Load()

        met.Mask()

        'Bilder Laden
        PicFlyer.SizeMode = PictureBoxSizeMode.Zoom
        PicFlyer.Location = New Point(720, 205)
        PicFlyer.Size = New Size(480, 669)
        PicFlyer.ImageLocation = adress.getRelativPath("meM") & photosArray(nPhoto, 0)
        PicFlyer.Load()
        LblPhoto.Text = photosArray(nPhoto, 1)
        LblPhoto.Font = New Font(config(4), sizeFotocaption, FontStyle.Bold)
        LblPhoto.Location = New Point(PicFlyer.Location.X + PicFlyer.Width / 2 - LblPhoto.Width / 2, PicFlyer.Location.Y + PicFlyer.Height + 15)
        TimPhoto.Interval = config(3)

        TimPhoto.Enabled = True

        'Uhr und Datum laden
        Dim d1 = Date.Now
        LblClock.Text = d1.TimeOfDay.ToString().Substring(0, 5)
        LblClock.Font = New Font(config(4), sizeClock, FontStyle.Bold)
        LblClock.Location = New Point(Me.Width - (50 + LblClock.Width), 0)

        Dim dd As Date = Now.Date
        LblDate.Text = dd.ToLongDateString
        LblDate.AutoSize = True
        LblDate.Font = New Font(config(4), sizeDate, FontStyle.Bold)
        LblDate.Location = New Point(LblClock.Location.X + (LblClock.Width / 2) - (LblDate.Width / 2),
                                     LblClock.Location.Y + LblClock.Height + spacerDate)
        TimTime.Enabled = True

        'Form2 Erlauben
        If config(5).Equals("True") Then
            TimForm2.Enabled = True
        Else
            TimForm2.Enabled = False
        End If
        TimForm2.Interval = config(7)


    End Sub

    Private Sub startup()

        config = loading.TxtToSimpleArray(adress.getRelativPath("con"))

        photosArray = loading.GetDimenionalArray(adress.getRelativPath("phM"))

        Timetable = loading.TxtToSimpleArray(adress.getRelativPath(loading.GetDay().ToString))

        Calendar = loading.TxtToSimpleArray(adress.getRelativPath("cal"))

        ScrollText = loading.TxtToString(adress.getRelativPath("scrl"))

        mediaArray = loading.TxtToSimpleArray(adress.getRelativPath("phF"))

    End Sub

    Private Sub TimScroll_Tick(sender As Object, e As EventArgs) Handles TimScroll.Tick
        'Lauftext Bewegen
        sc.Move()

    End Sub

    Private Sub TimInfo_Tick(sender As Object, e As EventArgs) Handles TimInfo.Tick
        'Stundenplan bewegen
        timetabele.Move()

    End Sub

    Private Sub TimTimetable_Tick(sender As Object, e As EventArgs) Handles TimTimetable.Tick
        'Veranstaltunsinformation bewegen
        info.Move()

    End Sub

    Private Sub TimPhoto_Tick(sender As Object, e As EventArgs) Handles TimPhoto.Tick

        'Nächstzes Photo anzeigen
        nPhoto += 1
        If nPhoto > (photosArray.Length / 2 - 1) Then
            nPhoto = 0
        End If

        PicFlyer.ImageLocation = adress.getRelativPath("meM") & photosArray(nPhoto, 0)
        PicFlyer.Load()
        LblPhoto.Text = photosArray(nPhoto, 1)
        LblPhoto.Location = New Point(PicFlyer.Location.X + PicFlyer.Width / 2 - LblPhoto.Width / 2, PicFlyer.Location.Y + PicFlyer.Height + 15)

    End Sub

    Private Sub TimTime_Tick(sender As Object, e As EventArgs) Handles TimTime.Tick
        'Uhrzeit im 10 Sekunden takt Laden
        Dim d1 = Date.Now
        LblClock.Text = d1.TimeOfDay.ToString().Substring(0, 5)

    End Sub

    Private Sub TimResize_Tick(sender As Object, e As EventArgs) Handles TimResize.Tick

        If restart = True Then
            reload += 1
            If reload > 30 Then
                Application.Restart()
            End If
        ElseIf restart = False Then
            TimResize.Enabled = False
        End If

    End Sub

    Private Sub TimForm2_Tick(sender As Object, e As EventArgs) Handles TimForm2.Tick

        T1Tick = 0
        TimForm2.Enabled = False
        DepFull.ShowDialog()

    End Sub

    Private Sub CmdQuit_Click(sender As Object, e As EventArgs) Handles CmdQuit.Click
        TimForm2.Enabled = False
        Me.Close()
    End Sub

    Private Sub CmdRestart_Click(sender As Object, e As EventArgs)
        Application.Restart()
    End Sub
End Class
