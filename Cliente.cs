using System;
using System.Collections.Generic;
using System.Text;

namespace TrabCarro
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public long CPF { get; set; }
        public int Score { get; set; }

        public void imprimirPessoaSimula()
        {
            Console.WriteLine("Cliente:" + Nome);
            Console.WriteLine("CPF:" + CPF);
            Console.WriteLine("Score:" + Score);
        }
    }
}
