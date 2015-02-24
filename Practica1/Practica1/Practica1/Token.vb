

Public Class Token
    Enum Tipo
        Numero
        DosPuntos
        Letra
        Paren_Izq
        Paren_Der
    End Enum
    Private tipoToken As Tipo
    Private valor As String
    Public Sub New(ByVal tipo As Tipo, ByVal aux As String)
        Me.tipoToken = tipo
        Me.valor = aux

    End Sub
    Public Function getValor() As String
        Return valor

    End Function

    Public Function getString() As String
        Select Case tipoToken
            Case Tipo.Letra
                Return "Letra"
            Case Tipo.DosPuntos
                Return "Dos Puntos"
            Case Tipo.Numero
                Return "Número"
            Case Tipo.Paren_Izq
                Return "Parentesis Izquierdo"
            Case Tipo.Paren_Der
                Return "Parentesis Derecho"
            Case Else
                Return "Desconocido"
        End Select

    End Function
End Class
