<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim No_FakLabel As System.Windows.Forms.Label
        Dim Nama_barangLabel As System.Windows.Forms.Label
        Dim SatuanLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim _Kode_BarangLabel As System.Windows.Forms.Label
        Dim Nama_barangLabel1 As System.Windows.Forms.Label
        Dim SatuanLabel1 As System.Windows.Forms.Label
        Dim HargaLabel1 As System.Windows.Forms.Label
        Me.Query4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Query4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KELOMPOK_7DataSet = New PROJECT_VB.KELOMPOK_7DataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.No_FakTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_D_PjlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nama_barangTextBox = New System.Windows.Forms.TextBox()
        Me.SatuanTextBox = New System.Windows.Forms.TextBox()
        Me.HargaTextBox = New System.Windows.Forms.TextBox()
        Me.JumlahTextBox = New System.Windows.Forms.TextBox()
        Me.Query3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Query3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me._Kode_BarangTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nama_barangTextBox1 = New System.Windows.Forms.TextBox()
        Me.SatuanTextBox1 = New System.Windows.Forms.TextBox()
        Me.HargaTextBox1 = New System.Windows.Forms.TextBox()
        Me.Query4TableAdapter = New PROJECT_VB.KELOMPOK_7DataSetTableAdapters.Query4TableAdapter()
        Me.TableAdapterManager = New PROJECT_VB.KELOMPOK_7DataSetTableAdapters.TableAdapterManager()
        Me.Tbl_D_PjlTableAdapter = New PROJECT_VB.KELOMPOK_7DataSetTableAdapters.Tbl_D_PjlTableAdapter()
        Me.Query3TableAdapter = New PROJECT_VB.KELOMPOK_7DataSetTableAdapters.Query3TableAdapter()
        Me.Tbl_BarangTableAdapter = New PROJECT_VB.KELOMPOK_7DataSetTableAdapters.Tbl_BarangTableAdapter()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.KeluarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BatalButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        No_FakLabel = New System.Windows.Forms.Label()
        Nama_barangLabel = New System.Windows.Forms.Label()
        SatuanLabel = New System.Windows.Forms.Label()
        HargaLabel = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        _Kode_BarangLabel = New System.Windows.Forms.Label()
        Nama_barangLabel1 = New System.Windows.Forms.Label()
        SatuanLabel1 = New System.Windows.Forms.Label()
        HargaLabel1 = New System.Windows.Forms.Label()
        CType(Me.Query4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KELOMPOK_7DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_D_PjlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'No_FakLabel
        '
        No_FakLabel.AutoSize = True
        No_FakLabel.Location = New System.Drawing.Point(20, 36)
        No_FakLabel.Name = "No_FakLabel"
        No_FakLabel.Size = New System.Drawing.Size(45, 13)
        No_FakLabel.TabIndex = 0
        No_FakLabel.Text = "No Fak:"
        '
        'Nama_barangLabel
        '
        Nama_barangLabel.AutoSize = True
        Nama_barangLabel.Location = New System.Drawing.Point(20, 62)
        Nama_barangLabel.Name = "Nama_barangLabel"
        Nama_barangLabel.Size = New System.Drawing.Size(74, 13)
        Nama_barangLabel.TabIndex = 2
        Nama_barangLabel.Text = "Nama barang:"
        '
        'SatuanLabel
        '
        SatuanLabel.AutoSize = True
        SatuanLabel.Location = New System.Drawing.Point(20, 88)
        SatuanLabel.Name = "SatuanLabel"
        SatuanLabel.Size = New System.Drawing.Size(44, 13)
        SatuanLabel.TabIndex = 4
        SatuanLabel.Text = "Satuan:"
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.Location = New System.Drawing.Point(20, 114)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(39, 13)
        HargaLabel.TabIndex = 6
        HargaLabel.Text = "Harga:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(20, 140)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(43, 13)
        JumlahLabel.TabIndex = 8
        JumlahLabel.Text = "Jumlah:"
        '
        '_Kode_BarangLabel
        '
        _Kode_BarangLabel.AutoSize = True
        _Kode_BarangLabel.Location = New System.Drawing.Point(20, 40)
        _Kode_BarangLabel.Name = "_Kode_BarangLabel"
        _Kode_BarangLabel.Size = New System.Drawing.Size(76, 13)
        _Kode_BarangLabel.TabIndex = 0
        _Kode_BarangLabel.Text = "*Kode Barang:"
        '
        'Nama_barangLabel1
        '
        Nama_barangLabel1.AutoSize = True
        Nama_barangLabel1.Location = New System.Drawing.Point(20, 66)
        Nama_barangLabel1.Name = "Nama_barangLabel1"
        Nama_barangLabel1.Size = New System.Drawing.Size(74, 13)
        Nama_barangLabel1.TabIndex = 2
        Nama_barangLabel1.Text = "Nama barang:"
        '
        'SatuanLabel1
        '
        SatuanLabel1.AutoSize = True
        SatuanLabel1.Location = New System.Drawing.Point(20, 92)
        SatuanLabel1.Name = "SatuanLabel1"
        SatuanLabel1.Size = New System.Drawing.Size(44, 13)
        SatuanLabel1.TabIndex = 4
        SatuanLabel1.Text = "Satuan:"
        '
        'HargaLabel1
        '
        HargaLabel1.AutoSize = True
        HargaLabel1.Location = New System.Drawing.Point(20, 118)
        HargaLabel1.Name = "HargaLabel1"
        HargaLabel1.Size = New System.Drawing.Size(39, 13)
        HargaLabel1.TabIndex = 6
        HargaLabel1.Text = "Harga:"
        '
        'Query4DataGridView
        '
        Me.Query4DataGridView.AutoGenerateColumns = False
        Me.Query4DataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.Query4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Query4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Query4DataGridView.DataSource = Me.Query4BindingSource
        Me.Query4DataGridView.Location = New System.Drawing.Point(379, 75)
        Me.Query4DataGridView.Name = "Query4DataGridView"
        Me.Query4DataGridView.Size = New System.Drawing.Size(634, 167)
        Me.Query4DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No_Fak"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No_Fak"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_barang"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Satuan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Satuan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Jumlah"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jumlah"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Harga"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total Harga"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Harga"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Query4BindingSource
        '
        Me.Query4BindingSource.DataMember = "Query4"
        Me.Query4BindingSource.DataSource = Me.KELOMPOK_7DataSet
        '
        'KELOMPOK_7DataSet
        '
        Me.KELOMPOK_7DataSet.DataSetName = "KELOMPOK_7DataSet"
        Me.KELOMPOK_7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(No_FakLabel)
        Me.GroupBox1.Controls.Add(Me.No_FakTextBox)
        Me.GroupBox1.Controls.Add(Nama_barangLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_barangTextBox)
        Me.GroupBox1.Controls.Add(SatuanLabel)
        Me.GroupBox1.Controls.Add(Me.SatuanTextBox)
        Me.GroupBox1.Controls.Add(HargaLabel)
        Me.GroupBox1.Controls.Add(Me.HargaTextBox)
        Me.GroupBox1.Controls.Add(JumlahLabel)
        Me.GroupBox1.Controls.Add(Me.JumlahTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 166)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data_Barang"
        '
        'No_FakTextBox
        '
        Me.No_FakTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_D_PjlBindingSource, "No_Fak", True))
        Me.No_FakTextBox.Location = New System.Drawing.Point(100, 33)
        Me.No_FakTextBox.Name = "No_FakTextBox"
        Me.No_FakTextBox.Size = New System.Drawing.Size(116, 20)
        Me.No_FakTextBox.TabIndex = 1
        '
        'Tbl_D_PjlBindingSource
        '
        Me.Tbl_D_PjlBindingSource.DataMember = "Tbl_D_Pjl"
        Me.Tbl_D_PjlBindingSource.DataSource = Me.KELOMPOK_7DataSet
        '
        'Nama_barangTextBox
        '
        Me.Nama_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_D_PjlBindingSource, "Nama_barang", True))
        Me.Nama_barangTextBox.Location = New System.Drawing.Point(100, 59)
        Me.Nama_barangTextBox.Name = "Nama_barangTextBox"
        Me.Nama_barangTextBox.Size = New System.Drawing.Size(235, 20)
        Me.Nama_barangTextBox.TabIndex = 3
        '
        'SatuanTextBox
        '
        Me.SatuanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_D_PjlBindingSource, "Satuan", True))
        Me.SatuanTextBox.Location = New System.Drawing.Point(100, 85)
        Me.SatuanTextBox.Name = "SatuanTextBox"
        Me.SatuanTextBox.Size = New System.Drawing.Size(116, 20)
        Me.SatuanTextBox.TabIndex = 5
        '
        'HargaTextBox
        '
        Me.HargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_D_PjlBindingSource, "Harga", True))
        Me.HargaTextBox.Location = New System.Drawing.Point(100, 111)
        Me.HargaTextBox.Name = "HargaTextBox"
        Me.HargaTextBox.Size = New System.Drawing.Size(116, 20)
        Me.HargaTextBox.TabIndex = 7
        '
        'JumlahTextBox
        '
        Me.JumlahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_D_PjlBindingSource, "Jumlah", True))
        Me.JumlahTextBox.Location = New System.Drawing.Point(100, 137)
        Me.JumlahTextBox.Name = "JumlahTextBox"
        Me.JumlahTextBox.Size = New System.Drawing.Size(116, 20)
        Me.JumlahTextBox.TabIndex = 9
        '
        'Query3DataGridView
        '
        Me.Query3DataGridView.AutoGenerateColumns = False
        Me.Query3DataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.Query3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Query3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Query3DataGridView.DataSource = Me.Query3BindingSource
        Me.Query3DataGridView.Location = New System.Drawing.Point(379, 258)
        Me.Query3DataGridView.Name = "Query3DataGridView"
        Me.Query3DataGridView.Size = New System.Drawing.Size(441, 142)
        Me.Query3DataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Tbl_Barang_*Kode_Barang"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tbl_Barang_*Kode_Barang"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Tbl_Barang_Nama_barang"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tbl_Barang_Nama_barang"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Tbl_Barang_Satuan"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tbl_Barang_Satuan"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Tbl_Barang_Harga"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tbl_Barang_Harga"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Query3BindingSource
        '
        Me.Query3BindingSource.DataMember = "Query3"
        Me.Query3BindingSource.DataSource = Me.KELOMPOK_7DataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(_Kode_BarangLabel)
        Me.GroupBox2.Controls.Add(Me._Kode_BarangTextBox)
        Me.GroupBox2.Controls.Add(Nama_barangLabel1)
        Me.GroupBox2.Controls.Add(Me.Nama_barangTextBox1)
        Me.GroupBox2.Controls.Add(SatuanLabel1)
        Me.GroupBox2.Controls.Add(Me.SatuanTextBox1)
        Me.GroupBox2.Controls.Add(HargaLabel1)
        Me.GroupBox2.Controls.Add(Me.HargaTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 150)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data_Penjualan"
        '
        '_Kode_BarangTextBox
        '
        Me._Kode_BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BarangBindingSource, "*Kode_Barang", True))
        Me._Kode_BarangTextBox.Location = New System.Drawing.Point(102, 37)
        Me._Kode_BarangTextBox.Name = "_Kode_BarangTextBox"
        Me._Kode_BarangTextBox.Size = New System.Drawing.Size(114, 20)
        Me._Kode_BarangTextBox.TabIndex = 1
        '
        'Tbl_BarangBindingSource
        '
        Me.Tbl_BarangBindingSource.DataMember = "Tbl_Barang"
        Me.Tbl_BarangBindingSource.DataSource = Me.KELOMPOK_7DataSet
        '
        'Nama_barangTextBox1
        '
        Me.Nama_barangTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BarangBindingSource, "Nama_barang", True))
        Me.Nama_barangTextBox1.Location = New System.Drawing.Point(102, 63)
        Me.Nama_barangTextBox1.Name = "Nama_barangTextBox1"
        Me.Nama_barangTextBox1.Size = New System.Drawing.Size(233, 20)
        Me.Nama_barangTextBox1.TabIndex = 3
        '
        'SatuanTextBox1
        '
        Me.SatuanTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BarangBindingSource, "Satuan", True))
        Me.SatuanTextBox1.Location = New System.Drawing.Point(102, 89)
        Me.SatuanTextBox1.Name = "SatuanTextBox1"
        Me.SatuanTextBox1.Size = New System.Drawing.Size(114, 20)
        Me.SatuanTextBox1.TabIndex = 5
        '
        'HargaTextBox1
        '
        Me.HargaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BarangBindingSource, "Harga", True))
        Me.HargaTextBox1.Location = New System.Drawing.Point(102, 115)
        Me.HargaTextBox1.Name = "HargaTextBox1"
        Me.HargaTextBox1.Size = New System.Drawing.Size(114, 20)
        Me.HargaTextBox1.TabIndex = 7
        '
        'Query4TableAdapter
        '
        Me.Query4TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tbl_BarangTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_D_PjlTableAdapter = Me.Tbl_D_PjlTableAdapter
        Me.TableAdapterManager.UpdateOrder = PROJECT_VB.KELOMPOK_7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_D_PjlTableAdapter
        '
        Me.Tbl_D_PjlTableAdapter.ClearBeforeFill = True
        '
        'Query3TableAdapter
        '
        Me.Query3TableAdapter.ClearBeforeFill = True
        '
        'Tbl_BarangTableAdapter
        '
        Me.Tbl_BarangTableAdapter.ClearBeforeFill = True
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(12, 430)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(75, 23)
        Me.TambahButton.TabIndex = 5
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(154, 430)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 6
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Location = New System.Drawing.Point(307, 430)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Hapus.TabIndex = 7
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Location = New System.Drawing.Point(458, 430)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(75, 23)
        Me.SimpanButton.TabIndex = 8
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'KeluarButton
        '
        Me.KeluarButton.Location = New System.Drawing.Point(901, 430)
        Me.KeluarButton.Name = "KeluarButton"
        Me.KeluarButton.Size = New System.Drawing.Size(75, 23)
        Me.KeluarButton.TabIndex = 9
        Me.KeluarButton.Text = "Keluar"
        Me.KeluarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 36)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Data Barang"
        '
        'BatalButton
        '
        Me.BatalButton.Location = New System.Drawing.Point(610, 430)
        Me.BatalButton.Name = "BatalButton"
        Me.BatalButton.Size = New System.Drawing.Size(75, 23)
        Me.BatalButton.TabIndex = 11
        Me.BatalButton.Text = "Batal"
        Me.BatalButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(755, 430)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 12
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'DataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.blue_abstract_composition
        Me.ClientSize = New System.Drawing.Size(1036, 464)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.BatalButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KeluarButton)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.TambahButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Query3DataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Query4DataGridView)
        Me.Name = "DataBarang"
        Me.Text = "BARANG"
        CType(Me.Query4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KELOMPOK_7DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_D_PjlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KELOMPOK_7DataSet As PROJECT_VB.KELOMPOK_7DataSet
    Friend WithEvents Query4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query4TableAdapter As PROJECT_VB.KELOMPOK_7DataSetTableAdapters.Query4TableAdapter
    Friend WithEvents TableAdapterManager As PROJECT_VB.KELOMPOK_7DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_D_PjlTableAdapter As PROJECT_VB.KELOMPOK_7DataSetTableAdapters.Tbl_D_PjlTableAdapter
    Friend WithEvents Query4DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tbl_D_PjlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents No_FakTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_barangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SatuanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JumlahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Query3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query3TableAdapter As PROJECT_VB.KELOMPOK_7DataSetTableAdapters.Query3TableAdapter
    Friend WithEvents Query3DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tbl_BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BarangTableAdapter As PROJECT_VB.KELOMPOK_7DataSetTableAdapters.Tbl_BarangTableAdapter
    Friend WithEvents _Kode_BarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_barangTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SatuanTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents HargaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents Hapus As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents KeluarButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BatalButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button

End Class
