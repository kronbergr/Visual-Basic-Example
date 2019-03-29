'Programmer: Robin Kronberg
'Project: Exercise 2.5 P. 101

Public Class frmMailingLabelInfo

    Private Sub btnDisplayLabelInfo_Click(sender As Object, e As EventArgs) Handles btnDisplayLabelInfo.Click
        'to display user input from text boxes in label info
        lblConcatenatedInfo.Text = txtFirstName.Text & " " & txtLastName.Text & Environment.NewLine & txtStreetAddress.Text & Environment.NewLine &
            txtCity.Text & ", " & txtState.Text & " " & maskedtxtZipCode.Text
    End Sub

    Private Sub btnClearInformation_Click(sender As Object, e As EventArgs) Handles btnClearInformation.Click
        'to clear all infomation
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtStreetAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        maskedtxtZipCode.Text = ""
        lblConcatenatedInfo.Text = ""
        txtFirstName.Focus()
        chkPuppy.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'to close the form
        Me.Close()
    End Sub

    Private Sub chkPuppy_CheckedChanged(sender As Object, e As EventArgs) Handles chkPuppy.CheckedChanged
        'to show the puppy picture
        picboxPuppy.Visible = chkPuppy.Checked
    End Sub
End Class
