using System;
using System.Collections.Generic;
using System.Text;

namespace TrabCarro
{
    public abstract class Carro
    {
        public string Nome { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public double Preco { get; set; }
        public int Ano { get; set; }
        public double Km { get; set; }
        public double lucroLoja { get; set; }

        public void Vendas()
        {

        }
        public double Lucro(double valorCarro)
        {
            this.lucroLoja = valorCarro;

            return lucroLoja;
        }
    }
}
