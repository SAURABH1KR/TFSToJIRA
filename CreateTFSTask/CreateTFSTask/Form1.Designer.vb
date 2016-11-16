<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateTask
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblJiraTaskID = New System.Windows.Forms.Label()
        Me.txtJIRAID = New System.Windows.Forms.TextBox()
        Me.dgvQueryHistory = New System.Windows.Forms.DataGridView()
        Me.btnGetHistory = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChangedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvQueryHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(79, 60)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(199, 26)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Create a TFS Task "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(80, 109)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(46, 20)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title :"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(213, 109)
        Me.txtTitle.MaxLength = 500
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(461, 63)
        Me.txtTitle.TabIndex = 3
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(80, 193)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(97, 20)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description :"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(213, 193)
        Me.txtDescription.MaxLength = 500
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(461, 112)
        Me.txtDescription.TabIndex = 5
        '
        'lblJiraTaskID
        '
        Me.lblJiraTaskID.AutoSize = True
        Me.lblJiraTaskID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJiraTaskID.Location = New System.Drawing.Point(80, 335)
        Me.lblJiraTaskID.Name = "lblJiraTaskID"
        Me.lblJiraTaskID.Size = New System.Drawing.Size(70, 20)
        Me.lblJiraTaskID.TabIndex = 6
        Me.lblJiraTaskID.Text = "JIRA ID:"
        '
        'txtJIRAID
        '
        Me.txtJIRAID.Location = New System.Drawing.Point(213, 337)
        Me.txtJIRAID.Name = "txtJIRAID"
        Me.txtJIRAID.Size = New System.Drawing.Size(100, 20)
        Me.txtJIRAID.TabIndex = 7
        '
        'dgvQueryHistory
        '
        Me.dgvQueryHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQueryHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvQueryHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQueryHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Tags, Me.Title, Me.State, Me.Description, Me.ChangedBy, Me.CreatedDate})
        Me.dgvQueryHistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvQueryHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvQueryHistory.Location = New System.Drawing.Point(36, 502)
        Me.dgvQueryHistory.Name = "dgvQueryHistory"
        Me.dgvQueryHistory.ReadOnly = True
        Me.dgvQueryHistory.Size = New System.Drawing.Size(1052, 277)
        Me.dgvQueryHistory.TabIndex = 8
        '
        'btnGetHistory
        '
        Me.btnGetHistory.Location = New System.Drawing.Point(362, 390)
        Me.btnGetHistory.Name = "btnGetHistory"
        Me.btnGetHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnGetHistory.TabIndex = 9
        Me.btnGetHistory.Text = "Get History"
        Me.btnGetHistory.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "TFS Task ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 93
        '
        'Tags
        '
        Me.Tags.DataPropertyName = "Tags"
        Me.Tags.HeaderText = "JIRA Identifier"
        Me.Tags.Name = "Tags"
        Me.Tags.ReadOnly = True
        '
        'Title
        '
        Me.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Width = 52
        '
        'State
        '
        Me.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.State.DataPropertyName = "State"
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.ReadOnly = True
        Me.State.Width = 57
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 85
        '
        'ChangedBy
        '
        Me.ChangedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ChangedBy.DataPropertyName = "ChangedBy"
        Me.ChangedBy.HeaderText = "Changed By"
        Me.ChangedBy.Name = "ChangedBy"
        Me.ChangedBy.ReadOnly = True
        Me.ChangedBy.Width = 90
        '
        'CreatedDate
        '
        Me.CreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CreatedDate.DataPropertyName = "CreatedDate"
        Me.CreatedDate.HeaderText = "Created Date"
        Me.CreatedDate.Name = "CreatedDate"
        Me.CreatedDate.ReadOnly = True
        '
        'frmCreateTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 813)
        Me.Controls.Add(Me.btnGetHistory)
        Me.Controls.Add(Me.dgvQueryHistory)
        Me.Controls.Add(Me.txtJIRAID)
        Me.Controls.Add(Me.lblJiraTaskID)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblHeader)
        Me.MinimizeBox = False
        Me.Name = "frmCreateTask"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREATE TFS TASK"
        CType(Me.dgvQueryHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblJiraTaskID As System.Windows.Forms.Label
    Friend WithEvents txtJIRAID As System.Windows.Forms.TextBox
    Friend WithEvents dgvQueryHistory As System.Windows.Forms.DataGridView
    Friend WithEvents btnGetHistory As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tags As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChangedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedDate As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
