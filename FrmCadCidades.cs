using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ProjetoELP4Paises
{
    public partial class FrmCadCidades : ProjetoELP4Paises.FrmCadastros
    {
        Cidades aCidade;
        Controller aCtrl;
        FrmConsEstados oFrmConsEstados;
        public FrmCadCidades()
        {
            InitializeComponent();
        }

        public void setFrmConsEstados (Object obj)
        {
            if (obj != null)
                oFrmConsEstados = (FrmConsEstados)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }
        public override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N)") == "S")
            aCidade.Codigo  = Convert.ToInt32(txtCodigo.Text);
            aCidade.Cidade  = txtCidade.Text;
            aCidade.DDD     = txtDDD.Text;
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(aCidade.Codigo);
            this.txtCidade.Text = aCidade.Cidade;
            this.txtDDD.Text = aCidade.DDD;
        }

        public override void LimparTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDDD.Clear();
        }

        public override void BloquearTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDDD.Enabled = false;
            this.txtCodigoEstado.Enabled = false;
            this.txtEstado.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDDD.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsEstados.btnSair.Text;
            oFrmConsEstados.btnSair.Text = "Selecionar";
            oFrmConsEstados.ConhecaObj(aCidade.OEstado, aCtrl);
            oFrmConsEstados.ShowDialog();
            this.txtCodigoEstado.Text = Convert.ToString(aCidade.OEstado.Codigo);
            this.txtEstado.Text = aCidade.OEstado.Estado.ToString();
            oFrmConsEstados.btnSair.Text = btnSair;
        }
    }
}
