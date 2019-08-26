Imports ClassLibrary_CS

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vb As New C001
        vb.GetValue()
        vb.GetValues()
        vb.GetName()
        vb.GetNames()

        Dim cs As New ClassLibrary_CS.C001_010.C001
        cs.GetValue()
        cs.GetValues()
        cs.GetName()
        cs.GetNames()

    End Sub

End Class
