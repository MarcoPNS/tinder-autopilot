<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainViewer
    Inherits MetroFramework.Forms.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainViewer))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.TagListView = New System.Windows.Forms.ListBox()
        Me.CurrentUserLabel = New MetroFramework.Controls.MetroLabel()
        Me.AddTagBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.DelTagItem = New MetroFramework.Controls.MetroButton()
        Me.AddTagButton = New MetroFramework.Controls.MetroButton()
        Me.FacebookAccIDBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.SaveAuth = New MetroFramework.Controls.MetroButton()
        Me.TinderAuthBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.FacebookAuthBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.LogBox = New System.Windows.Forms.TextBox()
        Me.FireSwitch = New MetroFramework.Controls.MetroToggle()
        Me.TinderWorker = New System.ComponentModel.BackgroundWorker()
        Me.OnFire = New System.Windows.Forms.PictureBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.OnFire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(22, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(754, 364)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.LinkLabel2)
        Me.MetroTabPage1.Controls.Add(Me.LinkLabel1)
        Me.MetroTabPage1.Controls.Add(Me.TagListView)
        Me.MetroTabPage1.Controls.Add(Me.CurrentUserLabel)
        Me.MetroTabPage1.Controls.Add(Me.AddTagBox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton3)
        Me.MetroTabPage1.Controls.Add(Me.DelTagItem)
        Me.MetroTabPage1.Controls.Add(Me.AddTagButton)
        Me.MetroTabPage1.Controls.Add(Me.FacebookAccIDBox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.SaveAuth)
        Me.MetroTabPage1.Controls.Add(Me.TinderAuthBox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.FacebookAuthBox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(746, 322)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "General Settings"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'TagListView
        '
        Me.TagListView.FormattingEnabled = True
        Me.TagListView.Location = New System.Drawing.Point(3, 121)
        Me.TagListView.Name = "TagListView"
        Me.TagListView.Size = New System.Drawing.Size(132, 160)
        Me.TagListView.TabIndex = 15
        '
        'CurrentUserLabel
        '
        Me.CurrentUserLabel.AutoSize = True
        Me.CurrentUserLabel.Location = New System.Drawing.Point(87, 293)
        Me.CurrentUserLabel.Name = "CurrentUserLabel"
        Me.CurrentUserLabel.Size = New System.Drawing.Size(112, 19)
        Me.CurrentUserLabel.TabIndex = 5
        Me.CurrentUserLabel.Text = ">Not Logged in<"
        '
        'AddTagBox
        '
        '
        '
        '
        Me.AddTagBox.CustomButton.Image = Nothing
        Me.AddTagBox.CustomButton.Location = New System.Drawing.Point(110, 1)
        Me.AddTagBox.CustomButton.Name = ""
        Me.AddTagBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.AddTagBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AddTagBox.CustomButton.TabIndex = 1
        Me.AddTagBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AddTagBox.CustomButton.UseSelectable = True
        Me.AddTagBox.CustomButton.Visible = False
        Me.AddTagBox.Lines = New String(-1) {}
        Me.AddTagBox.Location = New System.Drawing.Point(3, 92)
        Me.AddTagBox.MaxLength = 32767
        Me.AddTagBox.Name = "AddTagBox"
        Me.AddTagBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddTagBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AddTagBox.SelectedText = ""
        Me.AddTagBox.SelectionLength = 0
        Me.AddTagBox.SelectionStart = 0
        Me.AddTagBox.ShortcutsEnabled = True
        Me.AddTagBox.Size = New System.Drawing.Size(132, 23)
        Me.AddTagBox.TabIndex = 14
        Me.AddTagBox.UseSelectable = True
        Me.AddTagBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AddTagBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 293)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Current User:"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(141, 176)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(56, 23)
        Me.MetroButton3.TabIndex = 13
        Me.MetroButton3.Text = "Save"
        Me.MetroButton3.UseSelectable = True
        '
        'DelTagItem
        '
        Me.DelTagItem.Enabled = False
        Me.DelTagItem.Location = New System.Drawing.Point(141, 147)
        Me.DelTagItem.Name = "DelTagItem"
        Me.DelTagItem.Size = New System.Drawing.Size(56, 23)
        Me.DelTagItem.TabIndex = 12
        Me.DelTagItem.Text = "Del"
        Me.DelTagItem.UseSelectable = True
        '
        'AddTagButton
        '
        Me.AddTagButton.Enabled = False
        Me.AddTagButton.Location = New System.Drawing.Point(141, 92)
        Me.AddTagButton.Name = "AddTagButton"
        Me.AddTagButton.Size = New System.Drawing.Size(56, 23)
        Me.AddTagButton.TabIndex = 11
        Me.AddTagButton.Text = "Add"
        Me.AddTagButton.UseSelectable = True
        '
        'FacebookAccIDBox
        '
        '
        '
        '
        Me.FacebookAccIDBox.CustomButton.Image = Nothing
        Me.FacebookAccIDBox.CustomButton.Location = New System.Drawing.Point(110, 1)
        Me.FacebookAccIDBox.CustomButton.Name = ""
        Me.FacebookAccIDBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.FacebookAccIDBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FacebookAccIDBox.CustomButton.TabIndex = 1
        Me.FacebookAccIDBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FacebookAccIDBox.CustomButton.UseSelectable = True
        Me.FacebookAccIDBox.CustomButton.Visible = False
        Me.FacebookAccIDBox.Lines = New String(-1) {}
        Me.FacebookAccIDBox.Location = New System.Drawing.Point(3, 27)
        Me.FacebookAccIDBox.MaxLength = 32767
        Me.FacebookAccIDBox.Name = "FacebookAccIDBox"
        Me.FacebookAccIDBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FacebookAccIDBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FacebookAccIDBox.SelectedText = ""
        Me.FacebookAccIDBox.SelectionLength = 0
        Me.FacebookAccIDBox.SelectionStart = 0
        Me.FacebookAccIDBox.ShortcutsEnabled = True
        Me.FacebookAccIDBox.Size = New System.Drawing.Size(132, 23)
        Me.FacebookAccIDBox.TabIndex = 10
        Me.FacebookAccIDBox.UseSelectable = True
        Me.FacebookAccIDBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FacebookAccIDBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 5)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Facebook Account ID"
        '
        'SaveAuth
        '
        Me.SaveAuth.Location = New System.Drawing.Point(422, 27)
        Me.SaveAuth.Name = "SaveAuth"
        Me.SaveAuth.Size = New System.Drawing.Size(56, 23)
        Me.SaveAuth.TabIndex = 8
        Me.SaveAuth.Text = "Save"
        Me.SaveAuth.UseSelectable = True
        '
        'TinderAuthBox
        '
        '
        '
        '
        Me.TinderAuthBox.CustomButton.Image = Nothing
        Me.TinderAuthBox.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.TinderAuthBox.CustomButton.Name = ""
        Me.TinderAuthBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TinderAuthBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TinderAuthBox.CustomButton.TabIndex = 1
        Me.TinderAuthBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TinderAuthBox.CustomButton.UseSelectable = True
        Me.TinderAuthBox.CustomButton.Visible = False
        Me.TinderAuthBox.Lines = New String(-1) {}
        Me.TinderAuthBox.Location = New System.Drawing.Point(291, 27)
        Me.TinderAuthBox.MaxLength = 32767
        Me.TinderAuthBox.Name = "TinderAuthBox"
        Me.TinderAuthBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TinderAuthBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TinderAuthBox.SelectedText = ""
        Me.TinderAuthBox.SelectionLength = 0
        Me.TinderAuthBox.SelectionStart = 0
        Me.TinderAuthBox.ShortcutsEnabled = True
        Me.TinderAuthBox.Size = New System.Drawing.Size(125, 23)
        Me.TinderAuthBox.TabIndex = 7
        Me.TinderAuthBox.UseSelectable = True
        Me.TinderAuthBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TinderAuthBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(291, 5)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Tinder Access Token"
        '
        'FacebookAuthBox
        '
        '
        '
        '
        Me.FacebookAuthBox.CustomButton.Image = Nothing
        Me.FacebookAuthBox.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.FacebookAuthBox.CustomButton.Name = ""
        Me.FacebookAuthBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.FacebookAuthBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FacebookAuthBox.CustomButton.TabIndex = 1
        Me.FacebookAuthBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FacebookAuthBox.CustomButton.UseSelectable = True
        Me.FacebookAuthBox.CustomButton.Visible = False
        Me.FacebookAuthBox.Lines = New String(-1) {}
        Me.FacebookAuthBox.Location = New System.Drawing.Point(141, 27)
        Me.FacebookAuthBox.MaxLength = 32767
        Me.FacebookAuthBox.Name = "FacebookAuthBox"
        Me.FacebookAuthBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FacebookAuthBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FacebookAuthBox.SelectedText = ""
        Me.FacebookAuthBox.SelectionLength = 0
        Me.FacebookAuthBox.SelectionStart = 0
        Me.FacebookAuthBox.ShortcutsEnabled = True
        Me.FacebookAuthBox.Size = New System.Drawing.Size(144, 23)
        Me.FacebookAuthBox.TabIndex = 5
        Me.FacebookAuthBox.UseSelectable = True
        Me.FacebookAuthBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FacebookAuthBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(141, 5)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(144, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Facebook OAuth Token"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 70)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Instant Like Tags"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.WebBrowser1)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(746, 322)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Swipes"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.LogBox)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(746, 322)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Log"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'LogBox
        '
        Me.LogBox.Location = New System.Drawing.Point(0, 3)
        Me.LogBox.Multiline = True
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LogBox.Size = New System.Drawing.Size(743, 326)
        Me.LogBox.TabIndex = 2
        '
        'FireSwitch
        '
        Me.FireSwitch.AutoSize = True
        Me.FireSwitch.Location = New System.Drawing.Point(198, 30)
        Me.FireSwitch.Name = "FireSwitch"
        Me.FireSwitch.Size = New System.Drawing.Size(80, 17)
        Me.FireSwitch.Style = MetroFramework.MetroColorStyle.Orange
        Me.FireSwitch.TabIndex = 1
        Me.FireSwitch.Text = "Aus"
        Me.FireSwitch.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FireSwitch.UseSelectable = True
        '
        'TinderWorker
        '
        Me.TinderWorker.WorkerReportsProgress = True
        Me.TinderWorker.WorkerSupportsCancellation = True
        '
        'OnFire
        '
        Me.OnFire.Image = Global.TinderAutopilot.AdminPanel.My.Resources.Resources.fire
        Me.OnFire.Location = New System.Drawing.Point(4, 30)
        Me.OnFire.Name = "OnFire"
        Me.OnFire.Size = New System.Drawing.Size(17, 15)
        Me.OnFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OnFire.TabIndex = 2
        Me.OnFire.TabStop = False
        Me.OnFire.Visible = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(26, 430)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(124, 13)
        Me.StatusLabel.TabIndex = 3
        Me.StatusLabel.Text = "Hi! This is a Status Label"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(261, 53)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(24, 13)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Get"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Location = New System.Drawing.Point(111, 53)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(24, 13)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Get"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(668, 3)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "Refresh"
        Me.MetroButton1.UseSelectable = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 32)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(740, 287)
        Me.WebBrowser1.TabIndex = 4
        Me.WebBrowser1.Url = New System.Uri("file:///C:/Users/marco/source/repos/tinder-autopilot/TinderAutopilot.AdminPanel/b" &
        "in/Debug/swipes.html", System.UriKind.Absolute)
        '
        'MainViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.OnFire)
        Me.Controls.Add(Me.FireSwitch)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainViewer"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Tinder Autopilot"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.OnFire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents FireSwitch As MetroFramework.Controls.MetroToggle
    Friend WithEvents TinderWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents OnFire As PictureBox
    Friend WithEvents FacebookAuthBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LogBox As TextBox
    Friend WithEvents TinderAuthBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SaveAuth As MetroFramework.Controls.MetroButton
    Friend WithEvents FacebookAccIDBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents StatusLabel As Label
    Friend WithEvents DelTagItem As MetroFramework.Controls.MetroButton
    Friend WithEvents AddTagButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CurrentUserLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents AddTagBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TagListView As ListBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
