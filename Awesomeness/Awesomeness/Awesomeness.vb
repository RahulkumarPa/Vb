'Filename : Awesomeness
'Name : Rahulkumar Patel
'Lastupdate: 16,May 2018
'Descriotion : 
Public Class frmAwesomeness

    Private Sub Awesomeness_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblAwesomenessPrompt.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNo3.Click
        btnYes1.Hide()
        btnNo2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnYes1.Click
        Me.Close()


    End Sub

    Private Sub btnNo2_Click(sender As Object, e As EventArgs) Handles btnNo2.Click
        btnYes1.Show()
        btnNo3.Hide()

    End Sub
End Class
