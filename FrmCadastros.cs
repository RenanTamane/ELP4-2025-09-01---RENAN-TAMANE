using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4Paises
{
    public partial class FrmCadastros : ProjetoELP4Paises.Frm
    {
        public FrmCadastros()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Sair();
        }

        public virtual void Salvar()
        { }

        public virtual void CarregaTxt()
        { }

        public virtual void LimparTxt()
        { }

        public virtual void BloquearTxt()
        { }

        public virtual void DesbloquearTxt()
        { }

    }
}
