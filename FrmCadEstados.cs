using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4Paises
{
    public partial class FrmCadEstados : ProjetoELP4Paises.FrmCadastros
    {
        Estados oEstado;
        Controller aCtrl;
        FrmConsPaises oFrmConsPaises;
        public FrmCadEstados()
        {
            InitializeComponent();
        }

        public void setFrmConsPaises(Object obj)
        {
            if (obj != null)
                oFrmConsPaises = (FrmConsPaises)obj;
            
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        public override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N)") == "S")
            oEstado.Codigo  = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado  = txtEstado.Text;
            oEstado.Uf      = txtUf.Text;
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtUf.Text     = oEstado.Uf;
        }

        public override void LimparTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUf.Clear();
        }

        public override void BloquearTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled = false;
            this.txtCodigoPais.Enabled = false;
            this.txtPais.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsPaises.btnSair.Text;
            oFrmConsPaises.btnSair.Text = "Selecionar";
            oFrmConsPaises.ConhecaObj(oEstado.OPais, aCtrl);
            oFrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais.ToString();
            oFrmConsPaises.btnSair.Text = btnSair;
        }
    }
}
