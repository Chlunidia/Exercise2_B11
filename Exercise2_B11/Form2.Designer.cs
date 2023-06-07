namespace Exercise2_B11
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pendaftaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daftar_bimbel_baruDataSet = new Exercise2_B11.daftar_bimbel_baruDataSet();
            this.pendaftaranTableAdapter = new Exercise2_B11.daftar_bimbel_baruDataSetTableAdapters.pendaftaranTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.idpendaftaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalpendaftaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftar_bimbel_baruDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpendaftaranDataGridViewTextBoxColumn,
            this.idsiswaDataGridViewTextBoxColumn,
            this.idkelasDataGridViewTextBoxColumn,
            this.tanggalpendaftaranDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pendaftaranBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(31, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pendaftaranBindingSource
            // 
            this.pendaftaranBindingSource.DataMember = "pendaftaran";
            this.pendaftaranBindingSource.DataSource = this.daftar_bimbel_baruDataSet;
            // 
            // daftar_bimbel_baruDataSet
            // 
            this.daftar_bimbel_baruDataSet.DataSetName = "daftar_bimbel_baruDataSet";
            this.daftar_bimbel_baruDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pendaftaranTableAdapter
            // 
            this.pendaftaranTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(389, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Grid Pendaftaran";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(483, 613);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idpendaftaranDataGridViewTextBoxColumn
            // 
            this.idpendaftaranDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idpendaftaranDataGridViewTextBoxColumn.DataPropertyName = "id_pendaftaran";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.idpendaftaranDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idpendaftaranDataGridViewTextBoxColumn.HeaderText = "ID Pendaftaran";
            this.idpendaftaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idpendaftaranDataGridViewTextBoxColumn.Name = "idpendaftaranDataGridViewTextBoxColumn";
            this.idpendaftaranDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpendaftaranDataGridViewTextBoxColumn.Width = 154;
            // 
            // idsiswaDataGridViewTextBoxColumn
            // 
            this.idsiswaDataGridViewTextBoxColumn.DataPropertyName = "id_siswa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.idsiswaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idsiswaDataGridViewTextBoxColumn.HeaderText = "ID Siswa";
            this.idsiswaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idsiswaDataGridViewTextBoxColumn.Name = "idsiswaDataGridViewTextBoxColumn";
            this.idsiswaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsiswaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idkelasDataGridViewTextBoxColumn
            // 
            this.idkelasDataGridViewTextBoxColumn.DataPropertyName = "id_kelas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.idkelasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idkelasDataGridViewTextBoxColumn.HeaderText = "ID Kelas";
            this.idkelasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idkelasDataGridViewTextBoxColumn.Name = "idkelasDataGridViewTextBoxColumn";
            this.idkelasDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkelasDataGridViewTextBoxColumn.Width = 150;
            // 
            // tanggalpendaftaranDataGridViewTextBoxColumn
            // 
            this.tanggalpendaftaranDataGridViewTextBoxColumn.DataPropertyName = "tanggal_pendaftaran";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tanggalpendaftaranDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tanggalpendaftaranDataGridViewTextBoxColumn.HeaderText = "Tanggal Pendaftaran";
            this.tanggalpendaftaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalpendaftaranDataGridViewTextBoxColumn.Name = "tanggalpendaftaranDataGridViewTextBoxColumn";
            this.tanggalpendaftaranDataGridViewTextBoxColumn.ReadOnly = true;
            this.tanggalpendaftaranDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 686);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftar_bimbel_baruDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private daftar_bimbel_baruDataSet daftar_bimbel_baruDataSet;
        private System.Windows.Forms.BindingSource pendaftaranBindingSource;
        private daftar_bimbel_baruDataSetTableAdapters.pendaftaranTableAdapter pendaftaranTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpendaftaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalpendaftaranDataGridViewTextBoxColumn;
    }
}