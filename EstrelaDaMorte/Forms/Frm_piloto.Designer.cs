
namespace EstrelaDaMorte
{
    partial class Frm_piloto
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label anoNascimentoLabel;
            System.Windows.Forms.Label idPilotoLabel;
            System.Windows.Forms.Label idPlanetaLabel;
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.pilotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pilotosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_cadastro = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.pilotosNavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPlanetaComboBox = new System.Windows.Forms.ComboBox();
            this.planetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotosNavesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            nomeLabel = new System.Windows.Forms.Label();
            anoNascimentoLabel = new System.Windows.Forms.Label();
            idPilotoLabel = new System.Windows.Forms.Label();
            idPlanetaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(239, 5);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // anoNascimentoLabel
            // 
            anoNascimentoLabel.AutoSize = true;
            anoNascimentoLabel.Location = new System.Drawing.Point(10, 35);
            anoNascimentoLabel.Name = "anoNascimentoLabel";
            anoNascimentoLabel.Size = new System.Drawing.Size(88, 13);
            anoNascimentoLabel.TabIndex = 5;
            anoNascimentoLabel.Text = "Ano Nascimento:";
            // 
            // idPilotoLabel
            // 
            idPilotoLabel.AutoSize = true;
            idPilotoLabel.Location = new System.Drawing.Point(9, 9);
            idPilotoLabel.Name = "idPilotoLabel";
            idPilotoLabel.Size = new System.Drawing.Size(48, 13);
            idPilotoLabel.TabIndex = 7;
            idPilotoLabel.Text = "Id Piloto:";
            // 
            // idPlanetaLabel
            // 
            idPlanetaLabel.AutoSize = true;
            idPlanetaLabel.Location = new System.Drawing.Point(239, 39);
            idPlanetaLabel.Name = "idPlanetaLabel";
            idPlanetaLabel.Size = new System.Drawing.Size(46, 13);
            idPlanetaLabel.TabIndex = 14;
            idPlanetaLabel.Text = "Planeta:";
            // 
            // txt_nome
            // 
            this.txt_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosBindingSource, "Nome", true));
            this.txt_nome.Location = new System.Drawing.Point(290, 5);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(218, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // pilotosBindingSource
            // 
            this.pilotosBindingSource.DataSource = typeof(Sistema.DAL.Pilotos);
            // 
            // txt_ano
            // 
            this.txt_ano.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosBindingSource, "AnoNascimento", true));
            this.txt_ano.Location = new System.Drawing.Point(104, 32);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(121, 20);
            this.txt_ano.TabIndex = 6;
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosBindingSource, "IdPiloto", true));
            this.txt_id.Location = new System.Drawing.Point(104, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 8;
            // 
            // pilotosDataGridView
            // 
            this.pilotosDataGridView.AllowUserToAddRows = false;
            this.pilotosDataGridView.AllowUserToDeleteRows = false;
            this.pilotosDataGridView.AutoGenerateColumns = false;
            this.pilotosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilotosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.pilotosDataGridView.DataSource = this.pilotosBindingSource;
            this.pilotosDataGridView.Location = new System.Drawing.Point(12, 90);
            this.pilotosDataGridView.Name = "pilotosDataGridView";
            this.pilotosDataGridView.ReadOnly = true;
            this.pilotosDataGridView.Size = new System.Drawing.Size(496, 253);
            this.pilotosDataGridView.TabIndex = 10;
            this.pilotosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilotosDataGridView_CellContentClick);
            this.pilotosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pilotosDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPiloto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnoNascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ano de Nascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Planetas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Planetas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // Btn_novo
            // 
            this.Btn_novo.Location = new System.Drawing.Point(104, 61);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_novo.TabIndex = 11;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_cadastro
            // 
            this.Btn_cadastro.Location = new System.Drawing.Point(210, 61);
            this.Btn_cadastro.Name = "Btn_cadastro";
            this.Btn_cadastro.Size = new System.Drawing.Size(75, 23);
            this.Btn_cadastro.TabIndex = 12;
            this.Btn_cadastro.Text = "Cadastrar";
            this.Btn_cadastro.UseVisualStyleBackColor = true;
            this.Btn_cadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(321, 61);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 14;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // pilotosNavesBindingSource
            // 
            this.pilotosNavesBindingSource.DataMember = "PilotosNaves";
            this.pilotosNavesBindingSource.DataSource = this.pilotosBindingSource;
            // 
            // idPlanetaComboBox
            // 
            this.idPlanetaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosBindingSource, "IdPlaneta", true));
            this.idPlanetaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pilotosBindingSource, "IdPlaneta", true));
            this.idPlanetaComboBox.DataSource = this.planetasBindingSource;
            this.idPlanetaComboBox.DisplayMember = "Nome";
            this.idPlanetaComboBox.FormattingEnabled = true;
            this.idPlanetaComboBox.Location = new System.Drawing.Point(290, 36);
            this.idPlanetaComboBox.Name = "idPlanetaComboBox";
            this.idPlanetaComboBox.Size = new System.Drawing.Size(218, 21);
            this.idPlanetaComboBox.TabIndex = 15;
            this.idPlanetaComboBox.ValueMember = "IdPlaneta";
            // 
            // planetasBindingSource
            // 
            this.planetasBindingSource.DataSource = typeof(Sistema.DAL.Planetas);
            // 
            // pilotosNavesBindingSource1
            // 
            this.pilotosNavesBindingSource1.DataMember = "PilotosNaves";
            this.pilotosNavesBindingSource1.DataSource = this.pilotosBindingSource;
            // 
            // Frm_piloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 358);
            this.Controls.Add(idPlanetaLabel);
            this.Controls.Add(this.idPlanetaComboBox);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_cadastro);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.pilotosDataGridView);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(anoNascimentoLabel);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(idPilotoLabel);
            this.Name = "Frm_piloto";
            this.Text = "Cadastro de Pilotos";
            this.Load += new System.EventHandler(this.Frm_piloto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilotosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pilotosBindingSource;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView pilotosDataGridView;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_cadastro;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.BindingSource pilotosNavesBindingSource;
        private System.Windows.Forms.ComboBox idPlanetaComboBox;
        private System.Windows.Forms.BindingSource planetasBindingSource;
        private System.Windows.Forms.BindingSource pilotosNavesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}