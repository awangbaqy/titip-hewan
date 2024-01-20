namespace Titip_Hewan
{
    partial class Kandang
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
            this.cbKolom = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbKandang = new System.Windows.Forms.GroupBox();
            this.pStatus = new System.Windows.Forms.Panel();
            this.rbKosong = new System.Windows.Forms.RadioButton();
            this.rbTerisi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDKandang = new System.Windows.Forms.TextBox();
            this.rbAnjing = new System.Windows.Forms.RadioButton();
            this.rbKucing = new System.Windows.Forms.RadioButton();
            this.lblIDKandang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.titip_hewanDataSet = new Titip_Hewan.titip_hewanDataSet();
            this.kandangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kandangTableAdapter = new Titip_Hewan.titip_hewanDataSetTableAdapters.kandangTableAdapter();
            this.tableAdapterManager = new Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager();
            this.dgvKandang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKandang.SuspendLayout();
            this.pStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKolom
            // 
            this.cbKolom.FormattingEnabled = true;
            this.cbKolom.Location = new System.Drawing.Point(93, 331);
            this.cbKolom.Name = "cbKolom";
            this.cbKolom.Size = new System.Drawing.Size(121, 21);
            this.cbKolom.TabIndex = 43;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(336, 328);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 42;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Pencarian";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(336, 120);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbKandang
            // 
            this.gbKandang.Controls.Add(this.pStatus);
            this.gbKandang.Controls.Add(this.label3);
            this.gbKandang.Controls.Add(this.label4);
            this.gbKandang.Controls.Add(this.txtIDKandang);
            this.gbKandang.Controls.Add(this.rbAnjing);
            this.gbKandang.Controls.Add(this.rbKucing);
            this.gbKandang.Controls.Add(this.lblIDKandang);
            this.gbKandang.Controls.Add(this.label8);
            this.gbKandang.Controls.Add(this.label7);
            this.gbKandang.Controls.Add(this.label2);
            this.gbKandang.Controls.Add(this.label1);
            this.gbKandang.Location = new System.Drawing.Point(12, 12);
            this.gbKandang.Name = "gbKandang";
            this.gbKandang.Size = new System.Drawing.Size(399, 102);
            this.gbKandang.TabIndex = 34;
            this.gbKandang.TabStop = false;
            this.gbKandang.Text = "Data Kandang";
            // 
            // pStatus
            // 
            this.pStatus.Controls.Add(this.rbKosong);
            this.pStatus.Controls.Add(this.rbTerisi);
            this.pStatus.Location = new System.Drawing.Point(111, 70);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(123, 26);
            this.pStatus.TabIndex = 51;
            // 
            // rbKosong
            // 
            this.rbKosong.AutoSize = true;
            this.rbKosong.Checked = true;
            this.rbKosong.Location = new System.Drawing.Point(5, 2);
            this.rbKosong.Name = "rbKosong";
            this.rbKosong.Size = new System.Drawing.Size(61, 17);
            this.rbKosong.TabIndex = 50;
            this.rbKosong.TabStop = true;
            this.rbKosong.Text = "Kosong";
            this.rbKosong.UseVisualStyleBackColor = true;
            // 
            // rbTerisi
            // 
            this.rbTerisi.AutoSize = true;
            this.rbTerisi.Location = new System.Drawing.Point(72, 2);
            this.rbTerisi.Name = "rbTerisi";
            this.rbTerisi.Size = new System.Drawing.Size(50, 17);
            this.rbTerisi.TabIndex = 49;
            this.rbTerisi.Text = "Terisi";
            this.rbTerisi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Status";
            // 
            // txtIDKandang
            // 
            this.txtIDKandang.Location = new System.Drawing.Point(186, 21);
            this.txtIDKandang.Name = "txtIDKandang";
            this.txtIDKandang.Size = new System.Drawing.Size(35, 20);
            this.txtIDKandang.TabIndex = 46;
            this.txtIDKandang.Visible = false;
            // 
            // rbAnjing
            // 
            this.rbAnjing.AutoSize = true;
            this.rbAnjing.Checked = true;
            this.rbAnjing.Location = new System.Drawing.Point(116, 49);
            this.rbAnjing.Name = "rbAnjing";
            this.rbAnjing.Size = new System.Drawing.Size(54, 17);
            this.rbAnjing.TabIndex = 42;
            this.rbAnjing.TabStop = true;
            this.rbAnjing.Text = "Anjing";
            this.rbAnjing.UseVisualStyleBackColor = true;
            this.rbAnjing.Click += new System.EventHandler(this.rbAnjing_Click);
            // 
            // rbKucing
            // 
            this.rbKucing.AutoSize = true;
            this.rbKucing.Location = new System.Drawing.Point(176, 49);
            this.rbKucing.Name = "rbKucing";
            this.rbKucing.Size = new System.Drawing.Size(58, 17);
            this.rbKucing.TabIndex = 41;
            this.rbKucing.Text = "Kucing";
            this.rbKucing.UseVisualStyleBackColor = true;
            this.rbKucing.Click += new System.EventHandler(this.rbKucing_Click);
            // 
            // lblIDKandang
            // 
            this.lblIDKandang.AutoSize = true;
            this.lblIDKandang.Location = new System.Drawing.Point(116, 24);
            this.lblIDKandang.Name = "lblIDKandang";
            this.lblIDKandang.Size = new System.Drawing.Size(64, 13);
            this.lblIDKandang.TabIndex = 39;
            this.lblIDKandang.Text = "ID Kandang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 51);
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
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jenis Kandang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Kandang";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 120);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 32;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(220, 331);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(100, 20);
            this.txtCari.TabIndex = 45;
            // 
            // titip_hewanDataSet
            // 
            this.titip_hewanDataSet.DataSetName = "titip_hewanDataSet";
            this.titip_hewanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kandangBindingSource
            // 
            this.kandangBindingSource.DataMember = "kandang";
            this.kandangBindingSource.DataSource = this.titip_hewanDataSet;
            // 
            // kandangTableAdapter
            // 
            this.kandangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hewanTableAdapter = null;
            this.tableAdapterManager.kandangTableAdapter = this.kandangTableAdapter;
            this.tableAdapterManager.layananTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvKandang
            // 
            this.dgvKandang.AutoGenerateColumns = false;
            this.dgvKandang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKandang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvKandang.DataSource = this.kandangBindingSource;
            this.dgvKandang.Location = new System.Drawing.Point(12, 149);
            this.dgvKandang.Name = "dgvKandang";
            this.dgvKandang.Size = new System.Drawing.Size(399, 176);
            this.dgvKandang.TabIndex = 46;
            this.dgvKandang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKandang_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID Kandang";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Kandang";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Jenis Kandang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Jenis Kandang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Kandang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 355);
            this.Controls.Add(this.dgvKandang);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cbKolom);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbKandang);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kandang";
            this.Text = "Kandang";
            this.Load += new System.EventHandler(this.Kandang_Load);
            this.gbKandang.ResumeLayout(false);
            this.gbKandang.PerformLayout();
            this.pStatus.ResumeLayout(false);
            this.pStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbKolom;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbKandang;
        private System.Windows.Forms.Label lblIDKandang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RadioButton rbAnjing;
        private System.Windows.Forms.RadioButton rbKucing;
        private System.Windows.Forms.TextBox txtIDKandang;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.RadioButton rbKosong;
        private System.Windows.Forms.RadioButton rbTerisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pStatus;
        private titip_hewanDataSet titip_hewanDataSet;
        private System.Windows.Forms.BindingSource kandangBindingSource;
        private titip_hewanDataSetTableAdapters.kandangTableAdapter kandangTableAdapter;
        private titip_hewanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvKandang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}