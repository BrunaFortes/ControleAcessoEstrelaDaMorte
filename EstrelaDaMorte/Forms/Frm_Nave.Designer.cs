
namespace EstrelaDaMorte.Forms
{
    partial class Frm_Nave
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
            System.Windows.Forms.Label cargaLabel;
            System.Windows.Forms.Label classeLabel;
            System.Windows.Forms.Label idNaveLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label passageirosLabel;
            this.txt_carga = new System.Windows.Forms.TextBox();
            this.navesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_classe = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_passageiros = new System.Windows.Forms.TextBox();
            this.pilotosNavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navesDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cargaLabel = new System.Windows.Forms.Label();
            classeLabel = new System.Windows.Forms.Label();
            idNaveLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            passageirosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cargaLabel
            // 
            cargaLabel.AutoSize = true;
            cargaLabel.Location = new System.Drawing.Point(444, 38);
            cargaLabel.Name = "cargaLabel";
            cargaLabel.Size = new System.Drawing.Size(38, 13);
            cargaLabel.TabIndex = 1;
            cargaLabel.Text = "Carga:";
            cargaLabel.Click += new System.EventHandler(this.cargaLabel_Click);
            // 
            // txt_carga
            // 
            this.txt_carga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.navesBindingSource, "Carga", true));
            this.txt_carga.Location = new System.Drawing.Point(488, 35);
            this.txt_carga.Name = "txt_carga";
            this.txt_carga.Size = new System.Drawing.Size(108, 20);
            this.txt_carga.TabIndex = 2;
            // 
            // navesBindingSource
            // 
            this.navesBindingSource.DataSource = typeof(Sistema.DAL.Naves);
            // 
            // classeLabel
            // 
            classeLabel.AutoSize = true;
            classeLabel.Location = new System.Drawing.Point(12, 35);
            classeLabel.Name = "classeLabel";
            classeLabel.Size = new System.Drawing.Size(41, 13);
            classeLabel.TabIndex = 3;
            classeLabel.Text = "Classe:";
            // 
            // txt_classe
            // 
            this.txt_classe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.navesBindingSource, "Classe", true));
            this.txt_classe.Location = new System.Drawing.Point(66, 32);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(231, 20);
            this.txt_classe.TabIndex = 4;
            // 
            // idNaveLabel
            // 
            idNaveLabel.AutoSize = true;
            idNaveLabel.Location = new System.Drawing.Point(12, 9);
            idNaveLabel.Name = "idNaveLabel";
            idNaveLabel.Size = new System.Drawing.Size(43, 13);
            idNaveLabel.TabIndex = 5;
            idNaveLabel.Text = "Código:";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.navesBindingSource, "IdNave", true));
            this.txt_id.Location = new System.Drawing.Point(66, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(30, 20);
            this.txt_id.TabIndex = 6;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(303, 9);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 7;
            modeloLabel.Text = "Modelo:";
            modeloLabel.Click += new System.EventHandler(this.modeloLabel_Click);
            // 
            // txt_modelo
            // 
            this.txt_modelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.navesBindingSource, "Modelo", true));
            this.txt_modelo.Location = new System.Drawing.Point(354, 6);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(242, 20);
            this.txt_modelo.TabIndex = 8;
            this.txt_modelo.TextChanged += new System.EventHandler(this.modeloTextBox_TextChanged);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(109, 9);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 9;
            nomeLabel.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.navesBindingSource, "Nome", true));
            this.txt_nome.Location = new System.Drawing.Point(153, 6);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(144, 20);
            this.txt_nome.TabIndex = 10;
            // 
            // passageirosLabel
            // 
            passageirosLabel.AutoSize = true;
            passageirosLabel.Location = new System.Drawing.Point(303, 38);
            passageirosLabel.Name = "passageirosLabel";
            passageirosLabel.Size = new System.Drawing.Size(67, 13);
            passageirosLabel.TabIndex = 11;
            passageirosLabel.Text = "Passageiros:";
            // 
            // txt_passageiros
            // 
            this.txt_passageiros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.navesBindingSource, "Passageiros", true));
            this.txt_passageiros.Location = new System.Drawing.Point(376, 35);
            this.txt_passageiros.Name = "txt_passageiros";
            this.txt_passageiros.Size = new System.Drawing.Size(62, 20);
            this.txt_passageiros.TabIndex = 12;
            // 
            // pilotosNavesBindingSource
            // 
            this.pilotosNavesBindingSource.DataMember = "PilotosNaves";
            this.pilotosNavesBindingSource.DataSource = this.navesBindingSource;
            // 
            // navesDataGridView
            // 
            this.navesDataGridView.AllowUserToAddRows = false;
            this.navesDataGridView.AllowUserToDeleteRows = false;
            this.navesDataGridView.AutoGenerateColumns = false;
            this.navesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.navesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.navesDataGridView.DataSource = this.navesBindingSource;
            this.navesDataGridView.Location = new System.Drawing.Point(15, 71);
            this.navesDataGridView.Name = "navesDataGridView";
            this.navesDataGridView.ReadOnly = true;
            this.navesDataGridView.Size = new System.Drawing.Size(902, 368);
            this.navesDataGridView.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(791, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdNave";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Passageiros";
            this.dataGridViewTextBoxColumn4.HeaderText = "Passageiros";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Carga";
            this.dataGridViewTextBoxColumn5.HeaderText = "Carga";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Classe";
            this.dataGridViewTextBoxColumn6.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // Frm_Nave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 451);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navesDataGridView);
            this.Controls.Add(passageirosLabel);
            this.Controls.Add(this.txt_passageiros);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(idNaveLabel);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(classeLabel);
            this.Controls.Add(this.txt_classe);
            this.Controls.Add(cargaLabel);
            this.Controls.Add(this.txt_carga);
            this.Name = "Frm_Nave";
            this.Text = "Cadastro Nave";
            this.Load += new System.EventHandler(this.Frm_Nave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource navesBindingSource;
        private System.Windows.Forms.TextBox txt_carga;
        private System.Windows.Forms.TextBox txt_classe;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_passageiros;
        private System.Windows.Forms.BindingSource pilotosNavesBindingSource;
        private System.Windows.Forms.DataGridView navesDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}