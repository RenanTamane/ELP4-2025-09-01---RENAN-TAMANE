using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4Paises
{
    public partial class FrmConsEstados : ProjetoELP4Paises.FrmConsultas
    {
        FrmCadEstados oFrmCadEstados;
        Estados oEstado;
        Controller aCtrl; 
        
        public FrmConsEstados()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {
<<<<<<< HEAD
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.ShowDialog();
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
        }

        protected override void Incluir()
        {
            oFrmCadEstados.LimparTxt();
            oFrmCadEstados.ConhecaObj(oEstado,aCtrl);
            oFrmCadEstados.ShowDialog();
        }

        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
<<<<<<< HEAD
            oFrmCadEstados.LimparTxt();
            oFrmCadEstados.CarregaTxt();
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
            oFrmCadEstados.ShowDialog();
        }

        protected override void Excluir()
        {
            string aux;
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.LimparTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloquearTxt();
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();
<<<<<<< HEAD
            oFrmCadEstados.btnSalvar.Text = aux;
=======
>>>>>>> ffa9440768137c691538c511443f828cdbfab332
        }

        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadEstados = (FrmCadEstados)obj;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

    }
}
