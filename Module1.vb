Module Module1

    Dim cache As Dictionary(Of Decimal, Decimal) = New Dictionary(Of Decimal, Decimal)
  

    Private Function sumFib(ByVal y As Decimal) As Decimal
        Dim z As Decimal
        If y < 2 Then
            Return y
        End If

        If (cache.ContainsKey(y)) Then
            Return cache(y)
        End If

        z =  sumFib(y - 1) + sumFib(y - 2)

        cache(y) = z

        Return z

    End Function

    Sub Main()
        For value As Decimal = 0 To 100
            Console.WriteLine(sumFib(value))
        Next

    End Sub

End Module
