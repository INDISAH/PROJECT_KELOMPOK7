Public Class DataBarang

    Private Sub DataBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KELOMPOK_7DataSet.Tbl_Barang' table. You can move, or remove it, as needed.
        Me.Tbl_BarangTableAdapter.Fill(Me.KELOMPOK_7DataSet.Tbl_Barang)
        'TODO: This line of code loads data into the 'KELOMPOK_7DataSet.Query3' table. You can move, or remove it, as needed.
        Me.Query3TableAdapter.Fill(Me.KELOMPOK_7DataSet.Query3)
        'TODO: This line of code loads data into the 'KELOMPOK_7DataSet.Tbl_D_Pjl' table. You can move, or remove it, as needed.
        Me.Tbl_D_PjlTableAdapter.Fill(Me.KELOMPOK_7DataSet.Tbl_D_Pjl)
        'TODO: This line of code loads data into the 'KELOMPOK_7DataSet.Query4' table. You can move, or remove it, as needed.
        Me.Query4TableAdapter.Fill(Me.KELOMPOK_7DataSet.Query4)

    End Sub

    Private Sub TambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        Query4BindingSource.AddNew()
        Query3BindingSource.AddNew()
    End Sub

    Private Sub BatalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalButton.Click

        Query3BindingSource.CancelEdit()
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click

        Me.Query3TableAdapter.Fill(Me.KELOMPOK_7DataSet.Query3)
    End Sub

    Private Sub KeluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarButton.Click
        Me.Close()
    End Sub

    Private Sub Query4DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Query4DataGridView.CellContentClick

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        _Kode_BarangTextBox.Enabled = True
        Nama_barangTextBox1.Enabled = True
        SatuanTextBox1.Enabled = True
        HargaTextBox1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Query4BindingSource.AddNew()
    End Sub

    Private Sub Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapus.Click
        If MessageBox.Show("Hapus data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Query3BindingSource.RemoveCurrent()

            Me.Validate()
            Me.Query3BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.KELOMPOK_7DataSet)

            MessageBox.Show(" Data telah di hapus !")
        End If
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        _Kode_BarangTextBox.Enabled = True
        Nama_barangTextBox1.Enabled = True
        SatuanTextBox1.Enabled = True
        HargaTextBox1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Query3BindingSource.AddNew()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Query4TableAdapter.Fill(Me.KELOMPOK_7DataSet.Query4)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Query4BindingSource.CancelEdit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        No_FakTextBox.Enabled = True
        Nama_barangTextBox.Enabled = True
        SatuanTextBox.Enabled = True
        HargaTextBox.Enabled = True
        JumlahTextBox.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("Hapus data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Query4BindingSource.RemoveCurrent()

            Me.Validate()
            Me.Query4BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.KELOMPOK_7DataSet)

            MessageBox.Show(" Data telah di hapus !")
        End If
    End Sub

    Private Sub Nama_barangTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nama_barangTextBox.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        No_FakTextBox.Enabled = True
        Nama_barangTextBox.Enabled = True
        SatuanTextBox.Enabled = True
        HargaTextBox.Enabled = True
        JumlahTextBox.Enabled = True
    End Sub
End Class