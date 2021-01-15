Public Class BoardAdresslist
    Public Function getRelativPath(a As String)

        Select Case a
            'config
            Case "con"
                Return DepMain.root & "config.txt"

            'Daten des Stundenplans
            Case "0"
                Return DepMain.root & "doc\mon.txt"
            Case "1"
                Return DepMain.root & "doc\tue.txt"
            Case "2"
                Return DepMain.root & "doc\wed.txt"
            Case "3"
                Return DepMain.root & "doc\thu.txt"
            Case "4"
                Return DepMain.root & "doc\fri.txt"
            Case "5"
                Return DepMain.root & "doc\wee.txt"

            'Andere Texte
            Case "scrl"
                Return DepMain.root & "doc\lauftext.txt"
            Case "cal"
                Return DepMain.root & "doc\calendar.txt"

            'Txt's für fotos
            Case "phM"
                Return DepMain.root & "doc\photoMain.txt"
            Case "phF"
                Return DepMain.root & "doc\photoFull.txt"

            'Medienort
            Case "med"
                Return DepMain.root & "media"
            Case "meM"
                Return DepMain.root & "media\main"
            Case "meF"
                Return DepMain.root & "media\full"

            Case Else
                Return "-1"

        End Select

    End Function
End Class
