
namespace EstrelaDaMorte
{
    partial class Frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu));
            this.Btn_autorizacaoVoo = new System.Windows.Forms.Button();
            this.Btn_historicoViagem = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pilotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_autorizacaoVoo
            // 
            this.Btn_autorizacaoVoo.Location = new System.Drawing.Point(48, 81);
            this.Btn_autorizacaoVoo.Name = "Btn_autorizacaoVoo";
            this.Btn_autorizacaoVoo.Size = new System.Drawing.Size(110, 90);
            this.Btn_autorizacaoVoo.TabIndex = 4;
            this.Btn_autorizacaoVoo.Text = "Autorização Vôo";
            this.Btn_autorizacaoVoo.UseVisualStyleBackColor = true;
            this.Btn_autorizacaoVoo.Click += new System.EventHandler(this.Btn_autorizacaoVoo_Click);
            // 
            // Btn_historicoViagem
            // 
            this.Btn_historicoViagem.Location = new System.Drawing.Point(177, 81);
            this.Btn_historicoViagem.Name = "Btn_historicoViagem";
            this.Btn_historicoViagem.Size = new System.Drawing.Size(110, 90);
            this.Btn_historicoViagem.TabIndex = 5;
            this.Btn_historicoViagem.Text = "Histórico Viagens";
            this.Btn_historicoViagem.UseVisualStyleBackColor = true;
            this.Btn_historicoViagem.Click += new System.EventHandler(this.Btn_historicoViagem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilotoToolStripMenuItem,
            this.naveToolStripMenuItem,
            this.planetaToolStripMenuItem});
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // pilotoToolStripMenuItem
            // 
            this.pilotoToolStripMenuItem.Name = "pilotoToolStripMenuItem";
            this.pilotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilotoToolStripMenuItem.Text = "Piloto";
            this.pilotoToolStripMenuItem.Click += new System.EventHandler(this.pilotoToolStripMenuItem_Click);
            // 
            // naveToolStripMenuItem
            // 
            this.naveToolStripMenuItem.Name = "naveToolStripMenuItem";
            this.naveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.naveToolStripMenuItem.Text = "Nave";
            this.naveToolStripMenuItem.Click += new System.EventHandler(this.naveToolStripMenuItem_Click);
            // 
            // planetaToolStripMenuItem
            // 
            this.planetaToolStripMenuItem.Name = "planetaToolStripMenuItem";
            this.planetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planetaToolStripMenuItem.Text = "Planeta";
            this.planetaToolStripMenuItem.Click += new System.EventHandler(this.planetaToolStripMenuItem_Click_1);
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(352, 233);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Btn_historicoViagem);
            this.Controls.Add(this.Btn_autorizacaoVoo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_menu";
            this.Text = "Controle Estrela da Morte";
            this.Load += new System.EventHandler(this.Frm_menu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_autorizacaoVoo;
        private System.Windows.Forms.Button Btn_historicoViagem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pilotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planetaToolStripMenuItem;
    }
}

