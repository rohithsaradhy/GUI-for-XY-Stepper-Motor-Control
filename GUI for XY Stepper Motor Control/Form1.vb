Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.PortName = TextBox3.Text
        SerialPort1.Open()

        If CheckBox1.Checked = True Then
            SerialPort1.Write("-" + TextBox1.Text + vbCrLf)
        Else
            SerialPort1.Write(TextBox1.Text + vbCrLf)
        End If
        If CheckBox2.Checked = True Then
            SerialPort1.Write("-" + TextBox2.Text + vbCrLf)
        Else
            SerialPort1.Write(TextBox2.Text + vbCrLf)
        End If
        SerialPort1.Close()

    End Sub

   
End Class
