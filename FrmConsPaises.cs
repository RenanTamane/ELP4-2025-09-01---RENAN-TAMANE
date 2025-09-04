using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4Paises
{
    public partial class FrmConsPaises : ProjetoELP4Paises.FrmConsultas
    {
        FrmCadPaises oFrmCadPaises;
        Paises oPais;
        Controller aCtrl;
        
        public FrmConsPaises()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {
        }

        protected override void Incluir()
        {
            oFrmCadPaises.LimparTxt();
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
        }

        protected override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimparTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }

        protected override void Excluir()
        {
            string aux;
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimparTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloquearTxt();
            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "Excluir";
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloquearTxt();
<<<<<<< HEAD
            oFrmCadPaises.btnSalvar.Text = aux;
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
        }

        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadPaises = (FrmCadPaises)obj;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oPais = (Paises)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
