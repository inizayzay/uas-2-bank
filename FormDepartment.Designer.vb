<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDepartment
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabMasterBranch = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEditDept = New System.Windows.Forms.Button()
        Me.btnDeleteDept = New System.Windows.Forms.Button()
        Me.dgvDepartment = New System.Windows.Forms.DataGridView()
        Me.btnAddDept = New System.Windows.Forms.Button()
        Me.cbBranch = New System.Windows.Forms.ComboBox()
        Me.txtDeptName = New System.Windows.Forms.TextBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.lblDeptName = New System.Windows.Forms.Label()
        Me.tabDataJurnal = New System.Windows.Forms.TabPage()
        Me.btnSelanjutnya = New System.Windows.Forms.Button()
        Me.btnRefreshJurnal = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.dgvJournalEntri = New System.Windows.Forms.DataGridView()
        Me.tabTransaksi = New System.Windows.Forms.TabPage()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
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
        Me.tabLaporan = New System.Windows.Forms.TabPage()
        Me.chartGrafikSaldo = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.gbLaporan = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpPeriode = New System.Windows.Forms.DateTimePicker()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabMasterBranch.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDataJurnal.SuspendLayout()
        CType(Me.dgvJournalEntri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransaksi.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTransaksi.SuspendLayout()
        Me.tabLaporan.SuspendLayout()
        CType(Me.chartGrafikSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLaporan.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMasterBranch)
        Me.TabControl1.Controls.Add(Me.tabDataJurnal)
        Me.TabControl1.Controls.Add(Me.tabTransaksi)
        Me.TabControl1.Controls.Add(Me.tabLaporan)
        Me.TabControl1.Location = New System.Drawing.Point(1, -91)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(699, 447)
        Me.TabControl1.TabIndex = 18
        '
        'tabMasterBranch
        '
        Me.tabMasterBranch.Controls.Add(Me.ButtonBack)
        Me.tabMasterBranch.Controls.Add(Me.TabControl2)
        Me.tabMasterBranch.Location = New System.Drawing.Point(4, 25)
        Me.tabMasterBranch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabMasterBranch.Name = "tabMasterBranch"
        Me.tabMasterBranch.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabMasterBranch.Size = New System.Drawing.Size(691, 418)
        Me.tabMasterBranch.TabIndex = 0
        Me.tabMasterBranch.Text = "Master Branch"
        Me.tabMasterBranch.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(21, 108)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(662, 542)
        Me.TabControl2.TabIndex = 18
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnClear)
        Me.TabPage5.Controls.Add(Me.btnEditDept)
        Me.TabPage5.Controls.Add(Me.btnDeleteDept)
        Me.TabPage5.Controls.Add(Me.dgvDepartment)
        Me.TabPage5.Controls.Add(Me.btnAddDept)
        Me.TabPage5.Controls.Add(Me.cbBranch)
        Me.TabPage5.Controls.Add(Me.txtDeptName)
        Me.TabPage5.Controls.Add(Me.lblBranch)
        Me.TabPage5.Controls.Add(Me.lblDeptName)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage5.Size = New System.Drawing.Size(654, 513)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Master Department"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(534, 104)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 25)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEditDept
        '
        Me.btnEditDept.Location = New System.Drawing.Point(188, 104)
        Me.btnEditDept.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditDept.Name = "btnEditDept"
        Me.btnEditDept.Size = New System.Drawing.Size(121, 25)
        Me.btnEditDept.TabIndex = 10
        Me.btnEditDept.Text = "Edit Department"
        Me.btnEditDept.UseVisualStyleBackColor = True
        '
        'btnDeleteDept
        '
        Me.btnDeleteDept.Location = New System.Drawing.Point(348, 104)
        Me.btnDeleteDept.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteDept.Name = "btnDeleteDept"
        Me.btnDeleteDept.Size = New System.Drawing.Size(144, 25)
        Me.btnDeleteDept.TabIndex = 9
        Me.btnDeleteDept.Text = "Delete Department"
        Me.btnDeleteDept.UseVisualStyleBackColor = True
        '
        'dgvDepartment
        '
        Me.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartment.Location = New System.Drawing.Point(31, 150)
        Me.dgvDepartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvDepartment.Name = "dgvDepartment"
        Me.dgvDepartment.RowHeadersWidth = 62
        Me.dgvDepartment.RowTemplate.Height = 28
        Me.dgvDepartment.Size = New System.Drawing.Size(595, 164)
        Me.dgvDepartment.TabIndex = 8
        '
        'btnAddDept
        '
        Me.btnAddDept.Location = New System.Drawing.Point(31, 104)
        Me.btnAddDept.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddDept.Name = "btnAddDept"
        Me.btnAddDept.Size = New System.Drawing.Size(124, 25)
        Me.btnAddDept.TabIndex = 5
        Me.btnAddDept.Text = "Add Department"
        Me.btnAddDept.UseVisualStyleBackColor = True
        '
        'cbBranch
        '
        Me.cbBranch.FormattingEnabled = True
        Me.cbBranch.Location = New System.Drawing.Point(213, 51)
        Me.cbBranch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(218, 24)
        Me.cbBranch.TabIndex = 3
        '
        'txtDeptName
        '
        Me.txtDeptName.Location = New System.Drawing.Point(213, 17)
        Me.txtDeptName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDeptName.Name = "txtDeptName"
        Me.txtDeptName.Size = New System.Drawing.Size(268, 22)
        Me.txtDeptName.TabIndex = 2
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Location = New System.Drawing.Point(28, 51)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(55, 16)
        Me.lblBranch.TabIndex = 1
        Me.lblBranch.Text = "Cabang"
        '
        'lblDeptName
        '
        Me.lblDeptName.AutoSize = True
        Me.lblDeptName.Location = New System.Drawing.Point(28, 19)
        Me.lblDeptName.Name = "lblDeptName"
        Me.lblDeptName.Size = New System.Drawing.Size(117, 16)
        Me.lblDeptName.TabIndex = 0
        Me.lblDeptName.Text = "Nama Department"
        '
        'tabDataJurnal
        '
        Me.tabDataJurnal.Controls.Add(Me.btnSelanjutnya)
        Me.tabDataJurnal.Controls.Add(Me.btnRefreshJurnal)
        Me.tabDataJurnal.Controls.Add(Me.btnKembali)
        Me.tabDataJurnal.Controls.Add(Me.dgvJournalEntri)
        Me.tabDataJurnal.Location = New System.Drawing.Point(4, 25)
        Me.tabDataJurnal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabDataJurnal.Name = "tabDataJurnal"
        Me.tabDataJurnal.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabDataJurnal.Size = New System.Drawing.Size(691, 418)
        Me.tabDataJurnal.TabIndex = 1
        Me.tabDataJurnal.Text = "Data Jurnal"
        Me.tabDataJurnal.UseVisualStyleBackColor = True
        '
        'btnSelanjutnya
        '
        Me.btnSelanjutnya.Location = New System.Drawing.Point(519, 473)
        Me.btnSelanjutnya.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelanjutnya.Name = "btnSelanjutnya"
        Me.btnSelanjutnya.Size = New System.Drawing.Size(100, 28)
        Me.btnSelanjutnya.TabIndex = 3
        Me.btnSelanjutnya.Text = "Selanjutnya"
        Me.btnSelanjutnya.UseVisualStyleBackColor = True
        '
        'btnRefreshJurnal
        '
        Me.btnRefreshJurnal.Location = New System.Drawing.Point(247, 473)
        Me.btnRefreshJurnal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefreshJurnal.Name = "btnRefreshJurnal"
        Me.btnRefreshJurnal.Size = New System.Drawing.Size(131, 28)
        Me.btnRefreshJurnal.TabIndex = 2
        Me.btnRefreshJurnal.Text = "Refresh Jurnal"
        Me.btnRefreshJurnal.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(8, 473)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(100, 28)
        Me.btnKembali.TabIndex = 1
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'dgvJournalEntri
        '
        Me.dgvJournalEntri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJournalEntri.Location = New System.Drawing.Point(8, 7)
        Me.dgvJournalEntri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvJournalEntri.Name = "dgvJournalEntri"
        Me.dgvJournalEntri.RowHeadersWidth = 51
        Me.dgvJournalEntri.Size = New System.Drawing.Size(611, 458)
        Me.dgvJournalEntri.TabIndex = 0
        '
        'tabTransaksi
        '
        Me.tabTransaksi.Controls.Add(Me.dgvTransaksi)
        Me.tabTransaksi.Controls.Add(Me.gbTransaksi)
        Me.tabTransaksi.Location = New System.Drawing.Point(4, 25)
        Me.tabTransaksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabTransaksi.Name = "tabTransaksi"
        Me.tabTransaksi.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabTransaksi.Size = New System.Drawing.Size(691, 418)
        Me.tabTransaksi.TabIndex = 2
        Me.tabTransaksi.Text = "Transaksi"
        Me.tabTransaksi.UseVisualStyleBackColor = True
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Location = New System.Drawing.Point(8, 265)
        Me.dgvTransaksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.RowHeadersWidth = 51
        Me.dgvTransaksi.Size = New System.Drawing.Size(612, 238)
        Me.dgvTransaksi.TabIndex = 15
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
        Me.gbTransaksi.Location = New System.Drawing.Point(8, 7)
        Me.gbTransaksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbTransaksi.Name = "gbTransaksi"
        Me.gbTransaksi.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbTransaksi.Size = New System.Drawing.Size(612, 250)
        Me.gbTransaksi.TabIndex = 9
        Me.gbTransaksi.TabStop = False
        Me.gbTransaksi.Text = "Transaksi"
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Location = New System.Drawing.Point(176, 213)
        Me.txtCreatedBy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(183, 22)
        Me.txtCreatedBy.TabIndex = 13
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(176, 181)
        Me.txtCredit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(183, 22)
        Me.txtCredit.TabIndex = 12
        '
        'btnRejectJournal
        '
        Me.btnRejectJournal.Location = New System.Drawing.Point(441, 209)
        Me.btnRejectJournal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRejectJournal.Name = "btnRejectJournal"
        Me.btnRejectJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnRejectJournal.TabIndex = 12
        Me.btnRejectJournal.Text = "Reject Journal"
        Me.btnRejectJournal.UseVisualStyleBackColor = True
        '
        'btnAddJournal
        '
        Me.btnAddJournal.Location = New System.Drawing.Point(441, 25)
        Me.btnAddJournal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddJournal.Name = "btnAddJournal"
        Me.btnAddJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnAddJournal.TabIndex = 10
        Me.btnAddJournal.Text = "Add Journal"
        Me.btnAddJournal.UseVisualStyleBackColor = True
        '
        'btnApproveJournal
        '
        Me.btnApproveJournal.Location = New System.Drawing.Point(441, 169)
        Me.btnApproveJournal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnApproveJournal.Name = "btnApproveJournal"
        Me.btnApproveJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnApproveJournal.TabIndex = 11
        Me.btnApproveJournal.Text = "Approve Journal"
        Me.btnApproveJournal.UseVisualStyleBackColor = True
        '
        'txtDebit
        '
        Me.txtDebit.Location = New System.Drawing.Point(176, 149)
        Me.txtDebit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(183, 22)
        Me.txtDebit.TabIndex = 11
        '
        'btnPostJournal
        '
        Me.btnPostJournal.Location = New System.Drawing.Point(441, 117)
        Me.btnPostJournal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPostJournal.Name = "btnPostJournal"
        Me.btnPostJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnPostJournal.TabIndex = 14
        Me.btnPostJournal.Text = "Post Journal"
        Me.btnPostJournal.UseVisualStyleBackColor = True
        '
        'btnReverseJournal
        '
        Me.btnReverseJournal.Location = New System.Drawing.Point(441, 73)
        Me.btnReverseJournal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReverseJournal.Name = "btnReverseJournal"
        Me.btnReverseJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnReverseJournal.TabIndex = 13
        Me.btnReverseJournal.Text = "Reverse Journal"
        Me.btnReverseJournal.UseVisualStyleBackColor = True
        '
        'txtCostCenterID
        '
        Me.txtCostCenterID.Location = New System.Drawing.Point(176, 117)
        Me.txtCostCenterID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCostCenterID.Name = "txtCostCenterID"
        Me.txtCostCenterID.Size = New System.Drawing.Size(183, 22)
        Me.txtCostCenterID.TabIndex = 10
        '
        'txtLedgerID
        '
        Me.txtLedgerID.Location = New System.Drawing.Point(176, 85)
        Me.txtLedgerID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLedgerID.Name = "txtLedgerID"
        Me.txtLedgerID.Size = New System.Drawing.Size(183, 22)
        Me.txtLedgerID.TabIndex = 9
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Location = New System.Drawing.Point(176, 53)
        Me.txtDepartmentID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.Size = New System.Drawing.Size(183, 22)
        Me.txtDepartmentID.TabIndex = 8
        '
        'txtTransaksiBranchID
        '
        Me.txtTransaksiBranchID.Location = New System.Drawing.Point(176, 21)
        Me.txtTransaksiBranchID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTransaksiBranchID.Name = "txtTransaksiBranchID"
        Me.txtTransaksiBranchID.Size = New System.Drawing.Size(183, 22)
        Me.txtTransaksiBranchID.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 217)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Created By"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 185)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Credit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Debit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cost Center ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ledger ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch ID"
        '
        'tabLaporan
        '
        Me.tabLaporan.Controls.Add(Me.chartGrafikSaldo)
        Me.tabLaporan.Controls.Add(Me.dgvLaporan)
        Me.tabLaporan.Controls.Add(Me.gbLaporan)
        Me.tabLaporan.Location = New System.Drawing.Point(4, 25)
        Me.tabLaporan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabLaporan.Size = New System.Drawing.Size(691, 418)
        Me.tabLaporan.TabIndex = 3
        Me.tabLaporan.Text = "Laporan"
        Me.tabLaporan.UseVisualStyleBackColor = True
        '
        'chartGrafikSaldo
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartGrafikSaldo.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartGrafikSaldo.Legends.Add(Legend1)
        Me.chartGrafikSaldo.Location = New System.Drawing.Point(8, 356)
        Me.chartGrafikSaldo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chartGrafikSaldo.Name = "chartGrafikSaldo"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartGrafikSaldo.Series.Add(Series1)
        Me.chartGrafikSaldo.Size = New System.Drawing.Size(611, 154)
        Me.chartGrafikSaldo.TabIndex = 7
        Me.chartGrafikSaldo.Text = "Chart1"
        '
        'dgvLaporan
        '
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Location = New System.Drawing.Point(8, 144)
        Me.dgvLaporan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.RowHeadersWidth = 51
        Me.dgvLaporan.Size = New System.Drawing.Size(612, 204)
        Me.dgvLaporan.TabIndex = 6
        '
        'gbLaporan
        '
        Me.gbLaporan.Controls.Add(Me.Label12)
        Me.gbLaporan.Controls.Add(Me.btnReport)
        Me.gbLaporan.Controls.Add(Me.Label13)
        Me.gbLaporan.Controls.Add(Me.dtpPeriode)
        Me.gbLaporan.Controls.Add(Me.cmbCabang)
        Me.gbLaporan.Location = New System.Drawing.Point(8, 7)
        Me.gbLaporan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbLaporan.Name = "gbLaporan"
        Me.gbLaporan.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbLaporan.Size = New System.Drawing.Size(612, 129)
        Me.gbLaporan.TabIndex = 5
        Me.gbLaporan.TabStop = False
        Me.gbLaporan.Text = "Laporan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cabang"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(97, 89)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(100, 28)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 64)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Periode"
        '
        'dtpPeriode
        '
        Me.dtpPeriode.Location = New System.Drawing.Point(97, 57)
        Me.dtpPeriode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpPeriode.Name = "dtpPeriode"
        Me.dtpPeriode.Size = New System.Drawing.Size(265, 22)
        Me.dtpPeriode.TabIndex = 3
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(97, 23)
        Me.cmbCabang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(160, 24)
        Me.cmbCabang.TabIndex = 2
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(25, 78)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBack.TabIndex = 23
        Me.ButtonBack.Text = "Kembali"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'FormDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 360)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormDepartment"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.tabMasterBranch.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDataJurnal.ResumeLayout(False)
        CType(Me.dgvJournalEntri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransaksi.ResumeLayout(False)
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTransaksi.ResumeLayout(False)
        Me.gbTransaksi.PerformLayout()
        Me.tabLaporan.ResumeLayout(False)
        CType(Me.chartGrafikSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLaporan.ResumeLayout(False)
        Me.gbLaporan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabMasterBranch As TabPage
    Friend WithEvents tabDataJurnal As TabPage
    Friend WithEvents btnSelanjutnya As Button
    Friend WithEvents btnRefreshJurnal As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvJournalEntri As DataGridView
    Friend WithEvents tabTransaksi As TabPage
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents gbTransaksi As GroupBox
    Friend WithEvents txtCreatedBy As TextBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents btnRejectJournal As Button
    Friend WithEvents btnAddJournal As Button
    Friend WithEvents btnApproveJournal As Button
    Friend WithEvents txtDebit As TextBox
    Friend WithEvents btnPostJournal As Button
    Friend WithEvents btnReverseJournal As Button
    Friend WithEvents txtCostCenterID As TextBox
    Friend WithEvents txtLedgerID As TextBox
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents txtTransaksiBranchID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tabLaporan As TabPage
    Friend WithEvents chartGrafikSaldo As DataVisualization.Charting.Chart
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents gbLaporan As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpPeriode As DateTimePicker
    Friend WithEvents cmbCabang As ComboBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents dgvDepartment As DataGridView
    Friend WithEvents btnAddDept As Button
    Friend WithEvents cbBranch As ComboBox
    Friend WithEvents txtDeptName As TextBox
    Friend WithEvents lblBranch As Label
    Friend WithEvents lblDeptName As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEditDept As Button
    Friend WithEvents btnDeleteDept As Button
    Friend WithEvents ButtonBack As Button
End Class
