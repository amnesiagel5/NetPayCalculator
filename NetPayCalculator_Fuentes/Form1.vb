Public Class NetPay_Calculator

    Private Sub btnCalc_Netpay_Click(sender As Object, e As EventArgs) Handles btnCalc_Netpay.Click
        Dim netPay, calcAll, grossPay As Single
        Dim sss, philHealth, pagIbig, healthCare As Single

        grossPay = txtGross.Text
        sss = txtSSS.Text
        philHealth = txtPhilHealth.Text
        pagIbig = txtPhilHealth.Text
        healthCare = txtHealthcare.Text

        calcAll = sss + philHealth + pagIbig + healthCare
        netPay = grossPay - calcAll

        MsgBox("Hello! " & txtName.Text & "." & vbCrLf & "You're " & txtAge.Text & " years old." & vbCrLf & "Address: " & txtAddress.Text & "." & vbCrLf & "Net Pay: PHP " & netPay & ".")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        txtGross.Clear()
        txtSSS.Clear()
        txtPhilHealth.Clear()
        txtPagibig.Clear()
        txtHealthcare.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure to exit application?", "Net Pay Calculator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
