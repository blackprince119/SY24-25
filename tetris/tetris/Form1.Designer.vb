<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Timer1 = New Timer(components)
        avatar = New PictureBox()
        enemy = New PictureBox()
        food = New PictureBox()
        enemy2 = New PictureBox()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(food, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 150
        ' 
        ' avatar
        ' 
        avatar.Image = CType(resources.GetObject("avatar.Image"), Image)
        avatar.Location = New Point(30, 26)
        avatar.Name = "avatar"
        avatar.Size = New Size(113, 90)
        avatar.SizeMode = PictureBoxSizeMode.Zoom
        avatar.TabIndex = 1
        avatar.TabStop = False
        ' 
        ' enemy
        ' 
        enemy.Image = CType(resources.GetObject("enemy.Image"), Image)
        enemy.Location = New Point(1, 350)
        enemy.Name = "enemy"
        enemy.Size = New Size(113, 90)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' food
        ' 
        food.Image = CType(resources.GetObject("food.Image"), Image)
        food.Location = New Point(275, 53)
        food.Name = "food"
        food.Size = New Size(68, 63)
        food.SizeMode = PictureBoxSizeMode.Zoom
        food.TabIndex = 3
        food.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = CType(resources.GetObject("enemy2.Image"), Image)
        enemy2.Location = New Point(615, 350)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(113, 90)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 4
        enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(728, 517)
        Controls.Add(enemy2)
        Controls.Add(food)
        Controls.Add(enemy)
        Controls.Add(avatar)
        Name = "Form1"
        Text = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(food, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents avatar As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents food As PictureBox
    Friend WithEvents enemy2 As PictureBox

End Class
