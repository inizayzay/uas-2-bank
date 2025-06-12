Imports MySql.Data.MySqlClient

Public Class ledgeraccounts
    Private connectionString As String = "server=localhost;user id=root;database=general_ledger_db;password=;"

    Private Sub ledgeraccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ledgeraccounts()
    End Sub

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

    Private Sub ledgeraccounts()
        Dim query As String = "SELECT * FROM ledger_accounts ORDER BY ledger_id ASC"
        DataGridView1.DataSource = GetData(query)
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO ledger_accounts (account_code, account_name) VALUES (@account_code, @account_name)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@account_code", txtcode.Text.Trim())
                cmd.Parameters.AddWithValue("@account_name", txtnama.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using
        End Using
        ledgeraccounts()
        MessageBox.Show("ledgeraccounts berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih ledgeraccounts yang ingin diedit!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim ledgerID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("ledger_id").Value)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "UPDATE ledger_accounts SET account_name = @account_nama, account_code = @account_code WHERE ledger_id = @ledger_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@account_code", txtcode.Text.Trim())
                cmd.Parameters.AddWithValue("@account_nama", txtnama.Text.Trim())
                cmd.Parameters.AddWithValue("@ledger_id", ledgerID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        ledgeraccounts()
        MessageBox.Show("Ledger berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih ledgeraccounts yang ingin dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim ledgerID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("ledger_id").Value)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "DELETE FROM ledger_accounts WHERE ledger_id = @ledger_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ledger_id", ledgerID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        ledgeraccounts()
        MessageBox.Show("ledgeraccounts dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class