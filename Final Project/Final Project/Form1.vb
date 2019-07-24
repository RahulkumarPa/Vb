Option Strict On
Imports System.IO 'To Import Input Output Library

'Author: Rahulkumar Patel
'Project Name: TextEditor
'Date: 28-July-2018
'Description: This application is a Text editor with menu stream and open,new,save,save as,copy,cut,paste,about Menu.
Public Class Form1
    Private m_NewFileNumber As Integer              'Declear the File Number
    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click

    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        Dim textSelected As String = String.Empty   'Declear string to get the selected text
        textSelected = txtInput.SelectedText        'initilize the selected text in string variable.
        My.Computer.Clipboard.SetText(textSelected) 'Set selected text in clipboard 
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        'Initilize Child Form
        Dim frmTextEditor As New frmTextEditor

        frmTextEditor.MdiParent = Me        'Initialize child form in Parent

        m_NewFileNumber += 1            'Increse the File number

        frmTextEditor.Text = " New " & m_NewFileNumber        'Make name of form to New(1)

        frmTextEditor.Show()        'Show the Child Form
    End Sub
End Class
