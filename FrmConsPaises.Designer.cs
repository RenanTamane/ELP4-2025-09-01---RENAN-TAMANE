namespace ProjetoELP4Paises
{
    partial class FrmConsPaises
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
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.TabIndex = 1;
            // 
            // FrmConsPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Name = "FrmConsPaises";
            this.Text = "Consulta de Paises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
