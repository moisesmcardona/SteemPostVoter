Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create("https://api.steem.place/vote/")
            request.Method = "POST"
            Dim postData As String = "i=" & identifier.Text & "&w=" & weight.Value.ToString("F1") & "&v=" & voter.Text & "&pk=" & pk.Text
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            If responseFromServer = "ok" Then
                MessageBox.Show("Voted successfully")
            Else
                MessageBox.Show("An error occured while voting.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred.")
        End Try
    End Sub
End Class
