using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4Paises
{
    internal class Cidades : Pai
    {
        protected string cidade;
        protected string ddd;
        protected Estados oEstado;

        public Cidades()
        {
            cidade = string.Empty;
            ddd = string.Empty;
            oEstado = new Estados();
        }

        public Cidades(int codigo, DateTime datcad, DateTime ultalt, string cidade, string ddd) : base(codigo, datcad, ultalt)
        {
            this.cidade = cidade;
            this.ddd = ddd;
        }

        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }

        public string DDD
        {
            get => ddd;
            set => ddd = value;
        }

        public Estados OEstado
        {
            get => oEstado;
            set => oEstado = value;
        }
    }
}
