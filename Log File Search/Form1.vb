Imports System.ComponentModel
Imports System.IO
Public Class Form1
    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        ''If log file(s) were selected, set the fields in the form to display the directory or a single filename,
        ''and set the progressbar max number of lines.
        If Me.OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.ToolStripProgressBar1.Value = 0
            Me.ToolStripStatusLabel1.Text = ""

            If Me.OpenFileDialog1.FileNames.Count = 1 Then
                Me.txtSource.Text = Me.OpenFileDialog1.FileName
            Else
                Me.txtSource.Text = Path.GetDirectoryName(Me.OpenFileDialog1.FileName)
            End If

            Dim i As Long

            For Each s As String In Me.OpenFileDialog1.FileNames
                i += File.ReadAllLines(s).Length
            Next

            Me.ToolStripProgressBar1.Maximum = i
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ''Create a file to save search results into.
        If Me.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.txtSave.Text = Me.SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ''Run the log search as long as a search parameter is given, a log file to search has been chosen
        ''and a place to save the file has been selected.
        If Me.txtSearch.Text <> "" And Me.txtSource.Text <> "" And Me.txtSave.Text <> "" Then
            Me.ToolStripStatusLabel1.Text = ""
            Me.ToolStripProgressBar1.Value = 0
            Me.btnSource.Enabled = False
            Me.btnSave.Enabled = False
            Me.btnProcess.Enabled = False
            Me.txtSearch.Enabled = False
            Me.GroupBox1.Enabled = False
            Me.BackgroundWorker1.RunWorkerAsync()
        Else
            MsgBox("Please select a source file, a save file destination, and a word or phrase to search.")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        FileTask()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ToolStripProgressBar1.PerformStep()
        Me.ToolStripStatusLabel1.Text = CStr(CInt((e.ProgressPercentage / Me.ToolStripProgressBar1.Maximum) * 100)) + "%"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ChangeGUI()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ToolStripStatusLabel1.Text = ""
    End Sub

    Public Sub FileTask()
        ''On another thread, create the save file and search for the search keyword provided
        ''excluding any exclusion keywords from being added to the file.
        Dim saveStream As Stream = Me.SaveFileDialog1.OpenFile()
        Dim sWrite As StreamWriter = New StreamWriter(saveStream)

        Dim fileName As String

        Dim i As Integer = 0
        Try
            sWrite.WriteLine("Search: " & txtSearch.Text & ", Exclude: " & txtExclude.Text)
            For Each fileName In Me.OpenFileDialog1.FileNames
                Dim openStream As New StreamReader(fileName)
                Dim lines As New List(Of String)
                Dim position As Integer = -1
                Try
                    Do While openStream.EndOfStream = False
                        Dim strRead As String = openStream.ReadLine
                        lines.Add(strRead)
                        position += 1
                        If strRead.Contains(Me.txtSearch.Text) Then
                            If Not String.IsNullOrWhiteSpace(Me.txtExclude.Text) Then
                                If Not strRead.Contains(Me.txtExclude.Text) Then
                                    If chkBefore.Checked Then
                                        Try
                                            For index = position - numBefore.Value To position - 1
                                                sWrite.WriteLine(lines.Item(index).ToString & " - " & fileName)
                                            Next
                                        Catch ex As Exception

                                        End Try
                                    End If

                                    sWrite.WriteLine(strRead & " - " & fileName)
                                End If
                            Else
                                If chkBefore.Checked Then
                                    Try
                                        For index = position - numBefore.Value To position - 1
                                            sWrite.WriteLine(lines.Item(index).ToString & " - " & fileName)
                                        Next
                                    Catch ex As Exception

                                    End Try
                                End If

                                sWrite.WriteLine(strRead & " - " & fileName)
                            End If

                        End If
                        i += 1
                        BackgroundWorker1.ReportProgress(i)
                    Loop

                    openStream.Close()

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                Finally
                    If openStream IsNot Nothing Then
                        openStream.Close()
                    End If

                End Try
            Next

            sWrite.Close()
            saveStream.Close()
            sWrite.Dispose()
            saveStream.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            If sWrite IsNot Nothing Then
                sWrite.Close()
            End If
        End Try

    End Sub
    ''' <summary>
    ''' Change form after search has been performed.
    ''' </summary>
    Public Sub ChangeGUI()
        Me.btnSource.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnProcess.Enabled = True
        Me.txtSearch.Enabled = True
        Me.GroupBox1.Enabled = True

        Me.txtSource.Text = ""
        Me.txtSave.Text = ""
        Me.txtSearch.Text = ""
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
    End Sub

    Private Sub chkBefore_CheckedChanged(sender As Object, e As EventArgs) Handles chkBefore.CheckedChanged
        If chkBefore.Checked Then
            numBefore.Enabled = True
        Else
            numBefore.Enabled = False
        End If
    End Sub

    Private Sub chkAfter_CheckedChanged(sender As Object, e As EventArgs) Handles chkAfter.CheckedChanged
        If chkAfter.Checked Then
            numAfter.Enabled = True
        Else
            numAfter.Enabled = False
        End If
    End Sub
End Class
