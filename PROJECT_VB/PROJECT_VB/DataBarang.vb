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
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.Validate()
        Me.Query4BindingSource.EndEdit()
    End Sub
End Class
