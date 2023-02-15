Public Class qgateprintTag
    Private Sub pbBacktoMenu_Click(sender As Object, e As EventArgs) Handles pbBacktoMenu.Click
        qgateSelectMenu.Show()
        Me.Close()
    End Sub

    Private Sub pbReprintQGate_Click(sender As Object, e As EventArgs) Handles pbReprintQGate.Click
        qgateReprintTag.Show()
        Me.Close()
    End Sub

    Private Sub pbReprintDefect_Click(sender As Object, e As EventArgs) Handles pbReprintDefect.Click
        qgateReprintDefect.Show()
        Me.Close()
    End Sub
End Class