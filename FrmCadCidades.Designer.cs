namespace ProjetoELP4Paises
{
    partial class FrmCadCidades
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
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblCodigoEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigoEstado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(90, 27);
            this.txtCidade.MaxLength = 55;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(449, 20);
            this.txtCidade.TabIndex = 1;
            // 
            // txtDDD
            // 
            this.txtDDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDD.Location = new System.Drawing.Point(565, 27);
            this.txtDDD.MaxLength = 5;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(75, 20);
            this.txtDDD.TabIndex = 2;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(90, 12);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(562, 11);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 13;
            this.lblDDD.Text = "DDD";
            // 
            // lblCodigoEstado
            // 
            this.lblCodigoEstado.AutoSize = true;
            this.lblCodigoEstado.Location = new System.Drawing.Point(12, 64);
            this.lblCodigoEstado.Name = "lblCodigoEstado";
            this.lblCodigoEstado.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEstado.TabIndex = 14;
            this.lblCodigoEstado.Text = "Codigo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(90, 64);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodigoEstado
            // 
            this.txtCodigoEstado.Location = new System.Drawing.Point(12, 80);
            this.txtCodigoEstado.MaxLength = 55;
            this.txtCodigoEstado.Name = "txtCodigoEstado";
            this.txtCodigoEstado.Size = new System.Drawing.Size(62, 20);
            this.txtCodigoEstado.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(90, 80);
            this.txtEstado.MaxLength = 55;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(448, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(565, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmCadCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(652, 388);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodigoEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCodigoEstado);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtCidade);
            this.Name = "FrmCadCidades";
            this.Text = "Cadastro de Cidades";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtDDD, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.lblDDD, 0);
            this.Controls.SetChildIndex(this.lblCodigoEstado, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtCodigoEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblCodigoEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigoEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnBuscar;
    }
}
