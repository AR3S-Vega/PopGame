<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jobs
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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.lsvJobs = New System.Windows.Forms.ListView()
        Me.clmJobs = New System.Windows.Forms.ColumnHeader()
        Me.clmAssigned = New System.Windows.Forms.ColumnHeader()
        Me.cmbJobSelect = New System.Windows.Forms.ComboBox()
        Me.btnComboAdd = New System.Windows.Forms.Button()
        Me.btnComboSub = New System.Windows.Forms.Button()
        Me.tmrrefreshlsv = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Foragers = 0"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(21, 75)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(23, 23)
        Me.Button9.TabIndex = 30
        Me.Button9.Text = "-"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'lsvJobs
        '
        Me.lsvJobs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmJobs, Me.clmAssigned})
        Me.lsvJobs.HideSelection = False
        Me.lsvJobs.Location = New System.Drawing.Point(12, 12)
        Me.lsvJobs.Name = "lsvJobs"
        Me.lsvJobs.Size = New System.Drawing.Size(219, 109)
        Me.lsvJobs.TabIndex = 31
        Me.lsvJobs.UseCompatibleStateImageBehavior = False
        Me.lsvJobs.View = System.Windows.Forms.View.Details
        '
        'clmJobs
        '
        Me.clmJobs.Text = "Jobs"
        '
        'clmAssigned
        '
        Me.clmAssigned.Text = "Assigned"
        '
        'cmbJobSelect
        '
        Me.cmbJobSelect.FormattingEnabled = True
        Me.cmbJobSelect.Location = New System.Drawing.Point(12, 128)
        Me.cmbJobSelect.Name = "cmbJobSelect"
        Me.cmbJobSelect.Size = New System.Drawing.Size(159, 23)
        Me.cmbJobSelect.TabIndex = 32
        '
        'btnComboAdd
        '
        Me.btnComboAdd.Location = New System.Drawing.Point(207, 128)
        Me.btnComboAdd.Name = "btnComboAdd"
        Me.btnComboAdd.Size = New System.Drawing.Size(24, 23)
        Me.btnComboAdd.TabIndex = 33
        Me.btnComboAdd.Text = "+"
        Me.btnComboAdd.UseVisualStyleBackColor = True
        '
        'btnComboSub
        '
        Me.btnComboSub.Location = New System.Drawing.Point(177, 128)
        Me.btnComboSub.Name = "btnComboSub"
        Me.btnComboSub.Size = New System.Drawing.Size(24, 23)
        Me.btnComboSub.TabIndex = 34
        Me.btnComboSub.Text = "-"
        Me.btnComboSub.UseVisualStyleBackColor = True
        '
        'tmrrefreshlsv
        '
        Me.tmrrefreshlsv.Enabled = True
        '
        'Jobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 163)
        Me.Controls.Add(Me.btnComboSub)
        Me.Controls.Add(Me.btnComboAdd)
        Me.Controls.Add(Me.cmbJobSelect)
        Me.Controls.Add(Me.lsvJobs)
        Me.Name = "Jobs"
        Me.Text = "Jobs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents lsvJobs As ListView
    Friend WithEvents clmJobs As ColumnHeader
    Friend WithEvents clmAssigned As ColumnHeader
    Friend WithEvents cmbJobSelect As ComboBox
    Friend WithEvents btnComboAdd As Button
    Friend WithEvents btnComboSub As Button
    Friend WithEvents tmrrefreshlsv As Timer
End Class
