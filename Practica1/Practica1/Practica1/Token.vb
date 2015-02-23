

Public Class Token
    Enum Tipo
        Numero
        DosPuntos
        Letra

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
                Return "Nombre"
            Case Tipo.DosPuntos
                Return "Dos Puntos"
            Case Tipo.Numero
                Return "Número"
            Case Else
                Return "Desconocido"
        End Select

    End Function
End Class
