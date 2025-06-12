Imports MySql.Data.MySqlClient

Public Class CostCenter

    Private connectionString As String = "server=localhost;user id=root;database=general_ledger_db;password=;"

    Private Sub CostCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMasterCostCentre()
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

    Private Sub LoadMasterCostCentre()
        Dim query As String = "SELECT * FROM cost_centers ORDER BY cost_center_id ASC"
        dgvMasterCostCenter.DataSource = GetData(query)

        Dim dt_branch As DataTable = GetData("SELECT * FROM branches")
        If dt_branch IsNot Nothing Then
            cbtBranchCC.DataSource = dt_branch
            cbtBranchCC.DisplayMember = "branch_name"
            cbtBranchCC.ValueMember = "branch_id"
        End If

        Dim dt_departement As DataTable = GetData("SELECT * FROM departments")
        If dt_departement IsNot Nothing Then
            cbtDepartmenthCC.DataSource = dt_departement
            cbtDepartmenthCC.DisplayMember = "department_name"
            cbtDepartmenthCC.ValueMember = "department_id"
        End If
    End Sub

    Private Sub btnAddCostCenter_Click(sender As Object, e As EventArgs) Handles btnAddCostCenter.Click
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO cost_centers (cost_center_name, branch_id, department_id) VALUES (@cost_center_name, @branch_id, @department_id)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cost_center_name", txtCCName.Text.Trim())
                cmd.Parameters.AddWithValue("@branch_id", cbtBranchCC.SelectedValue)
                cmd.Parameters.AddWithValue("@department_id", cbtDepartmenthCC.SelectedValue)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadMasterCostCentre()
        MessageBox.Show("Cost Center berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnEditCostCenter_Click(sender As Object, e As EventArgs) Handles btnEditCostCenter.Click

        If dgvMasterCostCenter.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih Cost Center yang ingin diedit!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim CCID As Integer = Convert.ToInt32(dgvMasterCostCenter.SelectedRows(0).Cells("cost_center_id").Value)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "UPDATE cost_centers SET cost_center_name = @cost_center_name, branch_id = @branch_id, department_id = @department_id WHERE cost_center_id = @cost_center_id "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@branch_id", cbtBranchCC.SelectedValue)
                cmd.Parameters.AddWithValue("@cost_center_name", txtCCName.Text)
                cmd.Parameters.AddWithValue("@department_id", cbtDepartmenthCC.SelectedValue)
                cmd.Parameters.AddWithValue("@cost_center_id", CCID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadMasterCostCentre()
        MessageBox.Show("Branch berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDeleteCostCenter_Click(sender As Object, e As EventArgs) Handles btnDeleteCostCenter.Click

        MessageBox.Show("TESTET")

        If dgvMasterCostCenter.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih Cost Center yang ingin dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim CCID As Integer = Convert.ToInt32(dgvMasterCostCenter.SelectedRows(0).Cells("cost_center_id").Value)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "DELETE FROM cost_centers WHERE cost_center_id = @cost_center_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cost_center_id", CCID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadMasterCostCentre()
        MessageBox.Show("Branch dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class