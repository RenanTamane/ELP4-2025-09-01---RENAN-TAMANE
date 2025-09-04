using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4Paises
{
    public partial class FrmConsCidades : ProjetoELP4Paises.FrmConsultas
    {
        FrmCadCidades oFrmCadCidades;
        Cidades aCidade;
        Controller aCtrl;
        public FrmConsCidades()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {
<<<<<<< HEAD
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
        }

        protected override void Incluir()
        {
            oFrmCadCidades.LimparTxt();
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
        }

        protected override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
<<<<<<< HEAD
            oFrmCadCidades.LimparTxt();
            oFrmCadCidades.CarregaTxt();
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
            oFrmCadCidades.ShowDialog();
        }

        protected override void Excluir()
        {
            string aux;
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.LimparTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloquearTxt();
<<<<<<< HEAD
            oFrmCadCidades.btnSalvar.Text = aux;
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332

        }

        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadCidades = (FrmCadCidades)obj;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
