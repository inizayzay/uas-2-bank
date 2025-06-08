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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.Controls.Add(Me.Label8)
        Me.header.Controls.Add(Me.PictureBox1)
        Me.header.Location = New System.Drawing.Point(12, 4)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(470, 32)
        Me.header.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 22)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Bank General Ledger"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UASS.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 32)
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
        Me.gbTransaksi.Location = New System.Drawing.Point(6, 6)
        Me.gbTransaksi.Name = "gbTransaksi"
        Me.gbTransaksi.Size = New System.Drawing.Size(459, 203)
        Me.gbTransaksi.TabIndex = 9
        Me.gbTransaksi.TabStop = False
        Me.gbTransaksi.Text = "Transaksi"
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Location = New System.Drawing.Point(132, 173)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(138, 20)
        Me.txtCreatedBy.TabIndex = 13
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(132, 147)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(138, 20)
        Me.txtCredit.TabIndex = 12
        '
        'btnRejectJournal
        '
        Me.btnRejectJournal.Location = New System.Drawing.Point(331, 170)
        Me.btnRejectJournal.Name = "btnRejectJournal"
        Me.btnRejectJournal.Size = New System.Drawing.Size(98, 23)
        Me.btnRejectJournal.TabIndex = 12
        Me.btnRejectJournal.Text = "Reject Journal"
        Me.btnRejectJournal.UseVisualStyleBackColor = True
        '
        'btnAddJournal
        '
        Me.btnAddJournal.Location = New System.Drawing.Point(331, 20)
        Me.btnAddJournal.Name = "btnAddJournal"
        Me.btnAddJournal.Size = New System.Drawing.Size(98, 23)
        Me.btnAddJournal.TabIndex = 10
        Me.btnAddJournal.Text = "Add Journal"
        Me.btnAddJournal.UseVisualStyleBackColor = True
        '
        'btnApproveJournal
        '
        Me.btnApproveJournal.Location = New System.Drawing.Point(331, 137)
        Me.btnApproveJournal.Name = "btnApproveJournal"
        Me.btnApproveJournal.Size = New System.Drawing.Size(98, 23)
        Me.btnApproveJournal.TabIndex = 11
        Me.btnApproveJournal.Text = "Approve Journal"
        Me.btnApproveJournal.UseVisualStyleBackColor = True
        '
        'txtDebit
        '
        Me.txtDebit.Location = New System.Drawing.Point(132, 121)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(138, 20)
        Me.txtDebit.TabIndex = 11
        '
        'btnPostJournal
        '
        Me.btnPostJournal.Location = New System.Drawing.Point(331, 95)
        Me.btnPostJournal.Name = "btnPostJournal"
        Me.btnPostJournal.Size = New System.Drawing.Size(98, 23)
        Me.btnPostJournal.TabIndex = 14
        Me.btnPostJournal.Text = "Post Journal"
        Me.btnPostJournal.UseVisualStyleBackColor = True
        '
        'btnReverseJournal
        '
        Me.btnReverseJournal.Location = New System.Drawing.Point(331, 59)
        Me.btnReverseJournal.Name = "btnReverseJournal"
        Me.btnReverseJournal.Size = New System.Drawing.Size(98, 23)
        Me.btnReverseJournal.TabIndex = 13
        Me.btnReverseJournal.Text = "Reverse Journal"
        Me.btnReverseJournal.UseVisualStyleBackColor = True
        '
        'txtCostCenterID
        '
        Me.txtCostCenterID.Location = New System.Drawing.Point(132, 95)
        Me.txtCostCenterID.Name = "txtCostCenterID"
        Me.txtCostCenterID.Size = New System.Drawing.Size(138, 20)
        Me.txtCostCenterID.TabIndex = 10
        '
        'txtLedgerID
        '
        Me.txtLedgerID.Location = New System.Drawing.Point(132, 69)
        Me.txtLedgerID.Name = "txtLedgerID"
        Me.txtLedgerID.Size = New System.Drawing.Size(138, 20)
        Me.txtLedgerID.TabIndex = 9
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Location = New System.Drawing.Point(132, 43)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.Size = New System.Drawing.Size(138, 20)
        Me.txtDepartmentID.TabIndex = 8
        '
        'txtTransaksiBranchID
        '
        Me.txtTransaksiBranchID.Location = New System.Drawing.Point(132, 17)
        Me.txtTransaksiBranchID.Name = "txtTransaksiBranchID"
        Me.txtTransaksiBranchID.Size = New System.Drawing.Size(138, 20)
        Me.txtTransaksiBranchID.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Created By"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Credit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Debit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cost Center ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ledger ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch ID"
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Location = New System.Drawing.Point(6, 215)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.Size = New System.Drawing.Size(459, 193)
        Me.dgvTransaksi.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMasterBranch)
        Me.TabControl1.Controls.Add(Me.tabDataJurnal)
        Me.TabControl1.Controls.Add(Me.tabTransaksi)
        Me.TabControl1.Controls.Add(Me.tabLaporan)
        Me.TabControl1.Location = New System.Drawing.Point(13, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(478, 440)
        Me.TabControl1.TabIndex = 17
        '
        'tabMasterBranch
        '
        Me.tabMasterBranch.Controls.Add(Me.dgvMasterBranch)
        Me.tabMasterBranch.Controls.Add(Me.gbMasterBranch)
        Me.tabMasterBranch.Location = New System.Drawing.Point(4, 22)
        Me.tabMasterBranch.Name = "tabMasterBranch"
        Me.tabMasterBranch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMasterBranch.Size = New System.Drawing.Size(470, 414)
        Me.tabMasterBranch.TabIndex = 0
        Me.tabMasterBranch.Text = "Master Branch"
        Me.tabMasterBranch.UseVisualStyleBackColor = True
        '
        'dgvMasterBranch
        '
        Me.dgvMasterBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterBranch.Location = New System.Drawing.Point(6, 174)
        Me.dgvMasterBranch.Name = "dgvMasterBranch"
        Me.dgvMasterBranch.Size = New System.Drawing.Size(458, 234)
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
        Me.gbMasterBranch.Location = New System.Drawing.Point(6, 6)
        Me.gbMasterBranch.Name = "gbMasterBranch"
        Me.gbMasterBranch.Size = New System.Drawing.Size(458, 162)
        Me.gbMasterBranch.TabIndex = 0
        Me.gbMasterBranch.TabStop = False
        Me.gbMasterBranch.Text = "Master Branch"
        '
        'btnDeleteBranch
        '
        Me.btnDeleteBranch.Location = New System.Drawing.Point(324, 120)
        Me.btnDeleteBranch.Name = "btnDeleteBranch"
        Me.btnDeleteBranch.Size = New System.Drawing.Size(93, 23)
        Me.btnDeleteBranch.TabIndex = 8
        Me.btnDeleteBranch.Text = "Delete Branch"
        Me.btnDeleteBranch.UseVisualStyleBackColor = True
        '
        'btnEditBranch
        '
        Me.btnEditBranch.Location = New System.Drawing.Point(164, 120)
        Me.btnEditBranch.Name = "btnEditBranch"
        Me.btnEditBranch.Size = New System.Drawing.Size(75, 23)
        Me.btnEditBranch.TabIndex = 7
        Me.btnEditBranch.Text = "Edit Branch"
        Me.btnEditBranch.UseVisualStyleBackColor = True
        '
        'btnAddBranch
        '
        Me.btnAddBranch.Location = New System.Drawing.Point(18, 120)
        Me.btnAddBranch.Name = "btnAddBranch"
        Me.btnAddBranch.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBranch.TabIndex = 6
        Me.btnAddBranch.Text = "Add Branch"
        Me.btnAddBranch.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(90, 70)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(362, 20)
        Me.txtAlamat.TabIndex = 5
        '
        'txtBranchName
        '
        Me.txtBranchName.Location = New System.Drawing.Point(90, 40)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(362, 20)
        Me.txtBranchName.TabIndex = 4
        '
        'txtMasterBranchID
        '
        Me.txtMasterBranchID.Location = New System.Drawing.Point(90, 13)
        Me.txtMasterBranchID.Name = "txtMasterBranchID"
        Me.txtMasterBranchID.Size = New System.Drawing.Size(129, 20)
        Me.txtMasterBranchID.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Branch Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Branch ID"
        '
        'tabDataJurnal
        '
        Me.tabDataJurnal.Controls.Add(Me.btnSelanjutnya)
        Me.tabDataJurnal.Controls.Add(Me.btnRefreshJurnal)
        Me.tabDataJurnal.Controls.Add(Me.btnKembali)
        Me.tabDataJurnal.Controls.Add(Me.dgvJournalEntri)
        Me.tabDataJurnal.Location = New System.Drawing.Point(4, 22)
        Me.tabDataJurnal.Name = "tabDataJurnal"
        Me.tabDataJurnal.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDataJurnal.Size = New System.Drawing.Size(470, 414)
        Me.tabDataJurnal.TabIndex = 1
        Me.tabDataJurnal.Text = "Data Jurnal"
        Me.tabDataJurnal.UseVisualStyleBackColor = True
        '
        'btnSelanjutnya
        '
        Me.btnSelanjutnya.Location = New System.Drawing.Point(389, 384)
        Me.btnSelanjutnya.Name = "btnSelanjutnya"
        Me.btnSelanjutnya.Size = New System.Drawing.Size(75, 23)
        Me.btnSelanjutnya.TabIndex = 3
        Me.btnSelanjutnya.Text = "Selanjutnya"
        Me.btnSelanjutnya.UseVisualStyleBackColor = True
        '
        'btnRefreshJurnal
        '
        Me.btnRefreshJurnal.Location = New System.Drawing.Point(185, 384)
        Me.btnRefreshJurnal.Name = "btnRefreshJurnal"
        Me.btnRefreshJurnal.Size = New System.Drawing.Size(98, 23)
        Me.btnRefreshJurnal.TabIndex = 2
        Me.btnRefreshJurnal.Text = "Refresh Jurnal"
        Me.btnRefreshJurnal.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(6, 384)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 23)
        Me.btnKembali.TabIndex = 1
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'dgvJournalEntri
        '
        Me.dgvJournalEntri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJournalEntri.Location = New System.Drawing.Point(6, 6)
        Me.dgvJournalEntri.Name = "dgvJournalEntri"
        Me.dgvJournalEntri.Size = New System.Drawing.Size(458, 372)
        Me.dgvJournalEntri.TabIndex = 0
        '
        'tabTransaksi
        '
        Me.tabTransaksi.Controls.Add(Me.dgvTransaksi)
        Me.tabTransaksi.Controls.Add(Me.gbTransaksi)
        Me.tabTransaksi.Location = New System.Drawing.Point(4, 22)
        Me.tabTransaksi.Name = "tabTransaksi"
        Me.tabTransaksi.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaksi.Size = New System.Drawing.Size(470, 414)
        Me.tabTransaksi.TabIndex = 2
        Me.tabTransaksi.Text = "Transaksi"
        Me.tabTransaksi.UseVisualStyleBackColor = True
        '
        'tabLaporan
        '
        Me.tabLaporan.Controls.Add(Me.chartGrafikSaldo)
        Me.tabLaporan.Controls.Add(Me.dgvLaporan)
        Me.tabLaporan.Controls.Add(Me.gbLaporan)
        Me.tabLaporan.Location = New System.Drawing.Point(4, 22)
        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLaporan.Size = New System.Drawing.Size(470, 414)
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
        Me.chartGrafikSaldo.Location = New System.Drawing.Point(6, 289)
        Me.chartGrafikSaldo.Name = "chartGrafikSaldo"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartGrafikSaldo.Series.Add(Series2)
        Me.chartGrafikSaldo.Size = New System.Drawing.Size(458, 125)
        Me.chartGrafikSaldo.TabIndex = 7
        Me.chartGrafikSaldo.Text = "Chart1"
        '
        'dgvLaporan
        '
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Location = New System.Drawing.Point(6, 117)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.Size = New System.Drawing.Size(459, 166)
        Me.dgvLaporan.TabIndex = 6
        '
        'gbLaporan
        '
        Me.gbLaporan.Controls.Add(Me.Label12)
        Me.gbLaporan.Controls.Add(Me.btnReport)
        Me.gbLaporan.Controls.Add(Me.Label13)
        Me.gbLaporan.Controls.Add(Me.dtpPeriode)
        Me.gbLaporan.Controls.Add(Me.cmbCabang)
        Me.gbLaporan.Location = New System.Drawing.Point(6, 6)
        Me.gbLaporan.Name = "gbLaporan"
        Me.gbLaporan.Size = New System.Drawing.Size(459, 105)
        Me.gbLaporan.TabIndex = 5
        Me.gbLaporan.TabStop = False
        Me.gbLaporan.Text = "Laporan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cabang"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(73, 72)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Periode"
        '
        'dtpPeriode
        '
        Me.dtpPeriode.Location = New System.Drawing.Point(73, 46)
        Me.dtpPeriode.Name = "dtpPeriode"
        Me.dtpPeriode.Size = New System.Drawing.Size(200, 20)
        Me.dtpPeriode.TabIndex = 3
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(73, 19)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(121, 21)
        Me.cmbCabang.TabIndex = 2
        '
        'BankGeneralLedgerApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 492)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.header)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
End Class
