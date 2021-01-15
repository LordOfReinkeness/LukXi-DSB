Public Class ArrayLines
    Private a() As String
    Public Sub New(l() As String)
        'Weist das Konstruktor Argumnet der Private Variable zu

        a = l

    End Sub

    Public Function TestForCapital()
        'Gibt TRUE zurück wenn das Array mit einer Überschrift beginnt sonst FALSE

        If a(0) <> "" And a(0).Substring(0, 2) = "##" Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function CapitalText(n As Integer)
        'Gibt den Next der n ten(Argument) Überschrift als String zurück

        Dim i, j As Integer
        Dim t As String

        For i = 0 To n - 1

            For j = j To a.Length - 1

                If a(j) <> "" And a(j).Length > 1 Then

                    If a(j).Substring(0, 2) = "##" Then
                        t = a(j).Substring(2, a(j).Length - 2)
                        j += 1
                        Exit For
                    End If

                End If

            Next

        Next

        Return t

    End Function

    Public Function LowerText(n As Integer)
        'Gibt den Text zwischen der n ten und der n+1 ten Übersschrift als String zurück

        Dim i, j As Integer
        Dim t As String

        For i = 0 To n - 1
            t = ""

            For j = j To a.Length - 1

                If a(j) <> "" And a(j).Length > 1 Then

                    If a(j).Substring(0, 2) = "##" Then

                        j += 1
                        Exit For

                    End If

                End If
                t &= a(j) & vbCrLf

            Next

        Next

        Return t

    End Function

    Public Function Passes()

        Dim i As Integer = 1
        Dim text As String = LowerText(i)

        Do
            i += 1
            If text = LowerText(i) Then
                Return i - 3
            End If

            text = LowerText(i)

        Loop
    End Function

End Class
