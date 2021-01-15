Public Class TimetabelText

    Private vertTimetable As Integer
    Private spacerTimetable As Integer

    Public Sub New(v As Integer, h As Integer)

        vertTimetable = v
        spacerTimetable = h

    End Sub

    Public Sub Generate(f As String,
                        sl As Single, sc As Single, int As Integer,
                        hc As Integer, wc As Integer, cp As Integer)        'Argumnet: Adresse der Datei

        Panel1(f, sl, sc, hc, wc, cp)
        Panel2(f, sl, sc, hc, wc, cp)

        Form1.PanInfo1.Location = New Point(vertTimetable, 210)
        Form1.PanInfo2.Location = New Point(vertTimetable, Form1.PanInfo1.Location.Y + Form1.PanInfo1.Height + spacerTimetable)

        Form1.TimTimetable.Interval = int

    End Sub

    Public Sub Move()

        Form1.PanInfo1.Location = New Point(vertTimetable, Form1.PanInfo1.Location.Y - 1)
        Form1.PanInfo2.Location = New Point(vertTimetable, Form1.PanInfo2.Location.Y - 1)

        If Form1.PanInfo1.Location.Y + Form1.PanInfo1.Height < 210 Then
            Form1.PanInfo1.Location = New Point(vertTimetable, Form1.PanInfo2.Location.Y + Form1.PanInfo2.Height + spacerTimetable)
        End If

        If Form1.PanInfo2.Location.Y + Form1.PanInfo2.Height < 210 Then
            Form1.PanInfo2.Location = New Point(vertTimetable, Form1.PanInfo1.Location.Y + Form1.PanInfo1.Height + spacerTimetable)
        End If


    End Sub

    Private Sub Panel1(f As String, sl As Single, sc As Single, hc As Integer,
                       wc As Integer, cp As Integer)

        Dim h As Integer = 20
        Dim t As String

        Dim agtext() As String = Form1.Timetable.Clone

        Dim infoArray As New ArrayLines(agtext)

        If infoArray.TestForCapital() = False Then
            Dim lb0 As New Label

            lb0.AutoSize = True
            lb0.BorderStyle = BorderStyle.None
            lb0.Font = New Font(f, sl, FontStyle.Regular)
            lb0.Text = infoArray.LowerText(1)
            lb0.TextAlign = ContentAlignment.MiddleCenter
            Form1.PanInfo1.Controls.Add(lb0)

            lb0.Location = New Point(Form1.PanInfo1.Width / 2 - lb0.Width / 2, h)
            h += lb0.Height + 10

        End If

        Dim i As Integer

        For i = 0 To infoArray.Passes() - 1

            Dim lb1 As New Label
            lb1.AutoSize = True
            lb1.BorderStyle = BorderStyle.None
            lb1.Font = New Font(f, sc, FontStyle.Bold)
            t = infoArray.CapitalText(i + 1)
            lb1.Text = t.ToUpper()
            lb1.TextAlign = ContentAlignment.MiddleCenter
            lb1.BackColor = Color.FromArgb(211, 132, 145)
            Form1.PanInfo1.Controls.Add(lb1)

            Dim ph1 As New PictureBox
            ph1.Location = New Point(Form1.PanInfo1.Width / 2 - wc / 2, h - 1)
            ph1.Size = New Size(wc, hc)
            ph1.ImageLocation = Form1.addCptbr
            ph1.Load()
            Form1.PanInfo1.Controls.Add(ph1)

            lb1.Location = New Point(Form1.PanInfo1.Width / 2 - lb1.Width / 2, h + cp)
            h += ph1.Height + 10

            Dim lb2 As New Label

            lb2.AutoSize = True
            lb2.BorderStyle = BorderStyle.None
            lb2.Font = New Font(f, sl, FontStyle.Regular)
            lb2.Text = infoArray.LowerText(i + 2)
            lb2.TextAlign = ContentAlignment.MiddleCenter
            Form1.PanInfo1.Controls.Add(lb2)

            lb2.Location = New Point(Form1.PanInfo1.Width / 2 - lb2.Width / 2, h)
            h += lb2.Height + 10

        Next

        Form1.PanInfo1.Height = h
    End Sub

    Private Sub Panel2(f As String, sl As Single, sc As Single, hc As Integer,
                       wc As Integer, cp As Integer)

        Dim h As Integer = 20
        Dim t As String

        Dim agtext() As String = Form1.Timetable.Clone

        Dim infoArray As New ArrayLines(agtext)

        If infoArray.TestForCapital() = False Then
            Dim lb0 As New Label

            lb0.AutoSize = True
            lb0.BorderStyle = BorderStyle.None
            lb0.Font = New Font(f, sl, FontStyle.Regular)
            lb0.Text = infoArray.LowerText(1)
            lb0.TextAlign = ContentAlignment.MiddleCenter
            Form1.PanInfo2.Controls.Add(lb0)

            lb0.Location = New Point(Form1.PanInfo1.Width / 2 - lb0.Width / 2, h)
            h += lb0.Height + 10
        End If

        Dim i As Integer

        For i = 0 To infoArray.Passes() - 1

            Dim lb1 As New Label

            lb1.AutoSize = True
            lb1.BorderStyle = BorderStyle.None
            lb1.Font = New Font(f, sc, FontStyle.Bold)
            t = infoArray.CapitalText(i + 1)
            lb1.Text = t.ToUpper()
            lb1.TextAlign = ContentAlignment.MiddleCenter
            lb1.BackColor = Color.FromArgb(211, 132, 145)
            Form1.PanInfo2.Controls.Add(lb1)

            Dim ph1 As New PictureBox
            ph1.Location = New Point(Form1.PanInfo2.Width / 2 - wc / 2, h - 1)
            ph1.Size = New Size(wc, hc)
            ph1.ImageLocation = Form1.addCptbr
            ph1.Load()
            Form1.PanInfo2.Controls.Add(ph1)

            lb1.Location = New Point(Form1.PanInfo1.Width / 2 - lb1.Width / 2, h + cp)
            h += ph1.Height + 10

            Dim lb2 As New Label

            lb2.AutoSize = True
            lb2.BorderStyle = BorderStyle.None
            lb2.Font = New Font(f, sl, FontStyle.Regular)
            lb2.Text = infoArray.LowerText(i + 2)
            lb2.TextAlign = ContentAlignment.MiddleCenter
            Form1.PanInfo2.Controls.Add(lb2)

            lb2.Location = New Point(Form1.PanInfo1.Width / 2 - lb2.Width / 2, h)
            h += lb2.Height + 10

            Form1.PanInfo2.Height = h

        Next


    End Sub
End Class
