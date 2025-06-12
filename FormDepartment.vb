Imports MySql.Data.MySqlClient

Public Class FormDepartment
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim cc = New BankGeneralLedgerApp()
        cc.Show()
        Me.Hide()
    End Sub

    Private Sub FormMasterDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then conn.Open()
        TampilBranch()
        TampilDepartment()
    End Sub

    Sub TampilBranch()
        Dim dt As New DataTable()
        Dim cmd As New MySqlCommand("SELECT branch_id, branch_name FROM branches", conn)
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        cbBranch.DataSource = dt
        cbBranch.DisplayMember = "branch_name"
        cbBranch.ValueMember = "branch_id"
        cbBranch.SelectedIndex = -1
    End Sub

    Sub TampilDepartment()
        Dim da As New MySqlDataAdapter("SELECT d.department_id, d.department_name, b.branch_name FROM departments d JOIN branches b ON d.branch_id = b.branch_id", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvDepartment.DataSource = dt
        dgvDepartment.ClearSelection()
    End Sub

    Sub ClearForm()
        txtDeptName.Clear()
        cbBranch.SelectedIndex = -1
        dgvDepartment.ClearSelection()
    End Sub

    Private Sub btnAddDept_Click(sender As Object, e As EventArgs) Handles btnAddDept.Click
        If txtDeptName.Text = "" Or cbBranch.SelectedIndex = -1 Then
            MessageBox.Show("Isi semua field!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim branchID As String = cbBranch.SelectedValue.ToString()
        Dim cmd As New MySqlCommand("INSERT INTO departments (department_name, branch_id) VALUES (@nama, @branch_id)", conn)
        cmd.Parameters.AddWithValue("@nama", txtDeptName.Text.Trim())
        cmd.Parameters.AddWithValue("@branch_id", branchID)
        cmd.ExecuteNonQuery()
        TampilDepartment()
        ClearForm()
        MessageBox.Show("Departemen ditambahkan.")
    End Sub

    Private Sub btnEditDept_Click(sender As Object, e As EventArgs) Handles btnEditDept.Click
        If dgvDepartment.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris untuk diedit.")
            Exit Sub
        End If

        Dim id As Integer = dgvDepartment.SelectedRows(0).Cells("department_id").Value
        Dim branchID As String = cbBranch.SelectedValue.ToString()
        Dim cmd As New MySqlCommand("UPDATE departments SET department_name=@nama, branch_id=@branch_id WHERE department_id=@id", conn)
        cmd.Parameters.AddWithValue("@nama", txtDeptName.Text.Trim())
        cmd.Parameters.AddWithValue("@branch_id", branchID)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.ExecuteNonQuery()
        TampilDepartment()
        ClearForm()
        MessageBox.Show("Departemen diperbarui.")
    End Sub

    Private Sub btnDeleteDept_Click(sender As Object, e As EventArgs) Handles btnDeleteDept.Click
        If dgvDepartment.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris untuk dihapus.")
            Exit Sub
        End If

        Dim id As Integer = dgvDepartment.SelectedRows(0).Cells("department_id").Value
        Dim cmd As New MySqlCommand("DELETE FROM departments WHERE department_id=@id", conn)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.ExecuteNonQuery()
        TampilDepartment()
        ClearForm()
        MessageBox.Show("Departemen dihapus.")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Function GetData(query As String) As DataTable
        Dim dt As New DataTable()
        conn.Open()
        Using cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Private Sub dgvDepartment_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDepartment.SelectionChanged
        If dgvDepartment.SelectedRows.Count > 0 Then
            txtDeptName.Text = dgvDepartment.SelectedRows(0).Cells("department_name").Value.ToString()
            Dim selectedBranchName As String = dgvDepartment.SelectedRows(0).Cells("branch_name").Value.ToString()

            ' Cari dan set SelectedValue berdasarkan nama cabang
            'For Each item As DataRowView In cbBranch.Items
            '    If item("branch_name").ToString() = selectedBranchName Then
            '        cbBranch.SelectedValue = item("branch_id")
            '        Exit For
            '    End If
            'Next

            Dim dt_branch As DataTable = GetData("SELECT * FROM branches")
            If dt_branch IsNot Nothing Then
                cbBranch.DataSource = dt_branch
                cbBranch.DisplayMember = "branch_name"
                cbBranch.ValueMember = "branch_id"
            End If
        End If
    End Sub

    Private Sub cbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBranch.SelectedIndexChanged
        ' Tidak perlu aksi khusus di sini, tapi bisa kamu tambahkan jika ingin validasi tambahan.
    End Sub
End Class
