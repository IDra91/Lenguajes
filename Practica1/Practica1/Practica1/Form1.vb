Public Class Form1

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim entrada As String = Txt1.Text
        Dim lex As Analizador = New Analizador()
        Dim lTokens As List(Of Token) = lex.scann(entrada)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OFD.Filter = "*.PLN"

        If (OFD.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OFD.FileName
        End If
    End Sub
End Class
