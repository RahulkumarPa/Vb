Option Strict On
Imports System.IO 'To Import Input Output Library

'Author: Rahulkumar Patel
'Project Name: TextEditor
'Date: 18-July-2018
'Description: This application is a Text editor with menu stream and open,new,save,save as,copy,cut,paste,about Menu.

Public Class frmTextEditor
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'To copy text
    Private Sub CopyCtrlCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        Dim textSelected As String = String.Empty   'Declear string to get the selected text
        textSelected = txtInput.SelectedText        'initilize the selected text in string variable.
        My.Computer.Clipboard.SetText(textSelected) 'Set selected text in clipboard 
    End Sub

    'To Paste
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        txtInput.Paste()
    End Sub

    'To Clear text
    Private Sub NewCtrlNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuNewFile.Click
        txtInput.Clear()
    End Sub

    'To open the File
    Private Sub OpenCtrlOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOpenFile.Click
        Dim ofd As New OpenFileDialog            'To open File Dialog
        Dim fl As String                         ' String to read File path
        ofd.Filter = "txt files (*.txt)|*.txt"   'Filter to openfile dialog box to *.txt file
        ofd.ShowDialog()                         'To display file dialog
        fl = ofd.FileName
        Dim sr As New StreamReader(fl)
        txtInput.Text = sr.ReadToEnd()           'To set text
        sr.Close()                               'To close
    End Sub
    Private Sub SaveCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuSaveFile.Click
        Dim sfd As New SaveFileDialog           'To open File Dialog to save
        Dim sf As String                        'String to read File Path
        sfd.Filter = "txt files (*.txt)|*.txt"  'Filter to save txt file
        sfd.ShowDialog()
        sf = sfd.FileName
        Dim sw As New StreamWriter(sf)
        sw.Write(txtInput)                       'To set text
        sw.Close()                               'To close
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub PasteCtrlVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        Dim textSelected As String = String.Empty   'Declear string to get the selected text
        textSelected = txtInput.SelectedText        'initilize the selected text in string variable.
        txtInput.SelectedText = " "                  'Delete the selected Text
        My.Computer.Clipboard.SetText(textSelected) 'Set selected text in clipboard 
    End Sub

    Private Sub SaveasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuSaveas.Click
        Dim sfd As New SaveFileDialog           'To open File Dialog to save
        Dim sf As String                        'String to read File Path
        sfd.Filter = "txt files (*.txt)|*.txt"  'Filter to save txt file
        sfd.ShowDialog()
        sf = sfd.FileName
        Dim sw As New StreamWriter(sf)
        sw.Write(txtInput)                       'To set text
        sw.Close()                               'To close
    End Sub

    'To Show the Message Box.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("NETD-2202" & vbCrLf & "Lab#5" & vbCrLf & "Rahulkumar Patel", "About")
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        txtInput.Clear()
    End Sub
End Class
