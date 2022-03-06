<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
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
        Me.components = New System.ComponentModel.Container()
        Me.lblgametick = New System.Windows.Forms.Label()
        Me.tmrgametick = New System.Windows.Forms.Timer(Me.components)
        Me.lblpopulation = New System.Windows.Forms.Label()
        Me.btnbreedlol = New System.Windows.Forms.Button()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.lblpop = New System.Windows.Forms.Label()
        Me.lblIdlePops = New System.Windows.Forms.Label()
        Me.lsvResources = New System.Windows.Forms.ListView()
        Me.clmResourcename = New System.Windows.Forms.ColumnHeader()
        Me.clmQuantity = New System.Windows.Forms.ColumnHeader()
        Me.clmRpS = New System.Windows.Forms.ColumnHeader()
        Me.btnjobwindow = New System.Windows.Forms.Button()
        Me.tmrparsetick = New System.Windows.Forms.Timer(Me.components)
        Me.lbldeaths = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblgametick
        '
        Me.lblgametick.AutoSize = True
        Me.lblgametick.Location = New System.Drawing.Point(13, 13)
        Me.lblgametick.Name = "lblgametick"
        Me.lblgametick.Size = New System.Drawing.Size(41, 15)
        Me.lblgametick.TabIndex = 0
        Me.lblgametick.Text = "Label1"
        '
        'tmrgametick
        '
        Me.tmrgametick.Enabled = True
        Me.tmrgametick.Interval = 10
        '
        'lblpopulation
        '
        Me.lblpopulation.AutoSize = True
        Me.lblpopulation.Location = New System.Drawing.Point(13, 50)
        Me.lblpopulation.Name = "lblpopulation"
        Me.lblpopulation.Size = New System.Drawing.Size(77, 15)
        Me.lblpopulation.TabIndex = 1
        Me.lblpopulation.Text = "Population: 0"
        '
        'btnbreedlol
        '
        Me.btnbreedlol.Location = New System.Drawing.Point(713, 13)
        Me.btnbreedlol.Name = "btnbreedlol"
        Me.btnbreedlol.Size = New System.Drawing.Size(75, 23)
        Me.btnbreedlol.TabIndex = 2
        Me.btnbreedlol.Text = "DO STUFF"
        Me.btnbreedlol.UseVisualStyleBackColor = True
        '
        'btnpause
        '
        Me.btnpause.Location = New System.Drawing.Point(713, 42)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(75, 23)
        Me.btnpause.TabIndex = 9
        Me.btnpause.Text = "PAUSE"
        Me.btnpause.UseVisualStyleBackColor = True
        '
        'lblpop
        '
        Me.lblpop.AutoSize = True
        Me.lblpop.Location = New System.Drawing.Point(13, 28)
        Me.lblpop.Name = "lblpop"
        Me.lblpop.Size = New System.Drawing.Size(93, 15)
        Me.lblpop.TabIndex = 10
        Me.lblpop.Text = "Population Stats"
        '
        'lblIdlePops
        '
        Me.lblIdlePops.AutoSize = True
        Me.lblIdlePops.Location = New System.Drawing.Point(13, 74)
        Me.lblIdlePops.Name = "lblIdlePops"
        Me.lblIdlePops.Size = New System.Drawing.Size(67, 15)
        Me.lblIdlePops.TabIndex = 11
        Me.lblIdlePops.Text = "Idle Pops: 0"
        '
        'lsvResources
        '
        Me.lsvResources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmResourcename, Me.clmQuantity, Me.clmRpS})
        Me.lsvResources.HideSelection = False
        Me.lsvResources.Location = New System.Drawing.Point(138, 28)
        Me.lsvResources.Name = "lsvResources"
        Me.lsvResources.Size = New System.Drawing.Size(288, 184)
        Me.lsvResources.TabIndex = 18
        Me.lsvResources.UseCompatibleStateImageBehavior = False
        Me.lsvResources.View = System.Windows.Forms.View.Details
        '
        'clmResourcename
        '
        Me.clmResourcename.Text = "Resource"
        '
        'clmQuantity
        '
        Me.clmQuantity.Text = "Quantity"
        '
        'clmRpS
        '
        Me.clmRpS.Text = "Per Sec"
        '
        'btnjobwindow
        '
        Me.btnjobwindow.Location = New System.Drawing.Point(713, 72)
        Me.btnjobwindow.Name = "btnjobwindow"
        Me.btnjobwindow.Size = New System.Drawing.Size(75, 23)
        Me.btnjobwindow.TabIndex = 19
        Me.btnjobwindow.Text = "JOBS"
        Me.btnjobwindow.UseVisualStyleBackColor = True
        '
        'tmrparsetick
        '
        Me.tmrparsetick.Enabled = True
        Me.tmrparsetick.Interval = 10
        '
        'lbldeaths
        '
        Me.lbldeaths.AutoSize = True
        Me.lbldeaths.Location = New System.Drawing.Point(12, 98)
        Me.lbldeaths.Name = "lbldeaths"
        Me.lbldeaths.Size = New System.Drawing.Size(55, 15)
        Me.lbldeaths.TabIndex = 20
        Me.lbldeaths.Text = "Deaths: 0"
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbldeaths)
        Me.Controls.Add(Me.btnjobwindow)
        Me.Controls.Add(Me.lsvResources)
        Me.Controls.Add(Me.lblIdlePops)
        Me.Controls.Add(Me.lblpop)
        Me.Controls.Add(Me.btnpause)
        Me.Controls.Add(Me.btnbreedlol)
        Me.Controls.Add(Me.lblpopulation)
        Me.Controls.Add(Me.lblgametick)
        Me.Name = "MainView"
        Me.Text = "PopGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblgametick As Label
    Friend WithEvents tmrgametick As Timer
    Friend WithEvents lblpopulation As Label
    Friend WithEvents btnbreedlol As Button
    Friend WithEvents btnpause As Button
    Friend WithEvents lblpop As Label
    Friend WithEvents lblIdlePops As Label
    Friend WithEvents lsvResources As ListView
    Friend WithEvents clmResourcename As ColumnHeader
    Friend WithEvents clmQuantity As ColumnHeader
    Friend WithEvents clmRpS As ColumnHeader
    Friend WithEvents btnjobwindow As Button
    Friend WithEvents tmrparsetick As Timer
    Friend WithEvents lbldeaths As Label
End Class
