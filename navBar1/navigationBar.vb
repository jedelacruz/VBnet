<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sideBar = New System.Windows.Forms.Panel()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.sideBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'sideBar
        '
        Me.sideBar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.sideBar.Controls.Add(Me.Button4)
        Me.sideBar.Controls.Add(Me.Button3)
        Me.sideBar.Controls.Add(Me.Button2)
        Me.sideBar.Controls.Add(Me.Button1)
        Me.sideBar.Controls.Add(Me.logoPanel)
        Me.sideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideBar.Location = New System.Drawing.Point(0, 0)
        Me.sideBar.Name = "sideBar"
        Me.sideBar.Size = New System.Drawing.Size(211, 450)
        Me.sideBar.TabIndex = 0
        '
        'logoPanel
        '
        Me.logoPanel.BackgroundImage = CType(resources.GetObject("logoPanel.BackgroundImage"), System.Drawing.Image)
        Me.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logoPanel.Location = New System.Drawing.Point(0, 0)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(211, 94)
        Me.logoPanel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 44)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 182)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(211, 44)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(211, 44)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sideBar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.sideBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sideBar As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents logoPanel As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
