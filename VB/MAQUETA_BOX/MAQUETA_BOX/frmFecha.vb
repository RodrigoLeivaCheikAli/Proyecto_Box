Public Class FechaForm
    Public Property FechaSeleccionada As DateTime

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        FechaSeleccionada = DateTimePicker1.Value
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class