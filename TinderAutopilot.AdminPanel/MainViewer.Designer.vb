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
        Me.FacebookAccIDBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.SaveAuth = New MetroFramework.Controls.MetroButton()
        Me.TinderAuthBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.FacebookAuthBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.TagListView = New MetroFramework.Controls.MetroListView()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.LogBox = New System.Windows.Forms.TextBox()
        Me.FireSwitch = New MetroFramework.Controls.MetroToggle()
        Me.TinderWorker = New System.ComponentModel.BackgroundWorker()
        Me.OnFire = New System.Windows.Forms.PictureBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.CurrentUserLabel = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
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
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(754, 364)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton3)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton2)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage1.Controls.Add(Me.FacebookAccIDBox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.SaveAuth)
        Me.MetroTabPage1.Controls.Add(Me.TinderAuthBox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.FacebookAuthBox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.TagListView)
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
        'TagListView
        '
        Me.TagListView.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TagListView.FullRowSelect = True
        Me.TagListView.Location = New System.Drawing.Point(3, 104)
        Me.TagListView.Name = "TagListView"
        Me.TagListView.OwnerDraw = True
        Me.TagListView.Size = New System.Drawing.Size(102, 179)
        Me.TagListView.TabIndex = 3
        Me.TagListView.UseCompatibleStateImageBehavior = False
        Me.TagListView.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 53)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Instant Like Tags"
        '
        'MetroTabPage2
        '
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
        Me.OnFire.Location = New System.Drawing.Point(8, 30)
        Me.OnFire.Name = "OnFire"
        Me.OnFire.Size = New System.Drawing.Size(13, 15)
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
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(111, 75)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(56, 23)
        Me.MetroButton1.TabIndex = 11
        Me.MetroButton1.Text = "Add"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Enabled = False
        Me.MetroButton2.Location = New System.Drawing.Point(111, 130)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(56, 23)
        Me.MetroButton2.TabIndex = 12
        Me.MetroButton2.Text = "Del"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(111, 159)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(56, 23)
        Me.MetroButton3.TabIndex = 13
        Me.MetroButton3.Text = "Save"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(448, 6)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Current User:"
        '
        'CurrentUserLabel
        '
        Me.CurrentUserLabel.AutoSize = True
        Me.CurrentUserLabel.Location = New System.Drawing.Point(532, 6)
        Me.CurrentUserLabel.Name = "CurrentUserLabel"
        Me.CurrentUserLabel.Size = New System.Drawing.Size(112, 19)
        Me.CurrentUserLabel.TabIndex = 5
        Me.CurrentUserLabel.Text = ">Not Logged in<"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(80, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(3, 75)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(102, 23)
        Me.MetroTextBox1.TabIndex = 14
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MainViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CurrentUserLabel)
        Me.Controls.Add(Me.MetroLabel5)
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
    Friend WithEvents TagListView As MetroFramework.Controls.MetroListView
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
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CurrentUserLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
End Class
