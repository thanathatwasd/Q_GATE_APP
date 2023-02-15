Public Class qgateMenuStart
    Private Sub pbDMC_Click(sender As Object, e As EventArgs) Handles pbDMC.Click
        Module1.dmcornondmc = "dmc"
        qgateScanTag.Show()
        Me.Close()
    End Sub

    Private Sub pbNonDMC_Click(sender As Object, e As EventArgs) Handles pbNonDMC.Click
        Module1.dmcornondmc = "nondmc"
        qgateScanTag.Show()
        Me.Close()
    End Sub



    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles pbBacktoMenu.Click
        qgateSelectMenu.Show()
        Me.Close()
    End Sub
End Class