namespace Titip_Hewan
{
    partial class Anggota
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
            this.txt_HP = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_P = new System.Windows.Forms.RadioButton();
            this.rb_L = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Alamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Cari = new System.Windows.Forms.Button();
            this.cb_Kolom = new System.Windows.Forms.ComboBox();
            this.txt_Cari = new System.Windows.Forms.TextBox();
            this.gb_Anggota = new System.Windows.Forms.GroupBox();
            this.titip_hewanDataSet = new Titip_Hewan.titip_hewanDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new Titip_Hewan.titip_hewanDataSetTableAdapters.memberTableAdapter();
            this.tableAdapterManager = new Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Anggota = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Anggota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Anggota)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_HP
            // 
            this.txt_HP.Location = new System.Drawing.Point(125, 73);
            this.txt_HP.Mask = "+62 000-0000-0000";
            this.txt_HP.Name = "txt_HP";
            this.txt_HP.Size = new System.Drawing.Size(109, 20);
            this.txt_HP.TabIndex = 18;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(125, 24);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(61, 13);
            this.lbl_Id.TabIndex = 17;
            this.lbl_Id.Text = "ID Anggota";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // rb_P
            // 
            this.rb_P.AutoSize = true;
            this.rb_P.Location = new System.Drawing.Point(195, 128);
            this.rb_P.Name = "rb_P";
            this.rb_P.Size = new System.Drawing.Size(79, 17);
            this.rb_P.TabIndex = 11;
            this.rb_P.Text = "Perempuan";
            this.rb_P.UseVisualStyleBackColor = true;
            // 
            // rb_L
            // 
            this.rb_L.AutoSize = true;
            this.rb_L.Checked = true;
            this.rb_L.Location = new System.Drawing.Point(125, 128);
            this.rb_L.Name = "rb_L";
            this.rb_L.Size = new System.Drawing.Size(64, 17);
            this.rb_L.TabIndex = 10;
            this.rb_L.TabStop = true;
            this.rb_L.Text = "Laki-laki";
            this.rb_L.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alamat Anggota";
            // 
            // txt_Alamat
            // 
            this.txt_Alamat.Location = new System.Drawing.Point(125, 99);
            this.txt_Alamat.Name = "txt_Alamat";
            this.txt_Alamat.Size = new System.Drawing.Size(418, 20);
            this.txt_Alamat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alamat Anggota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nomor Handphone";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Location = new System.Drawing.Point(125, 47);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(193, 20);
            this.txt_Nama.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Anggota";
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
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(12, 175);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(93, 175);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(174, 175);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(255, 175);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(486, 175);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Pencarian";
            // 
            // btn_Cari
            // 
            this.btn_Cari.Location = new System.Drawing.Point(486, 359);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.Size = new System.Drawing.Size(75, 23);
            this.btn_Cari.TabIndex = 19;
            this.btn_Cari.Text = "Cari";
            this.btn_Cari.UseVisualStyleBackColor = true;
            this.btn_Cari.Click += new System.EventHandler(this.btn_Cari_Click);
            // 
            // cb_Kolom
            // 
            this.cb_Kolom.FormattingEnabled = true;
            this.cb_Kolom.Location = new System.Drawing.Point(95, 362);
            this.cb_Kolom.Name = "cb_Kolom";
            this.cb_Kolom.Size = new System.Drawing.Size(121, 21);
            this.cb_Kolom.TabIndex = 20;
            // 
            // txt_Cari
            // 
            this.txt_Cari.Location = new System.Drawing.Point(222, 362);
            this.txt_Cari.Name = "txt_Cari";
            this.txt_Cari.Size = new System.Drawing.Size(150, 20);
            this.txt_Cari.TabIndex = 18;
            // 
            // gb_Anggota
            // 
            this.gb_Anggota.Controls.Add(this.txt_HP);
            this.gb_Anggota.Controls.Add(this.lbl_Id);
            this.gb_Anggota.Controls.Add(this.label10);
            this.gb_Anggota.Controls.Add(this.label9);
            this.gb_Anggota.Controls.Add(this.label8);
            this.gb_Anggota.Controls.Add(this.label7);
            this.gb_Anggota.Controls.Add(this.label6);
            this.gb_Anggota.Controls.Add(this.rb_P);
            this.gb_Anggota.Controls.Add(this.rb_L);
            this.gb_Anggota.Controls.Add(this.label5);
            this.gb_Anggota.Controls.Add(this.txt_Alamat);
            this.gb_Anggota.Controls.Add(this.label4);
            this.gb_Anggota.Controls.Add(this.label3);
            this.gb_Anggota.Controls.Add(this.txt_Nama);
            this.gb_Anggota.Controls.Add(this.label2);
            this.gb_Anggota.Controls.Add(this.label1);
            this.gb_Anggota.Location = new System.Drawing.Point(12, 12);
            this.gb_Anggota.Name = "gb_Anggota";
            this.gb_Anggota.Size = new System.Drawing.Size(549, 157);
            this.gb_Anggota.TabIndex = 2;
            this.gb_Anggota.TabStop = false;
            this.gb_Anggota.Text = "Data Anggota";
            // 
            // titip_hewanDataSet
            // 
            this.titip_hewanDataSet.DataSetName = "titip_hewanDataSet";
            this.titip_hewanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.titip_hewanDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hewanTableAdapter = null;
            this.tableAdapterManager.kandangTableAdapter = null;
            this.tableAdapterManager.layananTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.transaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Titip_Hewan.titip_hewanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID Member";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Member";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nama Member";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nama Member";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dgv_Anggota
            // 
            this.dgv_Anggota.AutoGenerateColumns = false;
            this.dgv_Anggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Anggota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgv_Anggota.DataSource = this.memberBindingSource;
            this.dgv_Anggota.Location = new System.Drawing.Point(12, 204);
            this.dgv_Anggota.Name = "dgv_Anggota";
            this.dgv_Anggota.Size = new System.Drawing.Size(549, 152);
            this.dgv_Anggota.TabIndex = 20;
            this.dgv_Anggota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Anggota_CellClick_1);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID Member";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID Member";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nama Member";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nama Member";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "No. HP";
            this.dataGridViewTextBoxColumn8.HeaderText = "No. HP";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Alamat Member";
            this.dataGridViewTextBoxColumn9.HeaderText = "Alamat Member";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Sex Member";
            this.dataGridViewTextBoxColumn10.HeaderText = "Sex Member";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Anggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 389);
            this.Controls.Add(this.dgv_Anggota);
            this.Controls.Add(this.txt_Cari);
            this.Controls.Add(this.cb_Kolom);
            this.Controls.Add(this.btn_Cari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Anggota);
            this.Controls.Add(this.btn_New);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Anggota";
            this.Text = "Anggota";
            this.Load += new System.EventHandler(this.Anggota_Load);
            this.gb_Anggota.ResumeLayout(false);
            this.gb_Anggota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titip_hewanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Anggota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Alamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_P;
        private System.Windows.Forms.RadioButton rb_L;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Cari;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.ComboBox cb_Kolom;
        private System.Windows.Forms.TextBox txt_Cari;
        private System.Windows.Forms.MaskedTextBox txt_HP;
        private System.Windows.Forms.GroupBox gb_Anggota;
        private System.Windows.Forms.BindingNavigator memberBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton memberBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private titip_hewanDataSet titip_hewanDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private titip_hewanDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private titip_hewanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgv_Anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}