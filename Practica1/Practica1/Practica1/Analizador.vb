Imports Practica1.Token

Public Class Analizador
    Private salida As List(Of Token)
    Private estado As Integer
    Private aux As String

    Public Function scann(ByVal entrada As String) As List(Of Token)
        entrada = entrada + "#"
        salida = New List(Of Token)
        estado = 0
        aux = ""
        Dim contador As Integer = 0
        Dim contadors As Integer = 0
        Dim contador2 As Integer = 0
        Dim c As Char
        For i As Integer = 0 To entrada.Length - 1 Step 1
            c = entrada.Chars(i)
            Select Case estado
                Case 0
                    If Char.IsNumber(c) Then
                        contador = contador + 1
                        If (contador = 4) Then
                            aux += c
                            estado = 1
                            addToken(Tipo.Numero)
                        Else
                            estado = 0
                        End If
                    ElseIf (c = ":") Then
                        aux += c
                        addToken(Tipo.DosPuntos)
                    ElseIf (c = "[a-z]") Then
                        aux += c
                        addToken(Tipo.Letra)
                    ElseIf (c = "(") Then
                        aux += c
                        addToken(Tipo.Paren_Izq)
                    ElseIf (c = ")") Then
                        aux += c
                        addToken(Tipo.Paren_Der)
                    Else
                        If (c = "#" And i = entrada.Length() - 1) Then
                            Console.WriteLine("Se ha concluido el análisis correctamente")
                        Else
                            Console.WriteLine("Error léxico con: " + c)
                        End If
                    End If
                Case 1
                    If (c = ":") Then

                        estado = 2
                        aux += c
                        addToken(Tipo.DosPuntos)

                    Else
                        Console.WriteLine("Error léxico en: " & c & " Se esperaba un paréntesis abierto")
                        estado = 0
                    End If
                Case 2
                    If Char.IsLetter(c) Then
                        contadors = contadors + 1
                        If (contadors = 11) Then
                            aux += c
                            estado = 3
                            addToken(Tipo.Letra)
                        Else
                            aux += c
                            estado = 2
                        End If
                    Else
                        Console.WriteLine("Error léxico en: " & c & " Se esperaba un nombre al curso")
                        estado = 0
                    End If
                Case 3
                    If Char.IsSymbol(c) Then
                        estado = 4
                        aux += c
                    Else
                        Console.WriteLine("Error léxico en: " & c & " Se esperan un dos puntos")
                        estado = 0
                    End If
                Case 4
                    If Char.IsNumber(c) Then
                        estado = 4
                        aux += c
                    ElseIf (c = "") Then
                        estado = 4
                        aux += c
                    Else
                        i -= 1
                    End If
            End Select
        Next
        Return salida
    End Function
    Private Sub addToken(ByVal tipo As Tipo)
        salida.Add(New Token(tipo, aux))
        aux = ""
        estado = 0
    End Sub
    Private Sub imprimir(ByVal l As List(Of Token))
        For Each t As Token In l
            Console.WriteLine(t.getString() & "<-->" & t.getValor())
        Next
    End Sub

End Class

