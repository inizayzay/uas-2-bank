<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostCenter
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
        Me.btnDeleteCostCenter = New System.Windows.Forms.Button()
        Me.btnEditCostCenter = New System.Windows.Forms.Button()
        Me.btnAddCostCenter = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbtDepartmentCC = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbtBranchCC = New System.Windows.Forms.ComboBox()
        Me.cbtDepartmenthCC = New System.Windows.Forms.ComboBox()
        Me.txtCCName = New System.Windows.Forms.TextBox()
        Me.dgvMasterCostCenter = New System.Windows.Forms.DataGridView()
        CType(Me.dgvMasterCostCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeleteCostCenter
        '
        Me.btnDeleteCostCenter.Location = New System.Drawing.Point(439, 128)
        Me.btnDeleteCostCenter.Name = "btnDeleteCostCenter"
        Me.btnDeleteCostCenter.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCostCenter.TabIndex = 21
        Me.btnDeleteCostCenter.Text = "Hapus"
        Me.btnDeleteCostCenter.UseVisualStyleBackColor = True
        '
        'btnEditCostCenter
        '
        Me.btnEditCostCenter.Location = New System.Drawing.Point(334, 128)
        Me.btnEditCostCenter.Name = "btnEditCostCenter"
        Me.btnEditCostCenter.Size = New System.Drawing.Size(75, 23)
        Me.btnEditCostCenter.TabIndex = 20
        Me.btnEditCostCenter.Text = "Edit"
        Me.btnEditCostCenter.UseVisualStyleBackColor = True
        '
        'btnAddCostCenter
        '
        Me.btnAddCostCenter.Location = New System.Drawing.Point(227, 128)
        Me.btnAddCostCenter.Name = "btnAddCostCenter"
        Me.btnAddCostCenter.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCostCenter.TabIndex = 19
        Me.btnAddCostCenter.Text = "Simpan"
        Me.btnAddCostCenter.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(125, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 16)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Name"
        '
        'cbtDepartmentCC
        '
        Me.cbtDepartmentCC.AutoSize = True
        Me.cbtDepartmentCC.Location = New System.Drawing.Point(122, 50)
        Me.cbtDepartmentCC.Name = "cbtDepartmentCC"
        Me.cbtDepartmentCC.Size = New System.Drawing.Size(77, 16)
        Me.cbtDepartmentCC.TabIndex = 17
        Me.cbtDepartmentCC.Text = "Department"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(122, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Branch"
        '
        'cbtBranchCC
        '
        Me.cbtBranchCC.FormattingEnabled = True
        Me.cbtBranchCC.Location = New System.Drawing.Point(227, 15)
        Me.cbtBranchCC.Name = "cbtBranchCC"
        Me.cbtBranchCC.Size = New System.Drawing.Size(182, 24)
        Me.cbtBranchCC.TabIndex = 15
        '
        'cbtDepartmenthCC
        '
        Me.cbtDepartmenthCC.FormattingEnabled = True
        Me.cbtDepartmenthCC.Location = New System.Drawing.Point(227, 50)
        Me.cbtDepartmenthCC.Name = "cbtDepartmenthCC"
        Me.cbtDepartmenthCC.Size = New System.Drawing.Size(182, 24)
        Me.cbtDepartmenthCC.TabIndex = 14
        '
        'txtCCName
        '
        Me.txtCCName.Location = New System.Drawing.Point(228, 88)
        Me.txtCCName.Name = "txtCCName"
        Me.txtCCName.Size = New System.Drawing.Size(182, 22)
        Me.txtCCName.TabIndex = 13
        '
        'dgvMasterCostCenter
        '
        Me.dgvMasterCostCenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterCostCenter.Location = New System.Drawing.Point(93, 178)
        Me.dgvMasterCostCenter.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMasterCostCenter.Name = "dgvMasterCostCenter"
        Me.dgvMasterCostCenter.RowHeadersWidth = 51
        Me.dgvMasterCostCenter.Size = New System.Drawing.Size(611, 288)
        Me.dgvMasterCostCenter.TabIndex = 12
        '
        'CostCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDeleteCostCenter)
        Me.Controls.Add(Me.btnEditCostCenter)
        Me.Controls.Add(Me.btnAddCostCenter)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbtDepartmentCC)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbtBranchCC)
        Me.Controls.Add(Me.cbtDepartmenthCC)
        Me.Controls.Add(Me.txtCCName)
        Me.Controls.Add(Me.dgvMasterCostCenter)
        Me.Name = "CostCenter"
        Me.Text = "CostCenter"
        CType(Me.dgvMasterCostCenter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteCostCenter As Button
    Friend WithEvents btnEditCostCenter As Button
    Friend WithEvents btnAddCostCenter As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents cbtDepartmentCC As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbtBranchCC As ComboBox
    Friend WithEvents cbtDepartmenthCC As ComboBox
    Friend WithEvents txtCCName As TextBox
    Friend WithEvents dgvMasterCostCenter As DataGridView
End Class
