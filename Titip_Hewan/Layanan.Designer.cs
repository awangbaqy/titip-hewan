namespace Titip_Hewan
{
    partial class Layanan
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
            this.gbLayanan = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBiaya = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLayanan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbYaRawat = new System.Windows.Forms.RadioButton();
            this.rbTidakRawat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pStatus = new System.Windows.Forms.Panel();
            this.rbYaMM = new System.Windows.Forms.RadioButton();
            this.rbTidakMM = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIDLayanan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.titip_hewanDataSet = new Titip_Hewan.titip_hewanDataSet();
            this.layananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layananTableAdapter = new Titip_Hewan.titip_hewanDataSetTableAdapters.layananTableAdapter();
            this.tableAdapterManager = new Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager();
            this.dgvLayanan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLayanan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayanan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLayanan
            // 
            this.gbLayanan.Controls.Add(this.label10);
            this.gbLayanan.Controls.Add(this.txtBiaya);
            this.gbLayanan.Controls.Add(this.lblHarga);
            this.gbLayanan.Controls.Add(this.label9);
            this.gbLayanan.Controls.Add(this.txtLayanan);
            this.gbLayanan.Controls.Add(this.panel1);
            this.gbLayanan.Controls.Add(this.label5);
            this.gbLayanan.Controls.Add(this.label6);
            this.gbLayanan.Controls.Add(this.pStatus);
            this.gbLayanan.Controls.Add(this.label3);
            this.gbLayanan.Controls.Add(this.label4);
            this.gbLayanan.Controls.Add(this.lblIDLayanan);
            this.gbLayanan.Controls.Add(this.label8);
            this.gbLayanan.Controls.Add(this.label7);
            this.gbLayanan.Controls.Add(this.label2);
            this.gbLayanan.Controls.Add(this.label1);
            this.gbLayanan.Location = new System.Drawing.Point(12, 12);
            this.gbLayanan.Name = "gbLayanan";
            this.gbLayanan.Size = new System.Drawing.Size(549, 169);
            this.gbLayanan.TabIndex = 35;
            this.gbLayanan.TabStop = false;
            this.gbLayanan.Text = "Data Layanan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Rp. ";
            // 
            // txtBiaya
            // 
            this.txtBiaya.Location = new System.Drawing.Point(35, 149);
            this.txtBiaya.Name = "txtBiaya";
            this.txtBiaya.Size = new System.Drawing.Size(66, 20);
            this.txtBiaya.TabIndex = 61;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(232, 82);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(72, 13);
            this.lblHarga.TabIndex = 60;
            this.lblHarga.Text = "Rp. 250.000,-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "(Biaya Tambahan)";
            // 
            // txtLayanan
            // 
            this.txtLayanan.Location = new System.Drawing.Point(123, 106);
            this.txtLayanan.Multiline = true;
            this.txtLayanan.Name = "txtLayanan";
            this.txtLayanan.Size = new System.Drawing.Size(420, 57);
            this.txtLayanan.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbYaRawat);
            this.panel1.Controls.Add(this.rbTidakRawat);
            this.panel1.Location = new System.Drawing.Point(123, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 21);
            this.panel1.TabIndex = 52;
            // 
            // rbYaRawat
            // 
            this.rbYaRawat.AutoSize = true;
            this.rbYaRawat.Checked = true;
            this.rbYaRawat.Location = new System.Drawing.Point(5, 2);
            this.rbYaRawat.Name = "rbYaRawat";
            this.rbYaRawat.Size = new System.Drawing.Size(38, 17);
            this.rbYaRawat.TabIndex = 50;
            this.rbYaRawat.TabStop = true;
            this.rbYaRawat.Text = "Ya";
            this.rbYaRawat.UseVisualStyleBackColor = true;
            this.rbYaRawat.Click += new System.EventHandler(this.rbYaRawat_Click);
            // 
            // rbTidakRawat
            // 
            this.rbTidakRawat.AutoSize = true;
            this.rbTidakRawat.Location = new System.Drawing.Point(49, 2);
            this.rbTidakRawat.Name = "rbTidakRawat";
            this.rbTidakRawat.Size = new System.Drawing.Size(52, 17);
            this.rbTidakRawat.TabIndex = 49;
            this.rbTidakRawat.Text = "Tidak";
            this.rbTidakRawat.UseVisualStyleBackColor = true;
            this.rbTidakRawat.Click += new System.EventHandler(this.rbTidakRawat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Lainnya";
            // 
            // pStatus
            // 
            this.pStatus.Controls.Add(this.rbYaMM);
            this.pStatus.Controls.Add(this.rbTidakMM);
            this.pStatus.Location = new System.Drawing.Point(123, 51);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(103, 21);
            this.pStatus.TabIndex = 51;
            // 
            // rbYaMM
            // 
            this.rbYaMM.AutoSize = true;
            this.rbYaMM.Checked = true;
            this.rbYaMM.Location = new System.Drawing.Point(5, 2);
            this.rbYaMM.Name = "rbYaMM";
            this.rbYaMM.Size = new System.Drawing.Size(38, 17);
            this.rbYaMM.TabIndex = 50;
            this.rbYaMM.TabStop = true;
            this.rbYaMM.Text = "Ya";
            this.rbYaMM.UseVisualStyleBackColor = true;
            // 
            // rbTidakMM
            // 
            this.rbTidakMM.AutoSize = true;
            this.rbTidakMM.Location = new System.Drawing.Point(49, 2);
            this.rbTidakMM.Name = "rbTidakMM";
            this.rbTidakMM.Size = new System.Drawing.Size(52, 17);
            this.rbTidakMM.TabIndex = 49;
            this.rbTidakMM.Text = "Tidak";
            this.rbTidakMM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Perawatan";
            // 
            // lblIDLayanan
            // 
            this.lblIDLayanan.AutoSize = true;
            this.lblIDLayanan.Location = new System.Drawing.Point(120, 24);
            this.lblIDLayanan.Name = "lblIDLayanan";
            this.lblIDLayanan.Size = new System.Drawing.Size(62, 13);
            this.lblIDLayanan.TabIndex = 39;
            this.lblIDLayanan.Text = "ID Layanan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Makan dan Minum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Layanan";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(213, 362);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(100, 20);
            this.txtCari.TabIndex = 56;
            // 
            // cbKolom
            // 
            this.cbKolom.FormattingEnabled = true;
            this.cbKolom.Location = new System.Drawing.Point(86, 362);
            this.cbKolom.Name = "cbKolom";
            this.cbKolom.Size = new System.Drawing.Size(121, 21);
            this.cbKolom.TabIndex = 54;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(486, 360);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 53;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Pencarian";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(486, 187);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 187);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 46;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // titip_hewanDataSet
            // 
            this.titip_hewanDataSet.DataSetName = "titip_hewanDataSet";
            this.titip_hewanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layananBindingSource
            // 
            this.layananBindingSource.DataMember = "layanan";
            this.layananBindingSource.DataSource = this.titip_hewanDataSet;
            // 
            // layananTableAdapter
            // 
            this.layananTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hewanTableAdapter = null;
            this.tableAdapterManager.kandangTableAdapter = null;
            this.tableAdapterManager.layananTableAdapter = this.layananTableAdapter;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvLayanan
            // 
            this.dgvLayanan.AutoGenerateColumns = false;
            this.dgvLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvLayanan.DataSource = this.layananBindingSource;
            this.dgvLayanan.Location = new System.Drawing.Point(12, 216);
            this.dgvLayanan.Name = "dgvLayanan";
            this.dgvLayanan.Size = new System.Drawing.Size(549, 140);
            this.dgvLayanan.TabIndex = 57;
            this.dgvLayanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLayanan_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID Layanan";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Layanan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Makan & Minum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Makan & Minum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Perawatan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Perawatan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lainnya";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lainnya";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Biaya Per Hari";
            this.dataGridViewTextBoxColumn5.HeaderText = "Biaya Per Hari";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Layanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 392);
            this.Controls.Add(this.dgvLayanan);
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
            this.Controls.Add(this.gbLayanan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Layanan";
            this.Text = "Layanan";
            this.Load += new System.EventHandler(this.Layanan_Load);
            this.gbLayanan.ResumeLayout(false);
            this.gbLayanan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pStatus.ResumeLayout(false);
            this.pStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLayanan;
        private System.Windows.Forms.Panel pStatus;
        private System.Windows.Forms.RadioButton rbYaMM;
        private System.Windows.Forms.RadioButton rbTidakMM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIDLayanan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtLayanan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbYaRawat;
        private System.Windows.Forms.RadioButton rbTidakRawat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private titip_hewanDataSet titip_hewanDataSet;
        private System.Windows.Forms.BindingSource layananBindingSource;
        private titip_hewanDataSetTableAdapters.layananTableAdapter layananTableAdapter;
        private titip_hewanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvLayanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBiaya;
    }
}