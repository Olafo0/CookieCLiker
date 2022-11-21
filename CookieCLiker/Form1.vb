Public Class Form1
    Dim clicks_score As Integer
    Dim CPS As Integer = 1
    Dim Noob_B As Integer
    Dim Grandma_B As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Click_bt.Click
        clicks_score = clicks_score + CPS

        TextBox1.Text = clicks_score
        TextBox2.Text = CPS
    End Sub

    Private Sub NoobUPG_Click(sender As Object, e As EventArgs) Handles NoobUPG.Click
        If Noob_B = 4 Then
            NoobUPG.Hide()
        Else
            If clicks_score >= 150 Then
                CPS = CPS + 25
                clicks_score = clicks_score - 100
                TextBox1.Text = clicks_score
                TextBox2.Text = CPS
                Noob_B = Noob_B + 1
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Grandma_B = 4 Then
            Button1.Hide()
        Else
            If clicks_score >= 300 Then
                CPS = CPS + 50
                clicks_score = clicks_score - 150
                TextBox1.Text = clicks_score
                TextBox2.Text = CPS
                Grandma_B = Grandma_B + 1
            End If
        End If
    End Sub
End Class
