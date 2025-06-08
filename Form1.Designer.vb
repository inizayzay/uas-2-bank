<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BankGeneralLedgerApp
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.header = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbTransaksi = New System.Windows.Forms.GroupBox()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnRejectJournal = New System.Windows.Forms.Button()
        Me.btnAddJournal = New System.Windows.Forms.Button()
        Me.btnApproveJournal = New System.Windows.Forms.Button()
        Me.txtDebit = New System.Windows.Forms.TextBox()
        Me.btnPostJournal = New System.Windows.Forms.Button()
        Me.btnReverseJournal = New System.Windows.Forms.Button()
        Me.txtCostCenterID = New System.Windows.Forms.TextBox()
        Me.txtLedgerID = New System.Windows.Forms.TextBox()
        Me.txtDepartmentID = New System.Windows.Forms.TextBox()
        Me.txtTransaksiBranchID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabMasterBranch = New System.Windows.Forms.TabPage()
        Me.dgvMasterBranch = New System.Windows.Forms.DataGridView()
        Me.gbMasterBranch = New System.Windows.Forms.GroupBox()
        Me.btnDeleteBranch = New System.Windows.Forms.Button()
        Me.btnEditBranch = New System.Windows.Forms.Button()
        Me.btnAddBranch = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.txtMasterBranchID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabDataJurnal = New System.Windows.Forms.TabPage()
        Me.btnSelanjutnya = New System.Windows.Forms.Button()
        Me.btnRefreshJurnal = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.dgvJournalEntri = New System.Windows.Forms.DataGridView()
        Me.tabTransaksi = New System.Windows.Forms.TabPage()
        Me.tabLaporan = New System.Windows.Forms.TabPage()
        Me.chartGrafikSaldo = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.gbLaporan = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpPeriode = New System.Windows.Forms.DateTimePicker()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.TabDepartment = New System.Windows.Forms.TabPage()
        Me.btnDeleteDept = New System.Windows.Forms.Button()
        Me.btnEditDept = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.dgvDepartment = New System.Windows.Forms.DataGridView()
        Me.btnAddDept = New System.Windows.Forms.Button()
        Me.cbBranch = New System.Windows.Forms.ComboBox()
        Me.txtDeptName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDeptName = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTransaksi.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabMasterBranch.SuspendLayout()
        CType(Me.dgvMasterBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMasterBranch.SuspendLayout()
        Me.tabDataJurnal.SuspendLayout()
        CType(Me.dgvJournalEntri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransaksi.SuspendLayout()
        Me.tabLaporan.SuspendLayout()
        CType(Me.chartGrafikSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLaporan.SuspendLayout()
        Me.TabDepartment.SuspendLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.Controls.Add(Me.Label8)
        Me.header.Controls.Add(Me.PictureBox1)
        Me.header.Location = New System.Drawing.Point(18, 6)
        Me.header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(705, 49)
        Me.header.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(279, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Bank General Ledger"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UASS.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gbTransaksi
        '
        Me.gbTransaksi.Controls.Add(Me.txtCreatedBy)
        Me.gbTransaksi.Controls.Add(Me.txtCredit)
        Me.gbTransaksi.Controls.Add(Me.btnRejectJournal)
        Me.gbTransaksi.Controls.Add(Me.btnAddJournal)
        Me.gbTransaksi.Controls.Add(Me.btnApproveJournal)
        Me.gbTransaksi.Controls.Add(Me.txtDebit)
        Me.gbTransaksi.Controls.Add(Me.btnPostJournal)
        Me.gbTransaksi.Controls.Add(Me.btnReverseJournal)
        Me.gbTransaksi.Controls.Add(Me.txtCostCenterID)
        Me.gbTransaksi.Controls.Add(Me.txtLedgerID)
        Me.gbTransaksi.Controls.Add(Me.txtDepartmentID)
        Me.gbTransaksi.Controls.Add(Me.txtTransaksiBranchID)
        Me.gbTransaksi.Controls.Add(Me.Label7)
        Me.gbTransaksi.Controls.Add(Me.Label6)
        Me.gbTransaksi.Controls.Add(Me.Label5)
        Me.gbTransaksi.Controls.Add(Me.Label4)
        Me.gbTransaksi.Controls.Add(Me.Label3)
        Me.gbTransaksi.Controls.Add(Me.Label2)
        Me.gbTransaksi.Controls.Add(Me.Label1)
        Me.gbTransaksi.Location = New System.Drawing.Point(9, 9)
        Me.gbTransaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbTransaksi.Name = "gbTransaksi"
        Me.gbTransaksi.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbTransaksi.Size = New System.Drawing.Size(688, 312)
        Me.gbTransaksi.TabIndex = 9
        Me.gbTransaksi.TabStop = False
        Me.gbTransaksi.Text = "Transaksi"
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Location = New System.Drawing.Point(198, 266)
        Me.txtCreatedBy.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(205, 26)
        Me.txtCreatedBy.TabIndex = 13
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(198, 226)
        Me.txtCredit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(205, 26)
        Me.txtCredit.TabIndex = 12
        '
        'btnRejectJournal
        '
        Me.btnRejectJournal.Location = New System.Drawing.Point(496, 262)
        Me.btnRejectJournal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRejectJournal.Name = "btnRejectJournal"
        Me.btnRejectJournal.Size = New System.Drawing.Size(147, 35)
        Me.btnRejectJournal.TabIndex = 12
        Me.btnRejectJournal.Text = "Reject Journal"
        Me.btnRejectJournal.UseVisualStyleBackColor = True
        '
        'btnAddJournal
        '
        Me.btnAddJournal.Location = New System.Drawing.Point(496, 31)
        Me.btnAddJournal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddJournal.Name = "btnAddJournal"
        Me.btnAddJournal.Size = New System.Drawing.Size(147, 35)
        Me.btnAddJournal.TabIndex = 10
        Me.btnAddJournal.Text = "Add Journal"
        Me.btnAddJournal.UseVisualStyleBackColor = True
        '
        'btnApproveJournal
        '
        Me.btnApproveJournal.Location = New System.Drawing.Point(496, 211)
        Me.btnApproveJournal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApproveJournal.Name = "btnApproveJournal"
        Me.btnApproveJournal.Size = New System.Drawing.Size(147, 35)
        Me.btnApproveJournal.TabIndex = 11
        Me.btnApproveJournal.Text = "Approve Journal"
        Me.btnApproveJournal.UseVisualStyleBackColor = True
        '
        'txtDebit
        '
        Me.txtDebit.Location = New System.Drawing.Point(198, 186)
        Me.txtDebit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(205, 26)
        Me.txtDebit.TabIndex = 11
        '
        'btnPostJournal
        '
        Me.btnPostJournal.Location = New System.Drawing.Point(496, 146)
        Me.btnPostJournal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPostJournal.Name = "btnPostJournal"
        Me.btnPostJournal.Size = New System.Drawing.Size(147, 35)
        Me.btnPostJournal.TabIndex = 14
        Me.btnPostJournal.Text = "Post Journal"
        Me.btnPostJournal.UseVisualStyleBackColor = True
        '
        'btnReverseJournal
        '
        Me.btnReverseJournal.Location = New System.Drawing.Point(496, 91)
        Me.btnReverseJournal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReverseJournal.Name = "btnReverseJournal"
        Me.btnReverseJournal.Size = New System.Drawing.Size(147, 35)
        Me.btnReverseJournal.TabIndex = 13
        Me.btnReverseJournal.Text = "Reverse Journal"
        Me.btnReverseJournal.UseVisualStyleBackColor = True
        '
        'txtCostCenterID
        '
        Me.txtCostCenterID.Location = New System.Drawing.Point(198, 146)
        Me.txtCostCenterID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCostCenterID.Name = "txtCostCenterID"
        Me.txtCostCenterID.Size = New System.Drawing.Size(205, 26)
        Me.txtCostCenterID.TabIndex = 10
        '
        'txtLedgerID
        '
        Me.txtLedgerID.Location = New System.Drawing.Point(198, 106)
        Me.txtLedgerID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLedgerID.Name = "txtLedgerID"
        Me.txtLedgerID.Size = New System.Drawing.Size(205, 26)
        Me.txtLedgerID.TabIndex = 9
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Location = New System.Drawing.Point(198, 66)
        Me.txtDepartmentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.Size = New System.Drawing.Size(205, 26)
        Me.txtDepartmentID.TabIndex = 8
        '
        'txtTransaksiBranchID
        '
        Me.txtTransaksiBranchID.Location = New System.Drawing.Point(198, 26)
        Me.txtTransaksiBranchID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTransaksiBranchID.Name = "txtTransaksiBranchID"
        Me.txtTransaksiBranchID.Size = New System.Drawing.Size(205, 26)
        Me.txtTransaksiBranchID.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 271)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Created By"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 231)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Credit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 191)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Debit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cost Center ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ledger ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch ID"
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Location = New System.Drawing.Point(9, 331)
        Me.dgvTransaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.RowHeadersWidth = 62
        Me.dgvTransaksi.Size = New System.Drawing.Size(688, 297)
        Me.dgvTransaksi.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMasterBranch)
        Me.TabControl1.Controls.Add(Me.tabDataJurnal)
        Me.TabControl1.Controls.Add(Me.tabTransaksi)
        Me.TabControl1.Controls.Add(Me.tabLaporan)
        Me.TabControl1.Controls.Add(Me.TabDepartment)
        Me.TabControl1.Location = New System.Drawing.Point(20, 66)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(717, 677)
        Me.TabControl1.TabIndex = 17
        '
        'tabMasterBranch
        '
        Me.tabMasterBranch.Controls.Add(Me.dgvMasterBranch)
        Me.tabMasterBranch.Controls.Add(Me.gbMasterBranch)
        Me.tabMasterBranch.Location = New System.Drawing.Point(4, 29)
        Me.tabMasterBranch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabMasterBranch.Name = "tabMasterBranch"
        Me.tabMasterBranch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabMasterBranch.Size = New System.Drawing.Size(709, 644)
        Me.tabMasterBranch.TabIndex = 0
        Me.tabMasterBranch.Text = "Master Branch"
        Me.tabMasterBranch.UseVisualStyleBackColor = True
        '
        'dgvMasterBranch
        '
        Me.dgvMasterBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterBranch.Location = New System.Drawing.Point(9, 268)
        Me.dgvMasterBranch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvMasterBranch.Name = "dgvMasterBranch"
        Me.dgvMasterBranch.RowHeadersWidth = 62
        Me.dgvMasterBranch.Size = New System.Drawing.Size(687, 360)
        Me.dgvMasterBranch.TabIndex = 1
        '
        'gbMasterBranch
        '
        Me.gbMasterBranch.Controls.Add(Me.btnDeleteBranch)
        Me.gbMasterBranch.Controls.Add(Me.btnEditBranch)
        Me.gbMasterBranch.Controls.Add(Me.btnAddBranch)
        Me.gbMasterBranch.Controls.Add(Me.txtAlamat)
        Me.gbMasterBranch.Controls.Add(Me.txtBranchName)
        Me.gbMasterBranch.Controls.Add(Me.txtMasterBranchID)
        Me.gbMasterBranch.Controls.Add(Me.Label11)
        Me.gbMasterBranch.Controls.Add(Me.Label10)
        Me.gbMasterBranch.Controls.Add(Me.Label9)
        Me.gbMasterBranch.Location = New System.Drawing.Point(9, 9)
        Me.gbMasterBranch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbMasterBranch.Name = "gbMasterBranch"
        Me.gbMasterBranch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbMasterBranch.Size = New System.Drawing.Size(687, 249)
        Me.gbMasterBranch.TabIndex = 0
        Me.gbMasterBranch.TabStop = False
        Me.gbMasterBranch.Text = "Master Branch"
        '
        'btnDeleteBranch
        '
        Me.btnDeleteBranch.Location = New System.Drawing.Point(486, 185)
        Me.btnDeleteBranch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteBranch.Name = "btnDeleteBranch"
        Me.btnDeleteBranch.Size = New System.Drawing.Size(140, 35)
        Me.btnDeleteBranch.TabIndex = 8
        Me.btnDeleteBranch.Text = "Delete Branch"
        Me.btnDeleteBranch.UseVisualStyleBackColor = True
        '
        'btnEditBranch
        '
        Me.btnEditBranch.Location = New System.Drawing.Point(246, 185)
        Me.btnEditBranch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditBranch.Name = "btnEditBranch"
        Me.btnEditBranch.Size = New System.Drawing.Size(112, 35)
        Me.btnEditBranch.TabIndex = 7
        Me.btnEditBranch.Text = "Edit Branch"
        Me.btnEditBranch.UseVisualStyleBackColor = True
        '
        'btnAddBranch
        '
        Me.btnAddBranch.Location = New System.Drawing.Point(27, 185)
        Me.btnAddBranch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddBranch.Name = "btnAddBranch"
        Me.btnAddBranch.Size = New System.Drawing.Size(112, 35)
        Me.btnAddBranch.TabIndex = 6
        Me.btnAddBranch.Text = "Add Branch"
        Me.btnAddBranch.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(135, 108)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(541, 26)
        Me.txtAlamat.TabIndex = 5
        '
        'txtBranchName
        '
        Me.txtBranchName.Location = New System.Drawing.Point(135, 62)
        Me.txtBranchName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(541, 26)
        Me.txtBranchName.TabIndex = 4
        '
        'txtMasterBranchID
        '
        Me.txtMasterBranchID.Location = New System.Drawing.Point(135, 20)
        Me.txtMasterBranchID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMasterBranchID.Name = "txtMasterBranchID"
        Me.txtMasterBranchID.Size = New System.Drawing.Size(192, 26)
        Me.txtMasterBranchID.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 112)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 66)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Branch Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Branch ID"
        '
        'tabDataJurnal
        '
        Me.tabDataJurnal.Controls.Add(Me.btnSelanjutnya)
        Me.tabDataJurnal.Controls.Add(Me.btnRefreshJurnal)
        Me.tabDataJurnal.Controls.Add(Me.btnKembali)
        Me.tabDataJurnal.Controls.Add(Me.dgvJournalEntri)
        Me.tabDataJurnal.Location = New System.Drawing.Point(4, 29)
        Me.tabDataJurnal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabDataJurnal.Name = "tabDataJurnal"
        Me.tabDataJurnal.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabDataJurnal.Size = New System.Drawing.Size(709, 644)
        Me.tabDataJurnal.TabIndex = 1
        Me.tabDataJurnal.Text = "Data Jurnal"
        Me.tabDataJurnal.UseVisualStyleBackColor = True
        '
        'btnSelanjutnya
        '
        Me.btnSelanjutnya.Location = New System.Drawing.Point(584, 591)
        Me.btnSelanjutnya.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSelanjutnya.Name = "btnSelanjutnya"
        Me.btnSelanjutnya.Size = New System.Drawing.Size(112, 35)
        Me.btnSelanjutnya.TabIndex = 3
        Me.btnSelanjutnya.Text = "Selanjutnya"
        Me.btnSelanjutnya.UseVisualStyleBackColor = True
        '
        'btnRefreshJurnal
        '
        Me.btnRefreshJurnal.Location = New System.Drawing.Point(278, 591)
        Me.btnRefreshJurnal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefreshJurnal.Name = "btnRefreshJurnal"
        Me.btnRefreshJurnal.Size = New System.Drawing.Size(147, 35)
        Me.btnRefreshJurnal.TabIndex = 2
        Me.btnRefreshJurnal.Text = "Refresh Jurnal"
        Me.btnRefreshJurnal.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(9, 591)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(112, 35)
        Me.btnKembali.TabIndex = 1
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'dgvJournalEntri
        '
        Me.dgvJournalEntri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJournalEntri.Location = New System.Drawing.Point(9, 9)
        Me.dgvJournalEntri.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvJournalEntri.Name = "dgvJournalEntri"
        Me.dgvJournalEntri.RowHeadersWidth = 62
        Me.dgvJournalEntri.Size = New System.Drawing.Size(687, 572)
        Me.dgvJournalEntri.TabIndex = 0
        '
        'tabTransaksi
        '
        Me.tabTransaksi.Controls.Add(Me.dgvTransaksi)
        Me.tabTransaksi.Controls.Add(Me.gbTransaksi)
        Me.tabTransaksi.Location = New System.Drawing.Point(4, 29)
        Me.tabTransaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabTransaksi.Name = "tabTransaksi"
        Me.tabTransaksi.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabTransaksi.Size = New System.Drawing.Size(709, 644)
        Me.tabTransaksi.TabIndex = 2
        Me.tabTransaksi.Text = "Transaksi"
        Me.tabTransaksi.UseVisualStyleBackColor = True
        '
        'tabLaporan
        '
        Me.tabLaporan.Controls.Add(Me.chartGrafikSaldo)
        Me.tabLaporan.Controls.Add(Me.dgvLaporan)
        Me.tabLaporan.Controls.Add(Me.gbLaporan)
        Me.tabLaporan.Location = New System.Drawing.Point(4, 29)
        Me.tabLaporan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabLaporan.Size = New System.Drawing.Size(709, 644)
        Me.tabLaporan.TabIndex = 3
        Me.tabLaporan.Text = "Laporan"
        Me.tabLaporan.UseVisualStyleBackColor = True
        '
        'chartGrafikSaldo
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartGrafikSaldo.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartGrafikSaldo.Legends.Add(Legend2)
        Me.chartGrafikSaldo.Location = New System.Drawing.Point(9, 445)
        Me.chartGrafikSaldo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chartGrafikSaldo.Name = "chartGrafikSaldo"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartGrafikSaldo.Series.Add(Series2)
        Me.chartGrafikSaldo.Size = New System.Drawing.Size(687, 192)
        Me.chartGrafikSaldo.TabIndex = 7
        Me.chartGrafikSaldo.Text = "Chart1"
        '
        'dgvLaporan
        '
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Location = New System.Drawing.Point(9, 180)
        Me.dgvLaporan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.RowHeadersWidth = 62
        Me.dgvLaporan.Size = New System.Drawing.Size(688, 255)
        Me.dgvLaporan.TabIndex = 6
        '
        'gbLaporan
        '
        Me.gbLaporan.Controls.Add(Me.Label12)
        Me.gbLaporan.Controls.Add(Me.btnReport)
        Me.gbLaporan.Controls.Add(Me.Label13)
        Me.gbLaporan.Controls.Add(Me.dtpPeriode)
        Me.gbLaporan.Controls.Add(Me.cmbCabang)
        Me.gbLaporan.Location = New System.Drawing.Point(9, 9)
        Me.gbLaporan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbLaporan.Name = "gbLaporan"
        Me.gbLaporan.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbLaporan.Size = New System.Drawing.Size(688, 162)
        Me.gbLaporan.TabIndex = 5
        Me.gbLaporan.TabStop = False
        Me.gbLaporan.Text = "Laporan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 34)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cabang"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(110, 111)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(112, 35)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 80)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 20)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Periode"
        '
        'dtpPeriode
        '
        Me.dtpPeriode.Location = New System.Drawing.Point(110, 71)
        Me.dtpPeriode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpPeriode.Name = "dtpPeriode"
        Me.dtpPeriode.Size = New System.Drawing.Size(298, 26)
        Me.dtpPeriode.TabIndex = 3
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(110, 29)
        Me.cmbCabang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(180, 28)
        Me.cmbCabang.TabIndex = 2
        '
        'TabDepartment
        '
        Me.TabDepartment.Controls.Add(Me.btnDeleteDept)
        Me.TabDepartment.Controls.Add(Me.btnEditDept)
        Me.TabDepartment.Controls.Add(Me.BtnClear)
        Me.TabDepartment.Controls.Add(Me.dgvDepartment)
        Me.TabDepartment.Controls.Add(Me.btnAddDept)
        Me.TabDepartment.Controls.Add(Me.cbBranch)
        Me.TabDepartment.Controls.Add(Me.txtDeptName)
        Me.TabDepartment.Controls.Add(Me.Label16)
        Me.TabDepartment.Controls.Add(Me.lblDeptName)
        Me.TabDepartment.Controls.Add(Me.Label14)
        Me.TabDepartment.Location = New System.Drawing.Point(4, 29)
        Me.TabDepartment.Name = "TabDepartment"
        Me.TabDepartment.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDepartment.Size = New System.Drawing.Size(709, 644)
        Me.TabDepartment.TabIndex = 4
        Me.TabDepartment.Text = "Master Department"
        Me.TabDepartment.UseVisualStyleBackColor = True
        '
        'btnDeleteDept
        '
        Me.btnDeleteDept.Location = New System.Drawing.Point(349, 143)
        Me.btnDeleteDept.Name = "btnDeleteDept"
        Me.btnDeleteDept.Size = New System.Drawing.Size(154, 37)
        Me.btnDeleteDept.TabIndex = 12
        Me.btnDeleteDept.Text = "Delete Department"
        Me.btnDeleteDept.UseVisualStyleBackColor = True
        '
        'btnEditDept
        '
        Me.btnEditDept.Location = New System.Drawing.Point(188, 143)
        Me.btnEditDept.Name = "btnEditDept"
        Me.btnEditDept.Size = New System.Drawing.Size(140, 37)
        Me.btnEditDept.TabIndex = 11
        Me.btnEditDept.Text = "Edit Department"
        Me.btnEditDept.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(583, 143)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(104, 37)
        Me.BtnClear.TabIndex = 10
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'dgvDepartment
        '
        Me.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartment.Location = New System.Drawing.Point(21, 211)
        Me.dgvDepartment.Name = "dgvDepartment"
        Me.dgvDepartment.RowHeadersWidth = 62
        Me.dgvDepartment.RowTemplate.Height = 28
        Me.dgvDepartment.Size = New System.Drawing.Size(666, 296)
        Me.dgvDepartment.TabIndex = 9
        '
        'btnAddDept
        '
        Me.btnAddDept.Location = New System.Drawing.Point(21, 143)
        Me.btnAddDept.Name = "btnAddDept"
        Me.btnAddDept.Size = New System.Drawing.Size(146, 37)
        Me.btnAddDept.TabIndex = 5
        Me.btnAddDept.Text = "Add Department"
        Me.btnAddDept.UseVisualStyleBackColor = True
        '
        'cbBranch
        '
        Me.cbBranch.FormattingEnabled = True
        Me.cbBranch.Location = New System.Drawing.Point(188, 89)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(239, 28)
        Me.cbBranch.TabIndex = 4
        '
        'txtDeptName
        '
        Me.txtDeptName.Location = New System.Drawing.Point(188, 53)
        Me.txtDeptName.Name = "txtDeptName"
        Me.txtDeptName.Size = New System.Drawing.Size(239, 26)
        Me.txtDeptName.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 20)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Cabang"
        '
        'lblDeptName
        '
        Me.lblDeptName.AutoSize = True
        Me.lblDeptName.Location = New System.Drawing.Point(17, 56)
        Me.lblDeptName.Name = "lblDeptName"
        Me.lblDeptName.Size = New System.Drawing.Size(140, 20)
        Me.lblDeptName.TabIndex = 1
        Me.lblDeptName.Text = "Nama Department"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Master Department"
        '
        'BankGeneralLedgerApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 757)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.header)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BankGeneralLedgerApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank General Ledger App"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTransaksi.ResumeLayout(False)
        Me.gbTransaksi.PerformLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabMasterBranch.ResumeLayout(False)
        CType(Me.dgvMasterBranch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMasterBranch.ResumeLayout(False)
        Me.gbMasterBranch.PerformLayout()
        Me.tabDataJurnal.ResumeLayout(False)
        CType(Me.dgvJournalEntri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransaksi.ResumeLayout(False)
        Me.tabLaporan.ResumeLayout(False)
        CType(Me.chartGrafikSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLaporan.ResumeLayout(False)
        Me.gbLaporan.PerformLayout()
        Me.TabDepartment.ResumeLayout(False)
        Me.TabDepartment.PerformLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As Panel
    Friend WithEvents gbTransaksi As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCreatedBy As TextBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents txtDebit As TextBox
    Friend WithEvents txtCostCenterID As TextBox
    Friend WithEvents txtLedgerID As TextBox
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents txtTransaksiBranchID As TextBox
    Friend WithEvents btnAddJournal As Button
    Friend WithEvents btnApproveJournal As Button
    Friend WithEvents btnRejectJournal As Button
    Friend WithEvents btnReverseJournal As Button
    Friend WithEvents btnPostJournal As Button
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabMasterBranch As TabPage
    Friend WithEvents tabDataJurnal As TabPage
    Friend WithEvents tabTransaksi As TabPage
    Friend WithEvents tabLaporan As TabPage
    Friend WithEvents gbMasterBranch As GroupBox
    Friend WithEvents txtBranchName As TextBox
    Friend WithEvents txtMasterBranchID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDeleteBranch As Button
    Friend WithEvents btnEditBranch As Button
    Friend WithEvents btnAddBranch As Button
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dgvMasterBranch As DataGridView
    Friend WithEvents btnSelanjutnya As Button
    Friend WithEvents btnRefreshJurnal As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvJournalEntri As DataGridView
    Friend WithEvents dtpPeriode As DateTimePicker
    Friend WithEvents cmbCabang As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents gbLaporan As GroupBox
    Friend WithEvents chartGrafikSaldo As DataVisualization.Charting.Chart
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents TabDepartment As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents lblDeptName As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dgvDepartment As DataGridView
    Friend WithEvents btnAddDept As Button
    Friend WithEvents cbBranch As ComboBox
    Friend WithEvents txtDeptName As TextBox
    Friend WithEvents btnDeleteDept As Button
    Friend WithEvents btnEditDept As Button
    Friend WithEvents BtnClear As Button
End Class
