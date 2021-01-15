Public Class EditorAdresslist

    'Dim root As String = Form1.root

    Public Function getRelativPath(a As String)

        Select Case a
            'config
            Case "con"
                Return FormMain.root & "config.txt"

            'Daten des Stundenplans
            Case "0"
                Return FormMain.root & "doc\mon.txt"
            Case "1"
                Return FormMain.root & "doc\tue.txt"
            Case "2"
                Return FormMain.root & "doc\wed.txt"
            Case "3"
                Return FormMain.root & "doc\thu.txt"
            Case "4"
                Return FormMain.root & "doc\fri.txt"
            Case "5"
                Return FormMain.root & "doc\wee.txt"

            'Andere Texte
            Case "scrl"
                Return FormMain.root & "doc\lauftext.txt"
            Case "cal"
                Return FormMain.root & "doc\calendar.txt"

            'Txt's für fotos
            Case "phM"
                Return FormMain.root & "doc\photoMain.txt"
            Case "phF"
                Return FormMain.root & "doc\photoFull.txt"

            'Medienort
            Case "med"
                Return FormMain.root & "media"
            Case "meM"
                Return FormMain.root & "media\main"
            Case "meF"
                Return FormMain.root & "media\full"

            Case Else
                Return "-1"

        End Select

    End Function

End Class
