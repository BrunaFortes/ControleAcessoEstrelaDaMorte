namespace EstrelaDaMorte.Forms
{
    partial class Frm_historicoViagens
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
            System.Windows.Forms.Label idPilotoLabel;
            System.Windows.Forms.Label idNaveLabel;
            System.Windows.Forms.Label dtSaidaLabel;
            System.Windows.Forms.Label dtChegadaLabel;
            this.historicoViagensDataGridView = new System.Windows.Forms.DataGridView();
            this.historicoViagensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_piloto = new System.Windows.Forms.ComboBox();
            this.cbb_nave = new System.Windows.Forms.ComboBox();
            this.dt_saida = new System.Windows.Forms.DateTimePicker();
            this.dt_chegada = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_cadastrar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.navesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idPilotoLabel = new System.Windows.Forms.Label();
            idNaveLabel = new System.Windows.Forms.Label();
            dtSaidaLabel = new System.Windows.Forms.Label();
            dtChegadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historicoViagensDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoViagensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // historicoViagensDataGridView
            // 
            this.historicoViagensDataGridView.AllowUserToAddRows = false;
            this.historicoViagensDataGridView.AllowUserToDeleteRows = false;
            this.historicoViagensDataGridView.AutoGenerateColumns = false;
            this.historicoViagensDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historicoViagensDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.historicoViagensDataGridView.DataSource = this.historicoViagensBindingSource;
            this.historicoViagensDataGridView.Location = new System.Drawing.Point(12, 109);
            this.historicoViagensDataGridView.Name = "historicoViagensDataGridView";
            this.historicoViagensDataGridView.ReadOnly = true;
            this.historicoViagensDataGridView.Size = new System.Drawing.Size(573, 252);
            this.historicoViagensDataGridView.TabIndex = 1;
            this.historicoViagensDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.historicoViagensDataGridView_CellFormatting);
            // 
            // historicoViagensBindingSource
            // 
            this.historicoViagensBindingSource.DataSource = typeof(Sistema.DAL.HistoricoViagens);
            // 
            // idPilotoLabel
            // 
            idPilotoLabel.AutoSize = true;
            idPilotoLabel.Location = new System.Drawing.Point(292, 15);
            idPilotoLabel.Name = "idPilotoLabel";
            idPilotoLabel.Size = new System.Drawing.Size(36, 13);
            idPilotoLabel.TabIndex = 1;
            idPilotoLabel.Text = "Piloto:";
            // 
            // cbb_piloto
            // 
            this.cbb_piloto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historicoViagensBindingSource, "IdPiloto", true));
            this.cbb_piloto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.historicoViagensBindingSource, "IdPiloto", true));
            this.cbb_piloto.DataSource = this.pilotosBindingSource;
            this.cbb_piloto.DisplayMember = "Nome";
            this.cbb_piloto.FormattingEnabled = true;
            this.cbb_piloto.Location = new System.Drawing.Point(334, 12);
            this.cbb_piloto.Name = "cbb_piloto";
            this.cbb_piloto.Size = new System.Drawing.Size(200, 21);
            this.cbb_piloto.TabIndex = 2;
            this.cbb_piloto.ValueMember = "IdPiloto";
            // 
            // idNaveLabel
            // 
            idNaveLabel.AutoSize = true;
            idNaveLabel.Location = new System.Drawing.Point(42, 15);
            idNaveLabel.Name = "idNaveLabel";
            idNaveLabel.Size = new System.Drawing.Size(36, 13);
            idNaveLabel.TabIndex = 3;
            idNaveLabel.Text = "Nave:";
            // 
            // cbb_nave
            // 
            this.cbb_nave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historicoViagensBindingSource, "IdNave", true));
            this.cbb_nave.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.historicoViagensBindingSource, "IdNave", true));
            this.cbb_nave.DataSource = this.navesBindingSource;
            this.cbb_nave.DisplayMember = "Nome";
            this.cbb_nave.FormattingEnabled = true;
            this.cbb_nave.Location = new System.Drawing.Point(115, 12);
            this.cbb_nave.Name = "cbb_nave";
            this.cbb_nave.Size = new System.Drawing.Size(165, 21);
            this.cbb_nave.TabIndex = 4;
            this.cbb_nave.ValueMember = "IdNave";
            // 
            // dtSaidaLabel
            // 
            dtSaidaLabel.AutoSize = true;
            dtSaidaLabel.Location = new System.Drawing.Point(42, 44);
            dtSaidaLabel.Name = "dtSaidaLabel";
            dtSaidaLabel.Size = new System.Drawing.Size(51, 13);
            dtSaidaLabel.TabIndex = 5;
            dtSaidaLabel.Text = "Dt Saida:";
            // 
            // dt_saida
            // 
            this.dt_saida.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.historicoViagensBindingSource, "DtSaida", true));
            this.dt_saida.Location = new System.Drawing.Point(115, 38);
            this.dt_saida.Name = "dt_saida";
            this.dt_saida.Size = new System.Drawing.Size(232, 20);
            this.dt_saida.TabIndex = 6;
            // 
            // dtChegadaLabel
            // 
            dtChegadaLabel.AutoSize = true;
            dtChegadaLabel.Location = new System.Drawing.Point(42, 68);
            dtChegadaLabel.Name = "dtChegadaLabel";
            dtChegadaLabel.Size = new System.Drawing.Size(67, 13);
            dtChegadaLabel.TabIndex = 7;
            dtChegadaLabel.Text = "Dt Chegada:";
            // 
            // dt_chegada
            // 
            this.dt_chegada.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.historicoViagensBindingSource, "DtChegada", true));
            this.dt_chegada.Location = new System.Drawing.Point(115, 64);
            this.dt_chegada.Name = "dt_chegada";
            this.dt_chegada.Size = new System.Drawing.Size(232, 20);
            this.dt_chegada.TabIndex = 8;
            this.dt_chegada.Value = new System.DateTime(2021, 10, 4, 0, 0, 0, 0);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdNave";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdPiloto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Piloto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DtSaida";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Saída";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DtChegada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Chegada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Btn_novo
            // 
            this.Btn_novo.Location = new System.Drawing.Point(380, 40);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_novo.TabIndex = 9;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Btn_cadastrar
            // 
            this.Btn_cadastrar.Location = new System.Drawing.Point(474, 39);
            this.Btn_cadastrar.Name = "Btn_cadastrar";
            this.Btn_cadastrar.Size = new System.Drawing.Size(80, 53);
            this.Btn_cadastrar.TabIndex = 10;
            this.Btn_cadastrar.Text = "Cadastrar";
            this.Btn_cadastrar.UseVisualStyleBackColor = true;
            this.Btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(380, 69);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 11;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // navesBindingSource
            // 
            this.navesBindingSource.DataSource = typeof(Sistema.DAL.Naves);
            // 
            // pilotosBindingSource
            // 
            this.pilotosBindingSource.DataSource = typeof(Sistema.DAL.Pilotos);
            // 
            // Frm_historicoViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 373);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_cadastrar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(dtChegadaLabel);
            this.Controls.Add(this.dt_chegada);
            this.Controls.Add(dtSaidaLabel);
            this.Controls.Add(this.dt_saida);
            this.Controls.Add(idNaveLabel);
            this.Controls.Add(this.cbb_nave);
            this.Controls.Add(idPilotoLabel);
            this.Controls.Add(this.cbb_piloto);
            this.Controls.Add(this.historicoViagensDataGridView);
            this.Name = "Frm_historicoViagens";
            this.Text = "Frm_historicoViagens";
            this.Load += new System.EventHandler(this.Frm_historicoViagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historicoViagensDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoViagensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource historicoViagensBindingSource;
        private System.Windows.Forms.DataGridView historicoViagensDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cbb_piloto;
        private System.Windows.Forms.ComboBox cbb_nave;
        private System.Windows.Forms.DateTimePicker dt_saida;
        private System.Windows.Forms.DateTimePicker dt_chegada;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_cadastrar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.BindingSource navesBindingSource;
        private System.Windows.Forms.BindingSource pilotosBindingSource;
    }
}