Imports System.Data
Imports MySql.Data.MySqlClient

Public Class BankGeneralLedgerApp
    Inherits Form

    ' Connection string – sesuaikan password dan detail MySQL Anda.
    Private connectionString As String = "server=localhost;user id=root;database=general_ledger_db;password=yourpassword;"

    ' Konrol di form sudah dibuat melalui Designer:
    ' Misalnya:
    '   dtpTransaction (DateTimePicker) untuk menampilkan tanggal transaksi
    '   txtBranchID, txtLedgerID, txtCostCenterID, txtDebit, txtCredit, txtCreatedBy (TextBox)
    '   btnAddJournal, btnApproveJournal, btnRejectJournal, btnReverseJournal, btnPostJournal (Button)
    '   dgvJournalEntries (DataGridView) untuk menampilkan data jurnal

    Public Sub New()
        ' Memanggil inisialisasi komponen yang dibuat oleh Designer
        InitializeComponent()
    End Sub

    ' Method load form untuk menampilkan data transaksi di DataGridView
    Private Sub FrmGeneralLedgerApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadJournalEntries()
    End Sub

    ' Method untuk mengambil data dari tabel journal_entries
    Private Sub LoadJournalEntries()
        Dim query As String = "SELECT * FROM journal_entries ORDER BY created_at DESC"
        Using conn As New MySqlConnection(connectionString)
                conn.Open()
            Dim query As String = "UPDATE branches SET branch_name = @branch_name, branch_address = @branch_address WHERE branch_id = @branch_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@branch_name", txtBranchName.Text.Trim())
                cmd.Parameters.AddWithValue("@branch_address", txtAlamat.Text.Trim())
                cmd.Parameters.AddWithValue("@branch_id", branchID)
                cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Event handler untuk tombol tambah transaksi (Add Journal)
        dgvJournalEntri.DataSource = GetData(query)
    Private Sub btnAddJournal_Click(sender As Object, e As EventArgs) Handles btnAddJournal.Click
        ' Ambil input dari kontrol
        Dim transactionDate As DateTime = dtpPeriode.Value
        Dim branchID As Integer, ledgerID As Integer, costCenterID As Integer
        Dim debitAmount As Decimal, creditAmount As Decimal
        Dim createdBy As String = txtCreatedBy.Text.Trim()

        ' Validasi input untuk Branch, Ledger, dan Cost Center
        If Not Integer.TryParse(txtTransaksiBranchID.Text, branchID) Then
            MessageBox.Show("Input Branch ID tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Integer.TryParse(txtLedgerID.Text, ledgerID) Then
            MessageBox.Show("Input Ledger ID tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Integer.TryParse(txtCostCenterID.Text, costCenterID) Then
            MessageBox.Show("Input Cost Center ID tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validasi input untuk Debit dan Credit
        If Not Decimal.TryParse(txtDebit.Text, debitAmount) Then
            MessageBox.Show("Input Debit tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Decimal.TryParse(txtCredit.Text, creditAmount) Then
            MessageBox.Show("Input Credit tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validasi: hanya salah satu antara debit atau credit yang boleh lebih dari 0
        If (debitAmount <= 0 And creditAmount <= 0) Or (debitAmount > 0 And creditAmount > 0) Then
            MessageBox.Show("Transaksi tidak valid: Tentukan salah satu antara debit atau credit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Panggil stored procedure sp_insert_bank_transaction untuk memasukkan transaksi
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand("sp_insert_bank_transaction", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' Parameter-parameter sesuai dengan definisi stored procedure
                    cmd.Parameters.AddWithValue("p_transaction_date", transactionDate)
                    cmd.Parameters.AddWithValue("p_branch_id", branchID)
                    cmd.Parameters.AddWithValue("p_ledger_id", ledgerID)
                    cmd.Parameters.AddWithValue("p_cost_center_id", costCenterID)
                    cmd.Parameters.AddWithValue("p_debit", debitAmount)
                    cmd.Parameters.AddWithValue("p_credit", creditAmount)
                    cmd.Parameters.AddWithValue("p_audittrail", "")  ' Bisa dikembangkan untuk menyimpan log aktivitas
                    cmd.Parameters.AddWithValue("p_created_by", createdBy)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Transaksi berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error dalam transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        LoadJournalEntries()
    End Sub

    ' Event handler untuk Approve transaksi (ubah status menjadi 'APR')
    Private Sub btnApproveJournal_Click(sender As Object, e As EventArgs) Handles btnApproveJournal.Click
        If dgvJournalEntries.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih transaksi yang ingin di-approve.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim journalID As Integer = Convert.ToInt32(dgvJournalEntries.SelectedRows(0).Cells("journal_id").Value)
        Dim query As String = "UPDATE journal_entries SET status = 'APR' WHERE journal_id = @journal_id"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@journal_id", journalID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Transaksi berhasil di-approve.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error approve transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        LoadJournalEntries()
    End Sub

    ' Event handler untuk Reject transaksi (ubah status menjadi 'RJC')
    Private Sub btnRejectJournal_Click(sender As Object, e As EventArgs) Handles btnRejectJournal.Click
        If dgvJournalEntries.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih transaksi yang ingin di-reject.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim journalID As Integer = Convert.ToInt32(dgvJournalEntries.SelectedRows(0).Cells("journal_id").Value)
        Dim query As String = "UPDATE journal_entries SET status = 'RJC' WHERE journal_id = @journal_id"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@journal_id", journalID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Transaksi berhasil di-reject.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error reject transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        LoadJournalEntries()
    End Sub

    ' Event handler untuk Reverse transaksi (ubah status APR kembali ke NEW)
    Private Sub btnReverseJournal_Click(sender As Object, e As EventArgs) Handles btnReverseJournal.Click
        If dgvJournalEntries.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih transaksi yang ingin di-reverse.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim journalID As Integer = Convert.ToInt32(dgvJournalEntries.SelectedRows(0).Cells("journal_id").Value)
        Dim query As String = "UPDATE journal_entries SET status = 'NEW' WHERE journal_id = @journal_id AND status = 'APR'"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@journal_id", journalID)
                    Dim affected As Integer = cmd.ExecuteNonQuery()
                    If affected = 0 Then
                        MessageBox.Show("Transaksi tidak dapat direverse karena status tidak 'APR'.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End Using
                MessageBox.Show("Transaksi berhasil di-reverse.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error reverse transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        LoadJournalEntries()
    End Sub

    ' Event handler untuk Post transaksi (ubah status dari APR menjadi PST)
    Private Sub btnPostJournal_Click(sender As Object, e As EventArgs) Handles btnPostJournal.Click
        If dgvJournalEntries.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih transaksi yang ingin dipost.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim journalID As Integer = Convert.ToInt32(dgvJournalEntries.SelectedRows(0).Cells("journal_id").Value)
        Dim query As String = "UPDATE journal_entries SET status = 'PST' WHERE journal_id = @journal_id AND status = 'APR'"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@journal_id", journalID)
                    Dim affected As Integer = cmd.ExecuteNonQuery()
                    If affected = 0 Then
                        MessageBox.Show("Gagal posting transaksi. Pastikan status transaksi adalah 'APR'.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End Using
                MessageBox.Show("Transaksi berhasil dipost.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error post transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        LoadJournalEntries()
    End Sub

End Class
