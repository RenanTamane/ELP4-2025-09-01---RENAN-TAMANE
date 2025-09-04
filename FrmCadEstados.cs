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
<<<<<<< HEAD
            oEstado.OPais.Codigo = Convert.ToInt32(txtCodigoPais.Text);
            oEstado.OPais.Pais = txtPais.Text;
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
<<<<<<< HEAD
            this.txtUf.Text     = Convert.ToString(oEstado.Uf);
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais;
=======
            this.txtUf.Text     = oEstado.Uf;
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
        }

        public override void LimparTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUf.Clear();
<<<<<<< HEAD
            this.txtCodigoPais.Text = "0";
            this.txtPais.Clear();
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
        }

        public override void BloquearTxt()
        {
<<<<<<< HEAD
            this.txtCodigo.Enabled = false;
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled = false;
            this.txtCodigoPais.Enabled = false;
            this.txtPais.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
<<<<<<< HEAD
            this.txtCodigo.Enabled = true;
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled = true;
            this.txtCodigoPais.Enabled = true;
            this.txtPais.Enabled = true;
=======
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled = true;
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
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
