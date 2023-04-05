namespace pryArmaniniAutoCor_SP1
{
    partial class frmConsulta
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
            this.mrcMarca1 = new System.Windows.Forms.Label();
            this.cmbMarca1 = new System.Windows.Forms.ComboBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optAmbos = new System.Windows.Forms.RadioButton();
            this.optImportado1 = new System.Windows.Forms.RadioButton();
            this.optNacional1 = new System.Windows.Forms.RadioButton();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnConsultar1 = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcMarca1
            // 
            this.mrcMarca1.AutoSize = true;
            this.mrcMarca1.Location = new System.Drawing.Point(26, 29);
            this.mrcMarca1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mrcMarca1.Name = "mrcMarca1";
            this.mrcMarca1.Size = new System.Drawing.Size(37, 13);
            this.mrcMarca1.TabIndex = 0;
            this.mrcMarca1.Text = "Marca";
            // 
            // cmbMarca1
            // 
            this.cmbMarca1.FormattingEnabled = true;
            this.cmbMarca1.Items.AddRange(new object[] {
            "Marca A",
            "Marca B",
            "Marca C"});
            this.cmbMarca1.Location = new System.Drawing.Point(77, 27);
            this.cmbMarca1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMarca1.Name = "cmbMarca1";
            this.cmbMarca1.Size = new System.Drawing.Size(181, 21);
            this.cmbMarca1.TabIndex = 1;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optAmbos);
            this.mrcOrigen.Controls.Add(this.optImportado1);
            this.mrcOrigen.Controls.Add(this.optNacional1);
            this.mrcOrigen.Location = new System.Drawing.Point(28, 67);
            this.mrcOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcOrigen.Size = new System.Drawing.Size(267, 57);
            this.mrcOrigen.TabIndex = 2;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optAmbos
            // 
            this.optAmbos.AutoSize = true;
            this.optAmbos.Location = new System.Drawing.Point(189, 27);
            this.optAmbos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optAmbos.Name = "optAmbos";
            this.optAmbos.Size = new System.Drawing.Size(57, 17);
            this.optAmbos.TabIndex = 2;
            this.optAmbos.TabStop = true;
            this.optAmbos.Text = "Ambos";
            this.optAmbos.UseVisualStyleBackColor = true;
            // 
            // optImportado1
            // 
            this.optImportado1.AutoSize = true;
            this.optImportado1.Location = new System.Drawing.Point(99, 27);
            this.optImportado1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optImportado1.Name = "optImportado1";
            this.optImportado1.Size = new System.Drawing.Size(72, 17);
            this.optImportado1.TabIndex = 1;
            this.optImportado1.TabStop = true;
            this.optImportado1.Text = "Importado";
            this.optImportado1.UseVisualStyleBackColor = true;
            // 
            // optNacional1
            // 
            this.optNacional1.AutoSize = true;
            this.optNacional1.Location = new System.Drawing.Point(14, 27);
            this.optNacional1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optNacional1.Name = "optNacional1";
            this.optNacional1.Size = new System.Drawing.Size(67, 17);
            this.optNacional1.TabIndex = 0;
            this.optNacional1.TabStop = true;
            this.optNacional1.Text = "Nacional";
            this.optNacional1.UseVisualStyleBackColor = true;
            // 
            // btnSalir1
            // 
            this.btnSalir1.Location = new System.Drawing.Point(437, 67);
            this.btnSalir1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(86, 30);
            this.btnSalir1.TabIndex = 3;
            this.btnSalir1.Text = "Salir";
            this.btnSalir1.UseVisualStyleBackColor = true;
            // 
            // btnConsultar1
            // 
            this.btnConsultar1.Location = new System.Drawing.Point(437, 22);
            this.btnConsultar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar1.Name = "btnConsultar1";
            this.btnConsultar1.Size = new System.Drawing.Size(86, 30);
            this.btnConsultar1.TabIndex = 4;
            this.btnConsultar1.Text = "Consultar";
            this.btnConsultar1.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTabla.Location = new System.Drawing.Point(9, 149);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(649, 255);
            this.dgvTabla.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Marca";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Origen";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Precio";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(669, 414);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnConsultar1);
            this.Controls.Add(this.btnSalir1);
            this.Controls.Add(this.mrcOrigen);
            this.Controls.Add(this.cmbMarca1);
            this.Controls.Add(this.mrcMarca1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsulta";
            this.Text = "AUTOCOR - Consulta";
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mrcMarca1;
        private System.Windows.Forms.ComboBox cmbMarca1;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optAmbos;
        private System.Windows.Forms.RadioButton optImportado1;
        private System.Windows.Forms.RadioButton optNacional1;
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnConsultar1;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}