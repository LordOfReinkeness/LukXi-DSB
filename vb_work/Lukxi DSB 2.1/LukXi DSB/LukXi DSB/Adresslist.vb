Public Class Adresslist
    Public Function getRelativPath(a As String)

        Select Case a
            'config
            Case "con"
                Return Form1.root & "config.txt"

            'Daten des Stundenplans
            Case "0"
                Return Form1.root & "doc\mon.txt"
            Case "1"
                Return Form1.root & "doc\tue.txt"
            Case "2"
                Return Form1.root & "doc\wed.txt"
            Case "3"
                Return Form1.root & "doc\thu.txt"
            Case "4"
                Return Form1.root & "doc\fri.txt"
            Case "5"
                Return Form1.root & "doc\wee.txt"

            'Andere Texte
            Case "scrl"
                Return Form1.root & "doc\lauftext.txt"
            Case "cal"
                Return Form1.root & "doc\calendar.txt"

            'Txt's für fotos
            Case "phM"
                Return Form1.root & "doc\photoMain.txt"
            Case "phF"
                Return Form1.root & "doc\photoFull.txt"

            'Medienort
            Case "med"
                Return Form1.root & "media"
            Case "meM"
                Return Form1.root & "media\main"
            Case "meF"
                Return Form1.root & "media\full"

            Case Else
                Return "-1"

        End Select

    End Function
End Class
