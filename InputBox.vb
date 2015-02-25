    Class InputBox
        Inherits Form

        Public Property Input As String
        WithEvents BtnO, BtnC As New Button
        Private Txt As New TextBox With {.Font = New Font("Segoe UI", 10)}
        Private Lbl As New Label With {.Font = New Font("Segoe UI", 12)}

        Sub New(Title As String, Optional Enable As Boolean = False)
            Text = "InputBox"
            Size = New Size(300, 200)
            ShowIcon = False
            ShowInTaskbar = False
            MinimizeBox = False
            MaximizeBox = False
            StartPosition = FormStartPosition.CenterScreen
            FormBorderStyle = FormBorderStyle.FixedDialog
            BtnO.Text = "Ok"
            BtnC.Text = "Cancel"
            Txt.Width = 220
            Txt.Location = New Point(20, 60)
            Lbl.Location = New Point(20, 20)
            BtnO.Location = New Point(200, 130)
            BtnC.Location = New Point(100, 130)
            Controls.AddRange({Txt, Lbl, BtnO, BtnC})
            Txt.Text = ""
            Lbl.Text = Title
            ControlBox = False
            BtnC.Visible = Enable
            AddHandler BtnC.Click, Sub()
                                       DialogResult = DialogResult.Cancel
                                       Close()
                                   End Sub
            AddHandler BtnO.Click, Sub()
                                       Input = Txt.Text
                                       DialogResult = If(Txt.Text = "", DialogResult.Cancel, DialogResult.OK)
                                       Close()
                                   End Sub
        End Sub
    End Class
