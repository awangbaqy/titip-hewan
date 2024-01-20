namespace Titip_Hewan
{
    partial class Hewan
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbHewan = new System.Windows.Forms.GroupBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.pJenis = new System.Windows.Forms.Panel();
            this.rbAnjing = new System.Windows.Forms.RadioButton();
            this.rbKucing = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.lblNamaAnggota = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbBetina = new System.Windows.Forms.RadioButton();
            this.rbJantan = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cbKolom = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHewanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaHewanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisHewanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexHewanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umurHewanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titip_hewanDataSet = new Titip_Hewan.titip_hewanDataSet();
            this.hewanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hewanTableAdapter = new Titip_Hewan.titip_hewanDataSetTableAdapters.hewanTableAdapter();
            this.tableAdapterManager = new Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager();
            this.dgvHewan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbHewan.SuspendLayout();
            this.pJenis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hewanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHewan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(584, 203);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbHewan
            // 
            this.gbHewan.Controls.Add(this.cbID);
            this.gbHewan.Controls.Add(this.pJenis);
            this.gbHewan.Controls.Add(this.label15);
            this.gbHewan.Controls.Add(this.label16);
            this.gbHewan.Controls.Add(this.txtNama);
            this.gbHewan.Controls.Add(this.lblID);
            this.gbHewan.Controls.Add(this.txtUmur);
            this.gbHewan.Controls.Add(this.lblNamaAnggota);
            this.gbHewan.Controls.Add(this.label13);
            this.gbHewan.Controls.Add(this.label14);
            this.gbHewan.Controls.Add(this.label10);
            this.gbHewan.Controls.Add(this.label9);
            this.gbHewan.Controls.Add(this.label8);
            this.gbHewan.Controls.Add(this.label7);
            this.gbHewan.Controls.Add(this.label6);
            this.gbHewan.Controls.Add(this.rbBetina);
            this.gbHewan.Controls.Add(this.rbJantan);
            this.gbHewan.Controls.Add(this.label5);
            this.gbHewan.Controls.Add(this.label4);
            this.gbHewan.Controls.Add(this.label3);
            this.gbHewan.Controls.Add(this.label2);
            this.gbHewan.Controls.Add(this.label1);
            this.gbHewan.Location = new System.Drawing.Point(12, 12);
            this.gbHewan.Name = "gbHewan";
            this.gbHewan.Size = new System.Drawing.Size(647, 185);
            this.gbHewan.TabIndex = 22;
            this.gbHewan.TabStop = false;
            this.gbHewan.Text = "Data Hewan";
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(136, 21);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(97, 21);
            this.cbID.TabIndex = 46;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // pJenis
            // 
            this.pJenis.Controls.Add(this.rbAnjing);
            this.pJenis.Controls.Add(this.rbKucing);
            this.pJenis.Location = new System.Drawing.Point(131, 100);
            this.pJenis.Name = "pJenis";
            this.pJenis.Size = new System.Drawing.Size(123, 29);
            this.pJenis.TabIndex = 44;
            // 
            // rbAnjing
            // 
            this.rbAnjing.AutoSize = true;
            this.rbAnjing.Checked = true;
            this.rbAnjing.Location = new System.Drawing.Point(5, 1);
            this.rbAnjing.Name = "rbAnjing";
            this.rbAnjing.Size = new System.Drawing.Size(54, 17);
            this.rbAnjing.TabIndex = 42;
            this.rbAnjing.TabStop = true;
            this.rbAnjing.Text = "Anjing";
            this.rbAnjing.UseVisualStyleBackColor = true;
            // 
            // rbKucing
            // 
            this.rbKucing.AutoSize = true;
            this.rbKucing.Location = new System.Drawing.Point(68, 1);
            this.rbKucing.Name = "rbKucing";
            this.rbKucing.Size = new System.Drawing.Size(58, 17);
            this.rbKucing.TabIndex = 43;
            this.rbKucing.Text = "Kucing";
            this.rbKucing.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Nama Hewan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(136, 74);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(121, 20);
            this.txtNama.TabIndex = 39;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(136, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(55, 13);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID Hewan";
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(136, 152);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(100, 20);
            this.txtUmur.TabIndex = 36;
            // 
            // lblNamaAnggota
            // 
            this.lblNamaAnggota.AutoSize = true;
            this.lblNamaAnggota.Location = new System.Drawing.Point(363, 24);
            this.lblNamaAnggota.Name = "lblNamaAnggota";
            this.lblNamaAnggota.Size = new System.Drawing.Size(78, 13);
            this.lblNamaAnggota.TabIndex = 35;
            this.lblNamaAnggota.Text = "Nama Anggota";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Nama Anggota";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // rbBetina
            // 
            this.rbBetina.AutoSize = true;
            this.rbBetina.Location = new System.Drawing.Point(199, 129);
            this.rbBetina.Name = "rbBetina";
            this.rbBetina.Size = new System.Drawing.Size(55, 17);
            this.rbBetina.TabIndex = 11;
            this.rbBetina.Text = "Betina";
            this.rbBetina.UseVisualStyleBackColor = true;
            // 
            // rbJantan
            // 
            this.rbJantan.AutoSize = true;
            this.rbJantan.Checked = true;
            this.rbJantan.Location = new System.Drawing.Point(136, 129);
            this.rbJantan.Name = "rbJantan";
            this.rbJantan.Size = new System.Drawing.Size(57, 17);
            this.rbJantan.TabIndex = 10;
            this.rbJantan.TabStop = true;
            this.rbJantan.Text = "Jantan";
            this.rbJantan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Umur Hewan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jenis Kelamin Hewan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jenis Hewan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Hewan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Anggota";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 203);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(220, 404);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(149, 20);
            this.txtCari.TabIndex = 28;
            // 
            // cbKolom
            // 
            this.cbKolom.FormattingEnabled = true;
            this.cbKolom.Location = new System.Drawing.Point(93, 404);
            this.cbKolom.Name = "cbKolom";
            this.cbKolom.Size = new System.Drawing.Size(121, 21);
            this.cbKolom.TabIndex = 31;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(584, 401);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 30;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Pencarian";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID Hewan";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Hewan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nama Hewan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nama Hewan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Jenis Hewan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Jenis Hewan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sex Hewan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sex Hewan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Umur Hewan";
            this.dataGridViewTextBoxColumn6.HeaderText = "Umur Hewan";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // iDHewanDataGridViewTextBoxColumn
            // 
            this.iDHewanDataGridViewTextBoxColumn.DataPropertyName = "ID Hewan";
            this.iDHewanDataGridViewTextBoxColumn.HeaderText = "ID Hewan";
            this.iDHewanDataGridViewTextBoxColumn.Name = "iDHewanDataGridViewTextBoxColumn";
            this.iDHewanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaHewanDataGridViewTextBoxColumn
            // 
            this.namaHewanDataGridViewTextBoxColumn.DataPropertyName = "Nama Hewan";
            this.namaHewanDataGridViewTextBoxColumn.HeaderText = "Nama Hewan";
            this.namaHewanDataGridViewTextBoxColumn.Name = "namaHewanDataGridViewTextBoxColumn";
            // 
            // jenisHewanDataGridViewTextBoxColumn
            // 
            this.jenisHewanDataGridViewTextBoxColumn.DataPropertyName = "Jenis Hewan";
            this.jenisHewanDataGridViewTextBoxColumn.HeaderText = "Jenis Hewan";
            this.jenisHewanDataGridViewTextBoxColumn.Name = "jenisHewanDataGridViewTextBoxColumn";
            // 
            // sexHewanDataGridViewTextBoxColumn
            // 
            this.sexHewanDataGridViewTextBoxColumn.DataPropertyName = "Sex Hewan";
            this.sexHewanDataGridViewTextBoxColumn.HeaderText = "Sex Hewan";
            this.sexHewanDataGridViewTextBoxColumn.Name = "sexHewanDataGridViewTextBoxColumn";
            // 
            // umurHewanDataGridViewTextBoxColumn
            // 
            this.umurHewanDataGridViewTextBoxColumn.DataPropertyName = "Umur Hewan";
            this.umurHewanDataGridViewTextBoxColumn.HeaderText = "Umur Hewan";
            this.umurHewanDataGridViewTextBoxColumn.Name = "umurHewanDataGridViewTextBoxColumn";
            // 
            // titip_hewanDataSet
            // 
            this.titip_hewanDataSet.DataSetName = "titip_hewanDataSet";
            this.titip_hewanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hewanBindingSource
            // 
            this.hewanBindingSource.DataMember = "hewan";
            this.hewanBindingSource.DataSource = this.titip_hewanDataSet;
            // 
            // hewanTableAdapter
            // 
            this.hewanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hewanTableAdapter = this.hewanTableAdapter;
            this.tableAdapterManager.kandangTableAdapter = null;
            this.tableAdapterManager.layananTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvHewan
            // 
            this.dgvHewan.AutoGenerateColumns = false;
            this.dgvHewan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHewan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvHewan.DataSource = this.hewanBindingSource;
            this.dgvHewan.Location = new System.Drawing.Point(12, 232);
            this.dgvHewan.Name = "dgvHewan";
            this.dgvHewan.Size = new System.Drawing.Size(647, 163);
            this.dgvHewan.TabIndex = 32;
            this.dgvHewan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHewan_CellClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID Hewan";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID Hewan";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nama Hewan";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nama Hewan";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Jenis Hewan";
            this.dataGridViewTextBoxColumn9.HeaderText = "Jenis Hewan";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Sex Hewan";
            this.dataGridViewTextBoxColumn10.HeaderText = "Sex Hewan";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Umur Hewan";
            this.dataGridViewTextBoxColumn11.HeaderText = "Umur Hewan";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ID Member";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID Member";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Hewan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 429);
            this.Controls.Add(this.dgvHewan);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cbKolom);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbHewan);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hewan";
            this.Text = "Hewan";
            this.Load += new System.EventHandler(this.Hewan_Load);
            this.gbHewan.ResumeLayout(false);
            this.gbHewan.PerformLayout();
            this.pJenis.ResumeLayout(false);
            this.pJenis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hewanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHewan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbHewan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbBetina;
        private System.Windows.Forms.RadioButton rbJantan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.Label lblNamaAnggota;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cbKolom;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rbKucing;
        private System.Windows.Forms.RadioButton rbAnjing;
        private System.Windows.Forms.Panel pJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHewanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaHewanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisHewanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexHewanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umurHewanDataGridViewTextBoxColumn;
        private titip_hewanDataSet titip_hewanDataSet;
        private System.Windows.Forms.BindingSource hewanBindingSource;
        private titip_hewanDataSetTableAdapters.hewanTableAdapter hewanTableAdapter;
        private titip_hewanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvHewan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ComboBox cbID;
    }
}