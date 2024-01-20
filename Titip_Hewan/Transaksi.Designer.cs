namespace Titip_Hewan
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cbKolom = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbTransaksi = new System.Windows.Forms.GroupBox();
            this.cbIdLayanan = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbIdKandang = new System.Windows.Forms.ComboBox();
            this.cbIdHewan = new System.Windows.Forms.ComboBox();
            this.cbIdAnggota = new System.Windows.Forms.ComboBox();
            this.lblIdTransaksi = new System.Windows.Forms.Label();
            this.lblNamaHewan = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblNamaAnggota = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBiaya = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpKeluar = new System.Windows.Forms.DateTimePicker();
            this.dtpMasuk = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titip_hewanDataSet = new Titip_Hewan.titip_hewanDataSet();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new Titip_Hewan.titip_hewanDataSetTableAdapters.transaksiTableAdapter();
            this.tableAdapterManager = new Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(211, 397);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(100, 20);
            this.txtCari.TabIndex = 68;
            // 
            // cbKolom
            // 
            this.cbKolom.FormattingEnabled = true;
            this.cbKolom.Location = new System.Drawing.Point(84, 397);
            this.cbKolom.Name = "cbKolom";
            this.cbKolom.Size = new System.Drawing.Size(121, 21);
            this.cbKolom.TabIndex = 67;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(451, 394);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 66;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Pencarian";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(451, 222);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 63;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(172, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(10, 222);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 59;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbTransaksi
            // 
            this.gbTransaksi.Controls.Add(this.cbIdLayanan);
            this.gbTransaksi.Controls.Add(this.lblTotal);
            this.gbTransaksi.Controls.Add(this.cbIdKandang);
            this.gbTransaksi.Controls.Add(this.cbIdHewan);
            this.gbTransaksi.Controls.Add(this.cbIdAnggota);
            this.gbTransaksi.Controls.Add(this.lblIdTransaksi);
            this.gbTransaksi.Controls.Add(this.lblNamaHewan);
            this.gbTransaksi.Controls.Add(this.label30);
            this.gbTransaksi.Controls.Add(this.label31);
            this.gbTransaksi.Controls.Add(this.lblNamaAnggota);
            this.gbTransaksi.Controls.Add(this.label28);
            this.gbTransaksi.Controls.Add(this.label25);
            this.gbTransaksi.Controls.Add(this.label26);
            this.gbTransaksi.Controls.Add(this.label22);
            this.gbTransaksi.Controls.Add(this.label23);
            this.gbTransaksi.Controls.Add(this.label20);
            this.gbTransaksi.Controls.Add(this.label14);
            this.gbTransaksi.Controls.Add(this.label17);
            this.gbTransaksi.Controls.Add(this.label15);
            this.gbTransaksi.Controls.Add(this.label16);
            this.gbTransaksi.Controls.Add(this.lblBiaya);
            this.gbTransaksi.Controls.Add(this.label9);
            this.gbTransaksi.Controls.Add(this.label10);
            this.gbTransaksi.Controls.Add(this.dtpKeluar);
            this.gbTransaksi.Controls.Add(this.dtpMasuk);
            this.gbTransaksi.Controls.Add(this.label5);
            this.gbTransaksi.Controls.Add(this.label6);
            this.gbTransaksi.Controls.Add(this.label3);
            this.gbTransaksi.Controls.Add(this.label4);
            this.gbTransaksi.Controls.Add(this.label8);
            this.gbTransaksi.Controls.Add(this.label7);
            this.gbTransaksi.Controls.Add(this.label2);
            this.gbTransaksi.Controls.Add(this.label1);
            this.gbTransaksi.Location = new System.Drawing.Point(10, 12);
            this.gbTransaksi.Name = "gbTransaksi";
            this.gbTransaksi.Size = new System.Drawing.Size(516, 204);
            this.gbTransaksi.TabIndex = 58;
            this.gbTransaksi.TabStop = false;
            this.gbTransaksi.Text = "Data Transaksi";
            // 
            // cbIdLayanan
            // 
            this.cbIdLayanan.FormattingEnabled = true;
            this.cbIdLayanan.Location = new System.Drawing.Point(448, 67);
            this.cbIdLayanan.Name = "cbIdLayanan";
            this.cbIdLayanan.Size = new System.Drawing.Size(62, 21);
            this.cbIdLayanan.TabIndex = 100;
            this.cbIdLayanan.SelectedIndexChanged += new System.EventHandler(this.cbIdLayanan_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(128, 173);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "Rp. -,-";
            // 
            // cbIdKandang
            // 
            this.cbIdKandang.FormattingEnabled = true;
            this.cbIdKandang.Location = new System.Drawing.Point(448, 40);
            this.cbIdKandang.Name = "cbIdKandang";
            this.cbIdKandang.Size = new System.Drawing.Size(62, 21);
            this.cbIdKandang.TabIndex = 94;
            // 
            // cbIdHewan
            // 
            this.cbIdHewan.FormattingEnabled = true;
            this.cbIdHewan.Location = new System.Drawing.Point(284, 40);
            this.cbIdHewan.Name = "cbIdHewan";
            this.cbIdHewan.Size = new System.Drawing.Size(72, 21);
            this.cbIdHewan.TabIndex = 93;
            this.cbIdHewan.SelectedIndexChanged += new System.EventHandler(this.cbIdHewan_SelectedIndexChanged);
            // 
            // cbIdAnggota
            // 
            this.cbIdAnggota.FormattingEnabled = true;
            this.cbIdAnggota.Location = new System.Drawing.Point(106, 40);
            this.cbIdAnggota.Name = "cbIdAnggota";
            this.cbIdAnggota.Size = new System.Drawing.Size(78, 21);
            this.cbIdAnggota.TabIndex = 92;
            this.cbIdAnggota.SelectedIndexChanged += new System.EventHandler(this.cbIdAnggota_SelectedIndexChanged);
            // 
            // lblIdTransaksi
            // 
            this.lblIdTransaksi.AutoSize = true;
            this.lblIdTransaksi.Location = new System.Drawing.Point(128, 16);
            this.lblIdTransaksi.Name = "lblIdTransaksi";
            this.lblIdTransaksi.Size = new System.Drawing.Size(67, 13);
            this.lblIdTransaksi.TabIndex = 91;
            this.lblIdTransaksi.Text = "ID Transaksi";
            // 
            // lblNamaHewan
            // 
            this.lblNamaHewan.AutoSize = true;
            this.lblNamaHewan.Location = new System.Drawing.Point(284, 69);
            this.lblNamaHewan.Name = "lblNamaHewan";
            this.lblNamaHewan.Size = new System.Drawing.Size(72, 13);
            this.lblNamaHewan.TabIndex = 90;
            this.lblNamaHewan.Text = "Nama Hewan";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(268, 69);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(10, 13);
            this.label30.TabIndex = 89;
            this.label30.Text = ":";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(190, 69);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 13);
            this.label31.TabIndex = 88;
            this.label31.Text = "Nama Hewan";
            // 
            // lblNamaAnggota
            // 
            this.lblNamaAnggota.AutoSize = true;
            this.lblNamaAnggota.Location = new System.Drawing.Point(106, 69);
            this.lblNamaAnggota.Name = "lblNamaAnggota";
            this.lblNamaAnggota.Size = new System.Drawing.Size(78, 13);
            this.lblNamaAnggota.TabIndex = 87;
            this.lblNamaAnggota.Text = "Nama Anggota";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(90, 69);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(10, 13);
            this.label28.TabIndex = 86;
            this.label28.Text = ":";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(432, 69);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(10, 13);
            this.label25.TabIndex = 84;
            this.label25.Text = ":";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(362, 69);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 83;
            this.label26.Text = "ID Layanan";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(432, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 13);
            this.label22.TabIndex = 81;
            this.label22.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(362, 43);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 80;
            this.label23.Text = "ID Kandang";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 79;
            this.label20.Text = "Nama Anggota";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(268, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(190, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "ID Hewan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(90, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 71;
            this.label15.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "ID Anggota";
            // 
            // lblBiaya
            // 
            this.lblBiaya.AutoSize = true;
            this.lblBiaya.Location = new System.Drawing.Point(128, 147);
            this.lblBiaya.Name = "lblBiaya";
            this.lblBiaya.Size = new System.Drawing.Size(36, 13);
            this.lblBiaya.TabIndex = 69;
            this.lblBiaya.Text = "Rp. -,-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Total Biaya (Rp.)";
            // 
            // dtpKeluar
            // 
            this.dtpKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKeluar.Location = new System.Drawing.Point(128, 118);
            this.dtpKeluar.Name = "dtpKeluar";
            this.dtpKeluar.Size = new System.Drawing.Size(95, 20);
            this.dtpKeluar.TabIndex = 64;
            this.dtpKeluar.ValueChanged += new System.EventHandler(this.dtpKeluar_ValueChanged);
            // 
            // dtpMasuk
            // 
            this.dtpMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMasuk.Location = new System.Drawing.Point(128, 92);
            this.dtpMasuk.Name = "dtpMasuk";
            this.dtpMasuk.Size = new System.Drawing.Size(95, 20);
            this.dtpMasuk.TabIndex = 63;
            this.dtpMasuk.ValueChanged += new System.EventHandler(this.dtpMasuk_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Biaya Per Hari (Rp.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tanggal Keluar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal Masuk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Transaksi";
            // 
            // titip_hewanDataSet
            // 
            this.titip_hewanDataSet.DataSetName = "titip_hewanDataSet";
            this.titip_hewanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "transaksi";
            this.transaksiBindingSource.DataSource = this.titip_hewanDataSet;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hewanTableAdapter = null;
            this.tableAdapterManager.kandangTableAdapter = null;
            this.tableAdapterManager.layananTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = this.transaksiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AutoGenerateColumns = false;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvTransaksi.DataSource = this.transaksiBindingSource;
            this.dgvTransaksi.Location = new System.Drawing.Point(10, 251);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.Size = new System.Drawing.Size(516, 140);
            this.dgvTransaksi.TabIndex = 69;
            this.dgvTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaksi_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID Transaksi";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Transaksi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tanggal Masuk";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tanggal Masuk";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tanggal Keluar";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tanggal Keluar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total Biaya";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Biaya";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID Member";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID Member";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID Hewan";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID Hewan";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID Kandang";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID Kandang";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID Layanan";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID Layanan";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 424);
            this.Controls.Add(this.dgvTransaksi);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cbKolom);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gbTransaksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.gbTransaksi.ResumeLayout(false);
            this.gbTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cbKolom;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbTransaksi;
        private System.Windows.Forms.DateTimePicker dtpKeluar;
        private System.Windows.Forms.DateTimePicker dtpMasuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBiaya;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIdTransaksi;
        private System.Windows.Forms.Label lblNamaHewan;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblNamaAnggota;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private titip_hewanDataSet titip_hewanDataSet;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private titip_hewanDataSetTableAdapters.transaksiTableAdapter transaksiTableAdapter;
        private titip_hewanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox cbIdKandang;
        private System.Windows.Forms.ComboBox cbIdHewan;
        private System.Windows.Forms.ComboBox cbIdAnggota;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbIdLayanan;
    }
}