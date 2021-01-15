Public Class FormSettings

    Dim conf() As String
    Private TimeDo As Boolean = False

    Dim saving As New EditorSave
    Dim adress As New EditorAdresslist

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Con einlesen
        conf = FormMain.config.Clone


        'Eintellungen für die größe von der Form
        Me.Location = New Point(960 - Me.Width / 2, 540 - Me.Height / 2)

        'Schalterpositionen und Label Laden
        TrkSpeedTimetable.Value = 31 - conf(1)
        TxtSpeedTime.Text = TrkSpeedTimetable.Value

        TrkSpeedPhotos.Value = conf(3) / 1000
        TxtSpeedPic.Text = TrkSpeedPhotos.Value

        TrkSpeedInfo.Value = 31 - conf(2)
        TxtSpeedInf.Text = TrkSpeedInfo.Value

        TrkSpeedScroll.Value = 31 - conf(0)
        TxtSpeedScroll.Text = TrkSpeedScroll.Value

        TrkForm2dur.Value = conf(6) / 1000
        TxtForm2Dur.Text = TrkForm2dur.Value

        TrkForm1dur.Value = conf(7) / 1000
        TxtForm1Dur.Text = TrkForm1dur.Value

        'Form 2 Daten Laden
        TrkForm2dur.Value = conf(6) / 1000
        TrkForm1dur.Value = conf(7) / 1000

        If conf(5) = True Then
            ChkForm2.Checked = True
            TrkForm1dur.Enabled = True
            TrkForm2dur.Enabled = True
        ElseIf conf(5) = False Then
            ChkForm2.Checked = False
            TrkForm1dur.Enabled = False
            TrkForm2dur.Enabled = False
        End If

        'Shutoff Laden
        If conf(8).Substring(conf(8).Length - 3, 2) = "PM" Then
            If conf(8).Substring(2, 1) = ":" Then
                CmbTime1.SelectedIndex = conf(8).Substring(1, 1) + 12
                CmbTime2.SelectedItem = conf(8).Substring(3, 2)
            ElseIf conf(8).Substring(3, 1) = ":" Then
                CmbTime1.SelectedIndex = conf(8).Substring(1, 2) + 12
                CmbTime2.SelectedItem = conf(8).Substring(4, 2)
            End If

        ElseIf conf(8).Substring(conf(8).Length - 3, 2) = "AM" Then

            If conf(8).Substring(2, 1) = ":" Then
                CmbTime1.SelectedIndex = conf(8).Substring(1, 1)
                CmbTime2.SelectedItem = conf(8).Substring(3, 2)
            ElseIf conf(8).Substring(3, 1) = ":" Then
                CmbTime1.SelectedIndex = conf(8).Substring(1, 2)
                CmbTime2.SelectedItem = conf(8).Substring(4, 2)
            End If
        End If

        If conf(11) = True Then
            ChkPcOff.Checked = True
        ElseIf conf(11) = False Then
            ChkPcOff.Checked = False
        End If

        If conf(10) = True Then
            ChkPcOff.Enabled = True
            CmbTime1.Enabled = True
            CmbTime2.Enabled = True
            ChkPgmOff.Checked = True
        ElseIf conf(10) = False Then
            ChkPgmOff.Checked = False
            ChkPcOff.Checked = False
            conf(10) = False
            ChkPcOff.Enabled = False
            CmbTime1.Enabled = False
            CmbTime2.Enabled = False
        End If

        TimeDo = True


        'Save Button am Anfang ausschalten
        CmdSave.Enabled = False

    End Sub



    Private Sub TrkSpeedTimetable_Scroll(sender As Object, e As EventArgs) Handles TrkSpeedTimetable.Scroll
        TxtSpeedTime.Text = TrkSpeedTimetable.Value
        conf(1) = 31 - TrkSpeedTimetable.Value

        CmdSave.Enabled = True
        FormMain.CmdSave.Enabled = True
    End Sub

    Private Sub TrkSpeedPhotos_Scroll(sender As Object, e As EventArgs) Handles TrkSpeedPhotos.Scroll
        TxtSpeedPic.Text = TrkSpeedPhotos.Value
        conf(3) = TrkSpeedPhotos.Value * 1000

        CmdSave.Enabled = True
        FormMain.CmdSave.Enabled = True
    End Sub

    Private Sub TrkSpeedInfo_Scroll(sender As Object, e As EventArgs) Handles TrkSpeedInfo.Scroll
        TxtSpeedInf.Text = TrkSpeedInfo.Value
        conf(2) = 31 - TrkSpeedInfo.Value

        CmdSave.Enabled = True
        FormMain.CmdSave.Enabled = True
    End Sub

    Private Sub TrkSpeedScroll_Scroll(sender As Object, e As EventArgs) Handles TrkSpeedScroll.Scroll
        TxtSpeedScroll.Text = TrkSpeedScroll.Value
        conf(0) = 31 - TrkSpeedScroll.Value

        CmdSave.Enabled = True
        FormMain.CmdSave.Enabled = True
    End Sub

    Private Sub TrkForm2timer_Scroll(sender As Object, e As EventArgs) Handles TrkForm2dur.Scroll
        TxtForm2Dur.Text = TrkForm2dur.Value
        conf(6) = TrkForm2dur.Value * 1000

        CmdSave.Enabled = True
        FormMain.CmdSave.Enabled = True
    End Sub

    Private Sub TrkForm2wait_Scroll(sender As Object, e As EventArgs) Handles TrkForm1dur.Scroll
        TxtForm1Dur.Text = TrkForm1dur.Value
        conf(7) = TrkForm1dur.Value * 1000

        CmdSave.Enabled = True
        FormMain.CmdSave.Enabled = True
    End Sub

    Private Sub ChkPgmOff_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPgmOff.CheckedChanged
        If TimeDo Then
            If ChkPgmOff.Checked = True Then
                ChkPcOff.Enabled = True
                CmbTime1.Enabled = True
                CmbTime2.Enabled = True
                conf(10) = True
            ElseIf ChkPgmOff.Checked = False Then
                ChkPcOff.Enabled = False
                CmbTime1.Enabled = False
                CmbTime2.Enabled = False
                conf(10) = False
                ChkPcOff.Checked = False
                conf(11) = False
            End If
            CmdSave.Enabled = True
            FormMain.CmdSave.Enabled = True
        End If

    End Sub

    Private Sub ChkForm2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkForm2.CheckedChanged
        If TimeDo Then
            If ChkForm2.Checked = True Then
                conf(5) = True
                TrkForm1dur.Enabled = True
                TrkForm2dur.Enabled = True
            ElseIf ChkForm2.Checked = False Then
                conf(5) = False
                TrkForm1dur.Enabled = False
                TrkForm2dur.Enabled = False
            End If

        End If
    End Sub

    Private Sub ChkPcOff_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPcOff.CheckedChanged
        If TimeDo Then
            If ChkPcOff.Checked = True Then
                conf(11) = True
            ElseIf ChkPcOff.Checked = False Then
                conf(11) = False
            End If
            CmdSave.Enabled = True
            FormMain.CmdSave.Enabled = True
        End If

    End Sub

    Private Sub TimeEdit(sender As Object, e As EventArgs) Handles CmbTime1.SelectedIndexChanged, CmbTime2.SelectedIndexChanged

        If TimeDo Then
            If CmbTime1.SelectedItem < 12 Then
                conf(8) = "#" & CmbTime1.SelectedItem & ":" & CmbTime2.SelectedItem &
                ":00 AM#"
                If CmbTime2.SelectedItem = 45 Then
                    conf(9) = "#" & CmbTime1.SelectedItem + 1 & ":00:00 AM#"
                Else
                    conf(9) = "#" & CmbTime1.SelectedItem & ":" & CmbTime2.SelectedItem + 15 &
                ":00 AM#"
                End If

            ElseIf CmbTime1.SelectedItem = 12 Then
                conf(8) = "#" & CmbTime1.SelectedItem & ":" & CmbTime2.SelectedItem &
                ":00 AM#"
                If CmbTime2.SelectedItem = 45 Then
                    conf(9) = "#1:00:00 PM#"
                Else
                    conf(9) = "#" & CmbTime1.SelectedItem & ":" & CmbTime2.SelectedItem + 15 &
                ":00 AM#"
                End If

            ElseIf CmbTime1.SelectedItem > 12 Then
                conf(8) = "#" & CmbTime1.SelectedItem - 12 & ":" & CmbTime2.SelectedItem &
                ":00 PM#"
                If CmbTime2.SelectedItem = 45 Then
                    conf(9) = "#" & CmbTime1.SelectedItem - 11 & ":00:00 PM#"
                Else
                    conf(9) = "#" & CmbTime1.SelectedItem - 12 & ":" & CmbTime2.SelectedItem + 15 &
                ":00 PM#"
                End If
                CmdSave.Enabled = True
                FormMain.CmdSave.Enabled = True
            End If

        End If
    End Sub

    Private Sub SaveAsk(sender As Object, e As EventArgs) Handles CmdClose.Click, Me.Closed
        If CmdSave.Enabled = True Then

            Dim dr As DialogResult

            dr = MessageBox.Show("Sie haben ihre Änderungen nicht gespeichert!" & vbCrLf &
                            "Wolen sie Speichern?", "Speichern?", MessageBoxButtons.YesNo)

            If dr = DialogResult.Yes Then
                save()
            End If

            CmdSave.Enabled = False

        End If
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        save()
        CmdSave.Enabled = False
    End Sub

    Private Sub save()
        FormMain.config = conf.Clone
        saving.StringToTxt(adress.getRelativPath("con"), saving.ArrToString(conf))
        CmdSave.Enabled = False
    End Sub

    Private Sub TxtSpeedTime_TextChanged(sender As Object, e As EventArgs) Handles TxtSpeedTime.TextChanged
        If TxtSpeedTime.Text.Equals("") = False Then
            Dim i As Integer = TxtSpeedTime.Text
            If i < 31 Then
                TrkSpeedTimetable.Value = i
                CmdSave.Enabled = True
                FormMain.CmdSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub TxtSpeedPic_TextChanged(sender As Object, e As EventArgs) Handles TxtSpeedPic.TextChanged
        If TxtSpeedPic.Text.Equals("") = False Then
            Dim i As Integer = TxtSpeedPic.Text
            If i < 61 Then
                TrkSpeedPhotos.Value = i
                CmdSave.Enabled = True
                FormMain.CmdSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub TxtSpeedInf_TextChanged(sender As Object, e As EventArgs) Handles TxtSpeedInf.TextChanged
        If TxtSpeedInf.Text.Equals("") = False Then
            Dim i As Integer = TxtSpeedInf.Text
            If i < 31 Then
                TrkSpeedInfo.Value = i
                CmdSave.Enabled = True
                FormMain.CmdSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub TxtSpeedScroll_TextChanged(sender As Object, e As EventArgs) Handles TxtSpeedScroll.TextChanged
        If TxtSpeedScroll.Text.Equals("") = False Then
            Dim i As Integer = TxtSpeedScroll.Text
            If i < 31 Then
                TrkSpeedScroll.Value = i
                CmdSave.Enabled = True
                FormMain.CmdSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub TxtForm2Dur_TextChanged(sender As Object, e As EventArgs) Handles TxtForm2Dur.TextChanged
        If TxtForm2Dur.Text.Equals("") = False Then
            Dim i As Integer = TxtForm2Dur.Text
            If i < 61 Then
                TrkForm2dur.Value = i
                CmdSave.Enabled = True
                FormMain.CmdSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub TxtForm1Dur_TextChanged(sender As Object, e As EventArgs) Handles TxtForm1Dur.TextChanged
        If TxtForm1Dur.Text.Equals("") = False Then
            Dim i As Integer = TxtForm1Dur.Text
            If i < 301 Then
                TrkForm1dur.Value = i
                CmdSave.Enabled = True
                FormMain.CmdSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub Form_klick(sender As Object, e As EventArgs) Handles Me.Click

        If TxtSpeedTime.Text.Equals("") Then
            TxtSpeedTime.Text = 31 - conf(1)
        End If

        If TxtSpeedInf.Text.Equals("") Then
            TxtSpeedInf.Text = 31 - conf(2)
        End If

        If TxtSpeedPic.Text.Equals("") Then
            TxtSpeedPic.Text = conf(3) / 1000
        End If

        If TxtSpeedScroll.Text.Equals("") Then
            TxtSpeedScroll.Text = 31 - conf(0)
        End If

        If TxtForm2Dur.Text.Equals("") Then
            TxtForm2Dur.Text = conf(6) / 1000
        End If

        If TxtForm1Dur.Text.Equals("") Then
            TxtForm1Dur.Text = conf(7) / 1000
        End If

    End Sub

End Class