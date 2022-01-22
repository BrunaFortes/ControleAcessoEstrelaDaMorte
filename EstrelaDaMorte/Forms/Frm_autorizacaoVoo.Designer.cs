namespace EstrelaDaMorte.Forms
{
    partial class Frm_autorizacaoVoo
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
            System.Windows.Forms.Label flagAutorizadoLabel;
            System.Windows.Forms.Label idNaveLabel1;
            System.Windows.Forms.Label idPilotoLabel1;
            this.pilotosNavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flagAutorizadoCheckBox = new System.Windows.Forms.CheckBox();
            this.cbb_nave = new System.Windows.Forms.ComboBox();
            this.navesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_piloto = new System.Windows.Forms.ComboBox();
            this.pilotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotosNavesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            flagAutorizadoLabel = new System.Windows.Forms.Label();
            idNaveLabel1 = new System.Windows.Forms.Label();
            idPilotoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flagAutorizadoLabel
            // 
            flagAutorizadoLabel.AutoSize = true;
            flagAutorizadoLabel.Location = new System.Drawing.Point(394, 15);
            flagAutorizadoLabel.Name = "flagAutorizadoLabel";
            flagAutorizadoLabel.Size = new System.Drawing.Size(83, 13);
            flagAutorizadoLabel.TabIndex = 5;
            flagAutorizadoLabel.Text = "Flag Autorizado:";
            // 
            // idNaveLabel1
            // 
            idNaveLabel1.AutoSize = true;
            idNaveLabel1.Location = new System.Drawing.Point(15, 15);
            idNaveLabel1.Name = "idNaveLabel1";
            idNaveLabel1.Size = new System.Drawing.Size(36, 13);
            idNaveLabel1.TabIndex = 7;
            idNaveLabel1.Text = "Nave:";
            // 
            // idPilotoLabel1
            // 
            idPilotoLabel1.AutoSize = true;
            idPilotoLabel1.Location = new System.Drawing.Point(213, 15);
            idPilotoLabel1.Name = "idPilotoLabel1";
            idPilotoLabel1.Size = new System.Drawing.Size(36, 13);
            idPilotoLabel1.TabIndex = 9;
            idPilotoLabel1.Text = "Piloto:";
            // 
            // pilotosNavesBindingSource
            // 
            this.pilotosNavesBindingSource.DataSource = typeof(Sistema.DAL.PilotosNaves);
            // 
            // flagAutorizadoCheckBox
            // 
            this.flagAutorizadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pilotosNavesBindingSource, "FlagAutorizado", true));
            this.flagAutorizadoCheckBox.Location = new System.Drawing.Point(483, 10);
            this.flagAutorizadoCheckBox.Name = "flagAutorizadoCheckBox";
            this.flagAutorizadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.flagAutorizadoCheckBox.TabIndex = 6;
            this.flagAutorizadoCheckBox.Text = "Permitido";
            this.flagAutorizadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // cbb_nave
            // 
            this.cbb_nave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosNavesBindingSource, "IdNave", true));
            this.cbb_nave.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pilotosNavesBindingSource, "IdNave", true));
            this.cbb_nave.DataSource = this.navesBindingSource;
            this.cbb_nave.DisplayMember = "Nome";
            this.cbb_nave.FormattingEnabled = true;
            this.cbb_nave.Location = new System.Drawing.Point(69, 12);
            this.cbb_nave.Name = "cbb_nave";
            this.cbb_nave.Size = new System.Drawing.Size(121, 21);
            this.cbb_nave.TabIndex = 8;
            this.cbb_nave.ValueMember = "IdNave";
            // 
            // navesBindingSource
            // 
            this.navesBindingSource.DataSource = typeof(Sistema.DAL.Naves);
            // 
            // cbb_piloto
            // 
            this.cbb_piloto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosNavesBindingSource, "IdPiloto", true));
            this.cbb_piloto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pilotosNavesBindingSource, "IdPiloto", true));
            this.cbb_piloto.DataSource = this.pilotosBindingSource;
            this.cbb_piloto.DisplayMember = "Nome";
            this.cbb_piloto.FormattingEnabled = true;
            this.cbb_piloto.Location = new System.Drawing.Point(267, 12);
            this.cbb_piloto.Name = "cbb_piloto";
            this.cbb_piloto.Size = new System.Drawing.Size(121, 21);
            this.cbb_piloto.TabIndex = 10;
            this.cbb_piloto.ValueMember = "IdPiloto";
            // 
            // pilotosBindingSource
            // 
            this.pilotosBindingSource.DataSource = typeof(Sistema.DAL.Pilotos);
            // 
            // pilotosNavesDataGridView1
            // 
            this.pilotosNavesDataGridView1.AllowUserToAddRows = false;
            this.pilotosNavesDataGridView1.AllowUserToDeleteRows = false;
            this.pilotosNavesDataGridView1.AutoGenerateColumns = false;
            this.pilotosNavesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilotosNavesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn2});
            this.pilotosNavesDataGridView1.DataSource = this.pilotosNavesBindingSource;
            this.pilotosNavesDataGridView1.Location = new System.Drawing.Point(18, 61);
            this.pilotosNavesDataGridView1.Name = "pilotosNavesDataGridView1";
            this.pilotosNavesDataGridView1.ReadOnly = true;
            this.pilotosNavesDataGridView1.Size = new System.Drawing.Size(675, 262);
            this.pilotosNavesDataGridView1.TabIndex = 10;
            this.pilotosNavesDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pilotosNavesDataGridView1_CellFormatting);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdPiloto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id Piloto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Pilotos";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pilotos";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdNave";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id Nave";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Naves";
            this.dataGridViewTextBoxColumn7.HeaderText = "Naves";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "FlagAutorizado";
            this.dataGridViewCheckBoxColumn2.HeaderText = "FlagAutorizado";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // Frm_autorizacaoVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 335);
            this.Controls.Add(this.pilotosNavesDataGridView1);
            this.Controls.Add(idPilotoLabel1);
            this.Controls.Add(this.cbb_piloto);
            this.Controls.Add(idNaveLabel1);
            this.Controls.Add(this.cbb_nave);
            this.Controls.Add(flagAutorizadoLabel);
            this.Controls.Add(this.flagAutorizadoCheckBox);
            this.Name = "Frm_autorizacaoVoo";
            this.Text = "Frm_autorizacaoVoo";
            this.Load += new System.EventHandler(this.Frm_autorizacaoVoo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pilotosNavesBindingSource;
        private System.Windows.Forms.CheckBox flagAutorizadoCheckBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox cbb_nave;
        private System.Windows.Forms.ComboBox cbb_piloto;
        private System.Windows.Forms.BindingSource navesBindingSource;
        private System.Windows.Forms.BindingSource pilotosBindingSource;
        private System.Windows.Forms.DataGridView pilotosNavesDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}