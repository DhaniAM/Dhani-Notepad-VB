Public Class Form1
    Public Sub SaveNote()
        SaveFileDialog1.FileName = "Catatan"
        SaveFileDialog1.Filter = "Text Files | *.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim saveText As Integer = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel)
        If saveText = 6 Then
            SaveNote()
        ElseIf saveText = 7 Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveNote()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        If ColorDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.BackColor = ColorDialog2.Color
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Notepad ini dibuat oleh Ramadhani Adjar Mustaqim sebagai tugas UAS mata kuliah Pemrograman Visual")
    End Sub

    Private Sub AddNumber110ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNumber110ToolStripMenuItem.Click
        For i As Integer = 1 To 10
            Dim numberLoop As String
            numberLoop = CStr(i)
            TextBox1.AppendText(numberLoop + vbCrLf)
        Next
    End Sub

    Private Sub AddNumber1100ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNumber1100ToolStripMenuItem.Click
        For i As Integer = 1 To 100
            Dim numberLoop As String
            numberLoop = CStr(i)
            TextBox1.AppendText(numberLoop + vbCrLf)
        Next
    End Sub
End Class
