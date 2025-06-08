Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient

Public Class BankGeneralLedgerApp
    Inherits Form

    ' Connection string – sesuaikan password dan detail MySQL Anda.
    Private connectionString As String = "server=localhost;user id=root;database=general_ledger_db;password=;"

    ' FORM LOAD: Panggil semua metode untuk mengisi tiap tab di-load

    Private Sub BankGeneralLedgerApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMasterBranch()
        LoadDataJurnal()
        LoadTransaksi()
        LoadLaporan()
    End Sub

    ' Helper Function: Eksekusi query dan kembalikan DataTable

    Private Function GetData(query As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ' TAB 1: MASTER BRANCH

    ' Muat data branches pada DataGridView: dgvMasterBranch
    Private Sub LoadMasterBranch()
        Dim query As String = "SELECT * FROM branches ORDER BY branch_id ASC"
        dgvMasterBranch.DataSource = GetData(query)
    End Sub

    ' --- CREATE Branch ---
    Private Sub btnAddBranch_Click(sender As Object, e As EventArgs) Handles btnAddBranch.Click
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO branches (branch_name, branch_address) VALUES (@branch_name, @branch_address)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@branch_name", txtBranchName.Text.Trim())
                cmd.Parameters.AddWithValue("@branch_address", txtAlamat.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadMasterBranch()
        MessageBox.Show("Branch berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' UPDATE Branch
    Private Sub btnEditBranch_Click(sender As Object, e As EventArgs) Handles btnEditBranch.Click
        If dgvMasterBranch.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih branch yang ingin diedit!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim branchID As Integer = Convert.ToInt32(dgvMasterBranch.SelectedRows(0).Cells("branch_id").Value)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "UPDATE branches SET branch_name = @branch_name, branch_address = @branch_address WHERE branch_id = @branch_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@branch_name", txtBranchName.Text.Trim())
                cmd.Parameters.AddWithValue("@branch_address", txtAlamat.Text.Trim())
                cmd.Parameters.AddWithValue("@branch_id", branchID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadMasterBranch()
        MessageBox.Show("Branch berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' DELETE Branch
    Private Sub btnDeleteBranch_Click(sender As Object, e As EventArgs) Handles btnDeleteBranch.Click
        If dgvMasterBranch.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih branch yang ingin dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim branchID As Integer = Convert.ToInt32(dgvMasterBranch.SelectedRows(0).Cells("branch_id").Value)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "DELETE FROM branches WHERE branch_id = @branch_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@branch_id", branchID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadMasterBranch()
        MessageBox.Show("Branch dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    ' TAB 2: DATA JURNAL


    ' Muat semua data jurnal di DataGridView: dgvJournalEntri
    Private Sub LoadDataJurnal()
        Dim query As String = "SELECT * FROM journal_entries ORDER BY created_at DESC"
        dgvJournalEntri.DataSource = GetData(query)
    End Sub

    ' Tombol refresh untuk data jurnal
    Private Sub btnRefreshJurnal_Click(sender As Object, e As EventArgs) Handles btnRefreshJurnal.Click
        LoadDataJurnal()
    End Sub

    ' Tombol navigasi untuk pagination (contoh sederhana)
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MessageBox.Show("Navigasi ke halaman sebelumnya (pagination dikembangkan jika diperlukan).")
    End Sub

    Private Sub btnSelanjutnya_Click(sender As Object, e As EventArgs) Handles btnSelanjutnya.Click
        MessageBox.Show("Navigasi ke halaman berikutnya (pagination dikembangkan jika diperlukan).")
    End Sub


    ' TAB 3: TRANSAKSI


    ' Muat transaksi dengan status NEW ke DataGridView: dgvTransaksi
    Private Sub LoadTransaksi()
        Dim query As String = "SELECT * FROM journal_entries WHERE status = 'NEW' ORDER BY created_at DESC"
        dgvTransaksi.DataSource = GetData(query)
        Dim conn As New MySqlConnection(connectionString)
        conn.Open()

        ' --- Isi cbBranchID ---
        Dim cmdBranch As New MySqlCommand("SELECT branch_id, branch_name FROM branches", conn)
        Dim readerBranch As MySqlDataReader = cmdBranch.ExecuteReader()
        cbBranchID.Items.Clear()
        While readerBranch.Read()
            cbBranchID.Items.Add(readerBranch("branch_id").ToString() & " - " & readerBranch("branch_name").ToString())
        End While
        readerBranch.Close()

        ' --- Isi cbLedgerID ---
        Dim cmdLedger As New MySqlCommand("SELECT ledger_id, account_name FROM ledger_accounts", conn)
        Dim readerLedger As MySqlDataReader = cmdLedger.ExecuteReader()
        cbLedgerID.Items.Clear()
        While readerLedger.Read()
            cbLedgerID.Items.Add(readerLedger("ledger_id").ToString() & " - " & readerLedger("account_name").ToString())
        End While
        readerLedger.Close()

        ' --- Isi cbCostCenterID ---
        Dim cmdCostCenter As New MySqlCommand("SELECT cost_center_id, cost_center_name FROM cost_centers", conn)
        Dim readerCostCenter As MySqlDataReader = cmdCostCenter.ExecuteReader()
        cbCostCenterID.Items.Clear()
        While readerCostCenter.Read()
            cbCostCenterID.Items.Add(readerCostCenter("cost_center_id").ToString() & " - " & readerCostCenter("cost_center_name").ToString())
        End While
        readerCostCenter.Close()

        conn.Close()

        conn.Close()
    End Sub







    ' Tambah transaksi melalui stored procedure sp_insert_bank_transaction
    Private Sub btnAddJournal_Click(sender As Object, e As EventArgs) Handles btnAddJournal.Click
        ' Ambil nilai transaksi – gunakan DateTime.Now atau kontrol DateTimePicker jika tersedia.
        Dim transactionDate As DateTime = DateTime.Now
        Dim branchID As Integer
        Dim ledgerID As Integer
        Dim costCenterID As Integer
        Dim debitAmount As Decimal
        Dim creditAmount As Decimal
        Dim createdBy As String = txtCreatedBy.Text.Trim()

        If Not Integer.TryParse(cbBranchID.SelectedItem?.ToString(), branchID) Then
            MessageBox.Show("Branch ID tidak valid!")
            Exit Sub
        End If
        If Not Integer.TryParse(cbLedgerID.Text, ledgerID) Then
            MessageBox.Show("Ledger ID tidak valid!")
            Exit Sub
        End If
        If Not Integer.TryParse(cbCostCenterID.SelectedItem?.ToString(), costCenterID) Then
            MessageBox.Show("Cost Center ID tidak valid!")
            Exit Sub
        End If
        If Not Decimal.TryParse(txtDebit.Text, debitAmount) Then
            MessageBox.Show("Input Debit tidak valid!")
            Exit Sub
        End If
        If Not Decimal.TryParse(txtCredit.Text, creditAmount) Then
            MessageBox.Show("Input Credit tidak valid!")
            Exit Sub
        End If

        ' Validasi: hanya salah satu (Debit atau Credit) yang valid
        If (debitAmount <= 0 And creditAmount <= 0) Or (debitAmount > 0 And creditAmount > 0) Then
            MessageBox.Show("Transaksi tidak valid: Tentukan satu antara Debit atau Credit!")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand("sp_insert_bank_transaction", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("p_transaction_date", transactionDate)
                cmd.Parameters.AddWithValue("p_branch_id", branchID)
                cmd.Parameters.AddWithValue("p_ledger_id", ledgerID)
                cmd.Parameters.AddWithValue("p_cost_center_id", costCenterID)
                cmd.Parameters.AddWithValue("p_debit", debitAmount)
                cmd.Parameters.AddWithValue("p_credit", creditAmount)
                cmd.Parameters.AddWithValue("p_audittrail", "Transaksi via WinForms")
                cmd.Parameters.AddWithValue("p_created_by", createdBy)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadTransaksi()
        LoadDataJurnal() ' Refresh data jurnal secara keseluruhan
        MessageBox.Show("Transaksi berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Fungsi helper untuk mengubah status transaksi (Approve, Reject, Reverse, Post)
    Private Sub UpdateTransactionStatus(newStatus As String, Optional currentStatus As String = "")
        If dgvTransaksi.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih transaksi terlebih dahulu!")
            Exit Sub
        End If

        Dim journalID As Integer = Convert.ToInt32(dgvTransaksi.SelectedRows(0).Cells("journal_id").Value)
        Dim query As String = "UPDATE journal_entries SET status = @newStatus WHERE journal_id = @journalID"
        If currentStatus <> "" Then query &= " AND status = @currentStatus"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@newStatus", newStatus)
                cmd.Parameters.AddWithValue("@journalID", journalID)
                If currentStatus <> "" Then
                    cmd.Parameters.AddWithValue("@currentStatus", currentStatus)
                End If
                Dim affected As Integer = cmd.ExecuteNonQuery()
                If affected = 0 Then
                    MessageBox.Show("Gagal mengubah status transaksi. Pastikan transaksi dipilih dan status sesuai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using
        End Using

        LoadTransaksi()
        LoadDataJurnal()
        MessageBox.Show("Status transaksi diubah ke " & newStatus, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnApproveJournal_Click(sender As Object, e As EventArgs) Handles btnApproveJournal.Click
        UpdateTransactionStatus("APR", "NEW")
    End Sub

    Private Sub btnRejectJournal_Click(sender As Object, e As EventArgs) Handles btnRejectJournal.Click
        UpdateTransactionStatus("RJC", "NEW")
    End Sub

    Private Sub btnReverseJournal_Click(sender As Object, e As EventArgs) Handles btnReverseJournal.Click
        UpdateTransactionStatus("NEW", "APR")
    End Sub

    Private Sub btnPostJournal_Click(sender As Object, e As EventArgs) Handles btnPostJournal.Click
        UpdateTransactionStatus("PST", "APR")
    End Sub


    ' TAB 4: LAPORAN


    ' Muat laporan dasar (tanpa filter khusus) ke DataGridView: dgvLaporan
    Private Sub LoadLaporan()
        Dim query As String = "SELECT branch_id, ledger_id, SUM(debit) AS TotalDebit, SUM(credit) AS TotalCredit FROM journal_entries GROUP BY branch_id, ledger_id"
        dgvLaporan.DataSource = GetData(query)
    End Sub

    ' Generate laporan berdasarkan periode (dan filter opsional)
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim startDate As DateTime = dtpPeriode.Value
        Dim endDate As DateTime = DateTime.Now ' Bisa diganti dengan kontrol tambahan untuk tanggal akhir jika diperlukan
        Dim query As String = "SELECT branch_id, ledger_id, SUM(debit) AS TotalDebit, SUM(credit) AS TotalCredit " &
                              "FROM journal_entries WHERE transaction_date BETWEEN @startDate AND @endDate " &
                              "GROUP BY branch_id, ledger_id"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@startDate", startDate)
                cmd.Parameters.AddWithValue("@endDate", endDate)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvLaporan.DataSource = dt
            End Using
        End Using

        ' Perbarui grafik saldo bank setelah laporan di-load
        LoadBankBalances()
    End Sub

    ' Muat saldo bank ke Chart: chartGrafikSaldo
    Private Sub LoadBankBalances()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ledger_id, balance FROM bank_balances"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Pastikan Chart memiliki setidaknya satu series. Misalnya: Series dengan index = 0
                    chartGrafikSaldo.Series(0).Points.Clear()
                    While reader.Read()
                        chartGrafikSaldo.Series(0).Points.AddXY(reader("ledger_id").ToString(), Convert.ToDecimal(reader("balance")))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cbtTransaksiBranchID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBranchID.SelectedIndexChanged

    End Sub

    Private Sub cbLedgerID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLedgerID.SelectedIndexChanged

    End Sub
End Class
