Imports System.Net
Imports System.IO
Public Class Form7
    Private WithEvents downloadClient As WebClient
    Private fileToDownload As String
    Private isPaused As Boolean = False
    Private downloadedBytes As Long = 0
    Private totalBytes As Long = 0
    Private isDownloaded As Boolean = False
    'Private filesToDownload As List(Of String) = New List(Of String)({"https://latinbattle.com/w3/descargas/JuegoCompleto.exe", "https://latinbattle.com/w3/descargas/GProxy.rar", "https://latinbattle.com/w3/descargas/War3TFT_127b_Castellano.exe"})
    Private filesToDownload As List(Of String) = New List(Of String)({"https://latinbattle.com/w3/descargas/GProxy.rar"})
    Private currentFileIndex As Integer = 0
    Private downloadFolder As String = " "

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        Dim folderBrowser As New FolderBrowserDialog()
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = folderBrowser.SelectedPath
            downloadFolder = TextBox1.Text

            filesToDownload = New List(Of String)({"https://latinbattle.com/w3/descargas/GProxy.rar"})
            currentFileIndex = 0
            downloadNextFile()
            btnDownload.Enabled = False

            If filesToDownload.Count > 0 Then
                currentFileIndex = 0

                downloadNextFile()
            End If
        End If

    End Sub
    Private Sub downloadNextFile()
        fileToDownload = filesToDownload(currentFileIndex)
        downloadClient = New WebClient()
        downloadClient.DownloadFileAsync(New Uri(fileToDownload), Path.GetFileName(fileToDownload))
    End Sub

  Private Sub downloadClient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloadClient.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        downloadedBytes = e.BytesReceived
        totalBytes = e.TotalBytesToReceive
        lblProgress.Text = String.Format("{0} MB of {1} MB downloaded ({2}% complete)", Math.Round(downloadedBytes / 1048576, 2), Math.Round(totalBytes / 1048576, 2), e.ProgressPercentage)
    End Sub

    Private Sub downloadClient_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles downloadClient.DownloadFileCompleted
        isDownloaded = True
        lblProgress.Text = "Download complete!"
        ListBox1.Items.Add(Path.GetFileName(fileToDownload))
        currentFileIndex += 1
        If currentFileIndex < filesToDownload.Count Then
            downloadNextFile()
        Else
            btnDownload.Enabled = False

        End If
    End Sub

End Class