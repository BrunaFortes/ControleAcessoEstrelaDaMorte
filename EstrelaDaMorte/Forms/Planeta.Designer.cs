namespace EstrelaDaMorte.Forms
{
    partial class Frm_planeta
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
            this.climaLabel = new System.Windows.Forms.Label();
            this.diametroLabel = new System.Windows.Forms.Label();
            this.idPlanetaLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.orbitaLabel = new System.Windows.Forms.Label();
            this.populacaoLabel = new System.Windows.Forms.Label();
            this.rotacaoLabel = new System.Windows.Forms.Label();
            this.planetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_clima = new System.Windows.Forms.TextBox();
            this.txt_diametro = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_orbita = new System.Windows.Forms.TextBox();
            this.txt_populao = new System.Windows.Forms.TextBox();
            this.txt_rotacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_cadastrar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.planetasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.planetasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planetasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // climaLabel
            // 
            this.climaLabel.AutoSize = true;
            this.climaLabel.Location = new System.Drawing.Point(365, 49);
            this.climaLabel.Name = "climaLabel";
            this.climaLabel.Size = new System.Drawing.Size(35, 13);
            this.climaLabel.TabIndex = 1;
            this.climaLabel.Text = "Clima:";
            // 
            // diametroLabel
            // 
            this.diametroLabel.AutoSize = true;
            this.diametroLabel.Location = new System.Drawing.Point(348, 25);
            this.diametroLabel.Name = "diametroLabel";
            this.diametroLabel.Size = new System.Drawing.Size(52, 13);
            this.diametroLabel.TabIndex = 3;
            this.diametroLabel.Text = "Diametro:";
            // 
            // idPlanetaLabel
            // 
            this.idPlanetaLabel.AutoSize = true;
            this.idPlanetaLabel.Location = new System.Drawing.Point(72, 27);
            this.idPlanetaLabel.Name = "idPlanetaLabel";
            this.idPlanetaLabel.Size = new System.Drawing.Size(43, 13);
            this.idPlanetaLabel.TabIndex = 5;
            this.idPlanetaLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(92, 53);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 7;
            this.nomeLabel.Text = "Nome:";
            // 
            // orbitaLabel
            // 
            this.orbitaLabel.AutoSize = true;
            this.orbitaLabel.Location = new System.Drawing.Point(92, 105);
            this.orbitaLabel.Name = "orbitaLabel";
            this.orbitaLabel.Size = new System.Drawing.Size(38, 13);
            this.orbitaLabel.TabIndex = 9;
            this.orbitaLabel.Text = "Orbita:";
            // 
            // populacaoLabel
            // 
            this.populacaoLabel.AutoSize = true;
            this.populacaoLabel.Location = new System.Drawing.Point(339, 75);
            this.populacaoLabel.Name = "populacaoLabel";
            this.populacaoLabel.Size = new System.Drawing.Size(61, 13);
            this.populacaoLabel.TabIndex = 11;
            this.populacaoLabel.Text = "Populacao:";
            // 
            // rotacaoLabel
            // 
            this.rotacaoLabel.AutoSize = true;
            this.rotacaoLabel.Location = new System.Drawing.Point(79, 79);
            this.rotacaoLabel.Name = "rotacaoLabel";
            this.rotacaoLabel.Size = new System.Drawing.Size(51, 13);
            this.rotacaoLabel.TabIndex = 13;
            this.rotacaoLabel.Text = "Rotacao:";
            // 
            // planetasBindingSource
            // 
            this.planetasBindingSource.DataSource = typeof(Sistema.DAL.Planetas);
            // 
            // txt_clima
            // 
            this.txt_clima.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planetasBindingSource, "Clima", true));
            this.txt_clima.Location = new System.Drawing.Point(406, 46);
            this.txt_clima.Name = "txt_clima";
            this.txt_clima.Size = new System.Drawing.Size(134, 20);
            this.txt_clima.TabIndex = 2;
            // 
            // txt_diametro
            // 
            this.txt_diametro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planetasBindingSource, "Diametro", true));
            this.txt_diametro.Location = new System.Drawing.Point(406, 20);
            this.txt_diametro.Name = "txt_diametro";
            this.txt_diametro.Size = new System.Drawing.Size(134, 20);
            this.txt_diametro.TabIndex = 4;
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planetasBindingSource, "IdPlaneta", true));
            this.txt_codigo.Location = new System.Drawing.Point(136, 24);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(134, 20);
            this.txt_codigo.TabIndex = 6;
            // 
            // txt_nome
            // 
            this.txt_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planetasBindingSource, "Nome", true));
            this.txt_nome.Location = new System.Drawing.Point(136, 50);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(134, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // txt_orbita
            // 
            this.txt_orbita.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planetasBindingSource, "Orbita", true));
            this.txt_orbita.Location = new System.Drawing.Point(136, 102);
            this.txt_orbita.Name = "txt_orbita";
            this.txt_orbita.Size = new System.Drawing.Size(134, 20);
            this.txt_orbita.TabIndex = 10;
            // 
            // txt_populao
            // 
            this.txt_populao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planetasBindingSource, "Populacao", true));
            this.txt_populao.Location = new System.Drawing.Point(406, 72);
            this.txt_populao.Name = "txt_populao";
            this.txt_populao.Size = new System.Drawing.Size(134, 20);
            this.txt_populao.TabIndex = 12;
            // 
            // txt_rotacao
            // 
            this.txt_rotacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planetasBindingSource, "Rotacao", true));
            this.txt_rotacao.Location = new System.Drawing.Point(136, 76);
            this.txt_rotacao.Name = "txt_rotacao";
            this.txt_rotacao.Size = new System.Drawing.Size(134, 20);
            this.txt_rotacao.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_orbita);
            this.groupBox1.Controls.Add(this.rotacaoLabel);
            this.groupBox1.Controls.Add(this.txt_clima);
            this.groupBox1.Controls.Add(this.txt_rotacao);
            this.groupBox1.Controls.Add(this.climaLabel);
            this.groupBox1.Controls.Add(this.populacaoLabel);
            this.groupBox1.Controls.Add(this.txt_diametro);
            this.groupBox1.Controls.Add(this.txt_populao);
            this.groupBox1.Controls.Add(this.diametroLabel);
            this.groupBox1.Controls.Add(this.orbitaLabel);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.idPlanetaLabel);
            this.groupBox1.Controls.Add(this.nomeLabel);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 136);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_cadastrar
            // 
            this.Btn_cadastrar.Location = new System.Drawing.Point(300, 12);
            this.Btn_cadastrar.Name = "Btn_cadastrar";
            this.Btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cadastrar.TabIndex = 17;
            this.Btn_cadastrar.Text = "Cadastrar";
            this.Btn_cadastrar.UseVisualStyleBackColor = true;
            this.Btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(428, 12);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 18;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // planetasDataGridView
            // 
            this.planetasDataGridView.AllowUserToAddRows = false;
            this.planetasDataGridView.AllowUserToDeleteRows = false;
            this.planetasDataGridView.AutoGenerateColumns = false;
            this.planetasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planetasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.planetasDataGridView.DataSource = this.planetasBindingSource;
            this.planetasDataGridView.Location = new System.Drawing.Point(13, 183);
            this.planetasDataGridView.Name = "planetasDataGridView";
            this.planetasDataGridView.ReadOnly = true;
            this.planetasDataGridView.Size = new System.Drawing.Size(653, 258);
            this.planetasDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPlaneta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rotacao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rotacao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Orbita";
            this.dataGridViewTextBoxColumn4.HeaderText = "Orbita";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Diametro";
            this.dataGridViewTextBoxColumn5.HeaderText = "Diametro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Clima";
            this.dataGridViewTextBoxColumn6.HeaderText = "Clima";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Populacao";
            this.dataGridViewTextBoxColumn7.HeaderText = "Populacao";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Frm_planeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 461);
            this.Controls.Add(this.planetasDataGridView);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_cadastrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_planeta";
            this.Text = "Cadastro Planetas";
            this.Load += new System.EventHandler(this.Planeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planetasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planetasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource planetasBindingSource;
        private System.Windows.Forms.TextBox txt_clima;
        private System.Windows.Forms.TextBox txt_diametro;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_orbita;
        private System.Windows.Forms.TextBox txt_populao;
        private System.Windows.Forms.TextBox txt_rotacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_cadastrar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.DataGridView planetasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label climaLabel;
        private System.Windows.Forms.Label diametroLabel;
        private System.Windows.Forms.Label idPlanetaLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label orbitaLabel;
        private System.Windows.Forms.Label populacaoLabel;
        private System.Windows.Forms.Label rotacaoLabel;
    }
}