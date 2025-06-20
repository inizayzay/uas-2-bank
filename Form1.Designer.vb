﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.header = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Me.tabLaporan = New System.Windows.Forms.TabPage()
        Me.chartGrafikSaldo = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.gbLaporan = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpPeriode = New System.Windows.Forms.DateTimePicker()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabDataJurnal = New System.Windows.Forms.TabPage()
        Me.btnSelanjutnya = New System.Windows.Forms.Button()
        Me.btnRefreshJurnal = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.dgvJournalEntri = New System.Windows.Forms.DataGridView()
        Me.tabMasterBranch = New System.Windows.Forms.TabPage()
        Me.dgvMasterBranch = New System.Windows.Forms.DataGridView()
        Me.gbMasterBranch = New System.Windows.Forms.GroupBox()
        Me.btnDeleteBranch = New System.Windows.Forms.Button()
        Me.btnEditBranch = New System.Windows.Forms.Button()
        Me.btnAddBranch = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbBranchID = New System.Windows.Forms.ComboBox()
        Me.cbLedgerID = New System.Windows.Forms.ComboBox()
        Me.cbCostCenterID = New System.Windows.Forms.ComboBox()
        Me.header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLaporan.SuspendLayout()
        CType(Me.chartGrafikSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLaporan.SuspendLayout()
        Me.tabTransaksi.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTransaksi.SuspendLayout()
        Me.tabDataJurnal.SuspendLayout()
        CType(Me.dgvJournalEntri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMasterBranch.SuspendLayout()
        CType(Me.dgvMasterBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMasterBranch.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.Controls.Add(Me.Label8)
        Me.header.Controls.Add(Me.PictureBox1)
        Me.header.Location = New System.Drawing.Point(16, 5)
        Me.header.Margin = New System.Windows.Forms.Padding(4)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(627, 39)
        Me.header.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 5)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Bank General Ledger"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UASS.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'tabLaporan
        '
        Me.tabLaporan.Controls.Add(Me.chartGrafikSaldo)
        Me.tabLaporan.Controls.Add(Me.dgvLaporan)
        Me.tabLaporan.Controls.Add(Me.gbLaporan)
        Me.tabLaporan.Location = New System.Drawing.Point(4, 25)
        Me.tabLaporan.Margin = New System.Windows.Forms.Padding(4)
        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.Padding = New System.Windows.Forms.Padding(4)
        Me.tabLaporan.Size = New System.Drawing.Size(629, 513)
        Me.tabLaporan.TabIndex = 3
        Me.tabLaporan.Text = "Laporan"
        Me.tabLaporan.UseVisualStyleBackColor = True
        '
        'chartGrafikSaldo
        '
        Me.chartGrafikSaldo.Location = New System.Drawing.Point(0, 0)
        Me.chartGrafikSaldo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chartGrafikSaldo.Name = "chartGrafikSaldo"
        Me.chartGrafikSaldo.Size = New System.Drawing.Size(267, 240)
        Me.chartGrafikSaldo.TabIndex = 0
        '
        'dgvLaporan
        '
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Location = New System.Drawing.Point(8, 144)
        Me.dgvLaporan.Margin = New System.Windows.Forms.Padding(4)
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
        Me.gbLaporan.Margin = New System.Windows.Forms.Padding(4)
        Me.gbLaporan.Name = "gbLaporan"
        Me.gbLaporan.Padding = New System.Windows.Forms.Padding(4)
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
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
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
        Me.dtpPeriode.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpPeriode.Name = "dtpPeriode"
        Me.dtpPeriode.Size = New System.Drawing.Size(265, 22)
        Me.dtpPeriode.TabIndex = 3
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(97, 23)
        Me.cmbCabang.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(160, 24)
        Me.cmbCabang.TabIndex = 2
        '
        'tabTransaksi
        '
        Me.tabTransaksi.Controls.Add(Me.dgvTransaksi)
        Me.tabTransaksi.Controls.Add(Me.gbTransaksi)
        Me.tabTransaksi.Location = New System.Drawing.Point(4, 25)
        Me.tabTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.tabTransaksi.Name = "tabTransaksi"
        Me.tabTransaksi.Padding = New System.Windows.Forms.Padding(4)
        Me.tabTransaksi.Size = New System.Drawing.Size(629, 513)
        Me.tabTransaksi.TabIndex = 2
        Me.tabTransaksi.Text = "Transaksi"
        Me.tabTransaksi.UseVisualStyleBackColor = True
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Location = New System.Drawing.Point(8, 265)
        Me.dgvTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.RowHeadersWidth = 51
        Me.dgvTransaksi.Size = New System.Drawing.Size(612, 238)
        Me.dgvTransaksi.TabIndex = 15
        '
        'gbTransaksi
        '
        Me.gbTransaksi.Controls.Add(Me.cbCostCenterID)
        Me.gbTransaksi.Controls.Add(Me.cbLedgerID)
        Me.gbTransaksi.Controls.Add(Me.cbBranchID)
        Me.gbTransaksi.Controls.Add(Me.txtCreatedBy)
        Me.gbTransaksi.Controls.Add(Me.txtCredit)
        Me.gbTransaksi.Controls.Add(Me.btnRejectJournal)
        Me.gbTransaksi.Controls.Add(Me.btnAddJournal)
        Me.gbTransaksi.Controls.Add(Me.btnApproveJournal)
        Me.gbTransaksi.Controls.Add(Me.txtDebit)
        Me.gbTransaksi.Controls.Add(Me.btnPostJournal)
        Me.gbTransaksi.Controls.Add(Me.btnReverseJournal)
        Me.gbTransaksi.Controls.Add(Me.Label7)
        Me.gbTransaksi.Controls.Add(Me.Label6)
        Me.gbTransaksi.Controls.Add(Me.Label5)
        Me.gbTransaksi.Controls.Add(Me.Label4)
        Me.gbTransaksi.Controls.Add(Me.Label3)
        Me.gbTransaksi.Controls.Add(Me.Label1)
        Me.gbTransaksi.Location = New System.Drawing.Point(8, 7)
        Me.gbTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.gbTransaksi.Name = "gbTransaksi"
        Me.gbTransaksi.Padding = New System.Windows.Forms.Padding(4)
        Me.gbTransaksi.Size = New System.Drawing.Size(612, 250)
        Me.gbTransaksi.TabIndex = 9
        Me.gbTransaksi.TabStop = False
        Me.gbTransaksi.Text = "Transaksi"
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Location = New System.Drawing.Point(176, 213)
        Me.txtCreatedBy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(183, 22)
        Me.txtCreatedBy.TabIndex = 13
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(176, 181)
        Me.txtCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(183, 22)
        Me.txtCredit.TabIndex = 12
        '
        'btnRejectJournal
        '
        Me.btnRejectJournal.Location = New System.Drawing.Point(441, 209)
        Me.btnRejectJournal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRejectJournal.Name = "btnRejectJournal"
        Me.btnRejectJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnRejectJournal.TabIndex = 12
        Me.btnRejectJournal.Text = "Reject Journal"
        Me.btnRejectJournal.UseVisualStyleBackColor = True
        '
        'btnAddJournal
        '
        Me.btnAddJournal.Location = New System.Drawing.Point(441, 25)
        Me.btnAddJournal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddJournal.Name = "btnAddJournal"
        Me.btnAddJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnAddJournal.TabIndex = 10
        Me.btnAddJournal.Text = "Add Journal"
        Me.btnAddJournal.UseVisualStyleBackColor = True
        '
        'btnApproveJournal
        '
        Me.btnApproveJournal.Location = New System.Drawing.Point(441, 169)
        Me.btnApproveJournal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApproveJournal.Name = "btnApproveJournal"
        Me.btnApproveJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnApproveJournal.TabIndex = 11
        Me.btnApproveJournal.Text = "Approve Journal"
        Me.btnApproveJournal.UseVisualStyleBackColor = True
        '
        'txtDebit
        '
        Me.txtDebit.Location = New System.Drawing.Point(176, 149)
        Me.txtDebit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(183, 22)
        Me.txtDebit.TabIndex = 11
        '
        'btnPostJournal
        '
        Me.btnPostJournal.Location = New System.Drawing.Point(441, 117)
        Me.btnPostJournal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPostJournal.Name = "btnPostJournal"
        Me.btnPostJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnPostJournal.TabIndex = 14
        Me.btnPostJournal.Text = "Post Journal"
        Me.btnPostJournal.UseVisualStyleBackColor = True
        '
        'btnReverseJournal
        '
        Me.btnReverseJournal.Location = New System.Drawing.Point(441, 73)
        Me.btnReverseJournal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReverseJournal.Name = "btnReverseJournal"
        Me.btnReverseJournal.Size = New System.Drawing.Size(131, 28)
        Me.btnReverseJournal.TabIndex = 13
        Me.btnReverseJournal.Text = "Reverse Journal"
        Me.btnReverseJournal.UseVisualStyleBackColor = True
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
        'tabDataJurnal
        '
        Me.tabDataJurnal.Controls.Add(Me.btnSelanjutnya)
        Me.tabDataJurnal.Controls.Add(Me.btnRefreshJurnal)
        Me.tabDataJurnal.Controls.Add(Me.btnKembali)
        Me.tabDataJurnal.Controls.Add(Me.dgvJournalEntri)
        Me.tabDataJurnal.Location = New System.Drawing.Point(4, 25)
        Me.tabDataJurnal.Margin = New System.Windows.Forms.Padding(4)
        Me.tabDataJurnal.Name = "tabDataJurnal"
        Me.tabDataJurnal.Padding = New System.Windows.Forms.Padding(4)
        Me.tabDataJurnal.Size = New System.Drawing.Size(629, 513)
        Me.tabDataJurnal.TabIndex = 1
        Me.tabDataJurnal.Text = "Data Jurnal"
        Me.tabDataJurnal.UseVisualStyleBackColor = True
        '
        'btnSelanjutnya
        '
        Me.btnSelanjutnya.Location = New System.Drawing.Point(519, 473)
        Me.btnSelanjutnya.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelanjutnya.Name = "btnSelanjutnya"
        Me.btnSelanjutnya.Size = New System.Drawing.Size(100, 28)
        Me.btnSelanjutnya.TabIndex = 3
        Me.btnSelanjutnya.Text = "Selanjutnya"
        Me.btnSelanjutnya.UseVisualStyleBackColor = True
        '
        'btnRefreshJurnal
        '
        Me.btnRefreshJurnal.Location = New System.Drawing.Point(247, 473)
        Me.btnRefreshJurnal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshJurnal.Name = "btnRefreshJurnal"
        Me.btnRefreshJurnal.Size = New System.Drawing.Size(131, 28)
        Me.btnRefreshJurnal.TabIndex = 2
        Me.btnRefreshJurnal.Text = "Refresh Jurnal"
        Me.btnRefreshJurnal.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(8, 473)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4)
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
        Me.dgvJournalEntri.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvJournalEntri.Name = "dgvJournalEntri"
        Me.dgvJournalEntri.RowHeadersWidth = 51
        Me.dgvJournalEntri.Size = New System.Drawing.Size(611, 458)
        Me.dgvJournalEntri.TabIndex = 0
        '
        'tabMasterBranch
        '
        Me.tabMasterBranch.Controls.Add(Me.dgvMasterBranch)
        Me.tabMasterBranch.Controls.Add(Me.gbMasterBranch)
        Me.tabMasterBranch.Location = New System.Drawing.Point(4, 25)
        Me.tabMasterBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.tabMasterBranch.Name = "tabMasterBranch"
        Me.tabMasterBranch.Padding = New System.Windows.Forms.Padding(4)
        Me.tabMasterBranch.Size = New System.Drawing.Size(629, 513)
        Me.tabMasterBranch.TabIndex = 0
        Me.tabMasterBranch.Text = "Master Branch"
        Me.tabMasterBranch.UseVisualStyleBackColor = True
        '
        'dgvMasterBranch
        '
        Me.dgvMasterBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterBranch.Location = New System.Drawing.Point(8, 214)
        Me.dgvMasterBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMasterBranch.Name = "dgvMasterBranch"
        Me.dgvMasterBranch.RowHeadersWidth = 51
        Me.dgvMasterBranch.Size = New System.Drawing.Size(611, 288)
        Me.dgvMasterBranch.TabIndex = 1
        '
        'gbMasterBranch
        '
        Me.gbMasterBranch.Controls.Add(Me.btnDeleteBranch)
        Me.gbMasterBranch.Controls.Add(Me.btnEditBranch)
        Me.gbMasterBranch.Controls.Add(Me.btnAddBranch)
        Me.gbMasterBranch.Controls.Add(Me.txtAlamat)
        Me.gbMasterBranch.Controls.Add(Me.txtBranchName)
        Me.gbMasterBranch.Controls.Add(Me.Label11)
        Me.gbMasterBranch.Controls.Add(Me.Label10)
        Me.gbMasterBranch.Controls.Add(Me.Label9)
        Me.gbMasterBranch.Location = New System.Drawing.Point(8, 7)
        Me.gbMasterBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.gbMasterBranch.Name = "gbMasterBranch"
        Me.gbMasterBranch.Padding = New System.Windows.Forms.Padding(4)
        Me.gbMasterBranch.Size = New System.Drawing.Size(611, 199)
        Me.gbMasterBranch.TabIndex = 0
        Me.gbMasterBranch.TabStop = False
        Me.gbMasterBranch.Text = "Master Branch"
        '
        'btnDeleteBranch
        '
        Me.btnDeleteBranch.Location = New System.Drawing.Point(432, 148)
        Me.btnDeleteBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteBranch.Name = "btnDeleteBranch"
        Me.btnDeleteBranch.Size = New System.Drawing.Size(124, 28)
        Me.btnDeleteBranch.TabIndex = 8
        Me.btnDeleteBranch.Text = "Delete Branch"
        Me.btnDeleteBranch.UseVisualStyleBackColor = True
        '
        'btnEditBranch
        '
        Me.btnEditBranch.Location = New System.Drawing.Point(219, 148)
        Me.btnEditBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditBranch.Name = "btnEditBranch"
        Me.btnEditBranch.Size = New System.Drawing.Size(100, 28)
        Me.btnEditBranch.TabIndex = 7
        Me.btnEditBranch.Text = "Edit Branch"
        Me.btnEditBranch.UseVisualStyleBackColor = True
        '
        'btnAddBranch
        '
        Me.btnAddBranch.Location = New System.Drawing.Point(24, 148)
        Me.btnAddBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddBranch.Name = "btnAddBranch"
        Me.btnAddBranch.Size = New System.Drawing.Size(100, 28)
        Me.btnAddBranch.TabIndex = 6
        Me.btnAddBranch.Text = "Add Branch"
        Me.btnAddBranch.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(120, 86)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(481, 22)
        Me.txtAlamat.TabIndex = 5
        '
        'txtBranchName
        '
        Me.txtBranchName.Location = New System.Drawing.Point(120, 49)
        Me.txtBranchName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(481, 22)
        Me.txtBranchName.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 90)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 53)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Branch Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Branch ID"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMasterBranch)
        Me.TabControl1.Controls.Add(Me.tabDataJurnal)
        Me.TabControl1.Controls.Add(Me.tabTransaksi)
        Me.TabControl1.Controls.Add(Me.tabLaporan)
        Me.TabControl1.Location = New System.Drawing.Point(17, 53)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(637, 542)
        Me.TabControl1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(684, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Ledger Accounts"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(684, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cost Center"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(684, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Department"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbBranchID
        '
        Me.cbBranchID.FormattingEnabled = True
        Me.cbBranchID.Location = New System.Drawing.Point(157, 22)
        Me.cbBranchID.Name = "cbBranchID"
        Me.cbBranchID.Size = New System.Drawing.Size(202, 24)
        Me.cbBranchID.TabIndex = 15
        '
        'cbLedgerID
        '
        Me.cbLedgerID.FormattingEnabled = True
        Me.cbLedgerID.Location = New System.Drawing.Point(157, 81)
        Me.cbLedgerID.Name = "cbLedgerID"
        Me.cbLedgerID.Size = New System.Drawing.Size(202, 24)
        Me.cbLedgerID.TabIndex = 16
        '
        'cbCostCenterID
        '
        Me.cbCostCenterID.FormattingEnabled = True
        Me.cbCostCenterID.Location = New System.Drawing.Point(157, 113)
        Me.cbCostCenterID.Name = "cbCostCenterID"
        Me.cbCostCenterID.Size = New System.Drawing.Size(202, 24)
        Me.cbCostCenterID.TabIndex = 17
        '
        'BankGeneralLedgerApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 606)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.header)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BankGeneralLedgerApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank General Ledger App"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLaporan.ResumeLayout(False)
        CType(Me.chartGrafikSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLaporan.ResumeLayout(False)
        Me.gbLaporan.PerformLayout()
        Me.tabTransaksi.ResumeLayout(False)
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTransaksi.ResumeLayout(False)
        Me.gbTransaksi.PerformLayout()
        Me.tabDataJurnal.ResumeLayout(False)
        CType(Me.dgvJournalEntri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMasterBranch.ResumeLayout(False)
        CType(Me.dgvMasterBranch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMasterBranch.ResumeLayout(False)
        Me.gbMasterBranch.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
    Friend WithEvents tabLaporan As TabPage
    Friend WithEvents chartGrafikSaldo As DataVisualization.Charting.Chart
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents gbLaporan As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpPeriode As DateTimePicker
    Friend WithEvents cmbCabang As ComboBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents tabDataJurnal As TabPage
    Friend WithEvents btnSelanjutnya As Button
    Friend WithEvents btnRefreshJurnal As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvJournalEntri As DataGridView
    Friend WithEvents tabMasterBranch As TabPage
    Friend WithEvents dgvMasterBranch As DataGridView
    Friend WithEvents gbMasterBranch As GroupBox
    Friend WithEvents btnDeleteBranch As Button
    Friend WithEvents btnEditBranch As Button
    Friend WithEvents btnAddBranch As Button
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtBranchName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cbCostCenterID As ComboBox
    Friend WithEvents cbLedgerID As ComboBox
    Friend WithEvents cbBranchID As ComboBox
End Class
