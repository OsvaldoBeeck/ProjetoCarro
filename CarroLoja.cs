using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TrabCarro
{
    class CarroLoja : Carro
    {

        public void venderCarroLoja(CarroLoja carroLoja, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Cliente:" + cliente.Nome);
            Console.WriteLine("Telefone:" + cliente.Telefone);
            Console.WriteLine("Endereço:" + cliente.Endereco);
            Console.WriteLine("------------------------");

            Console.WriteLine("Carro vendido:");
            Console.WriteLine("Nome:" + carroLoja.Nome);
            Console.WriteLine("Placa:" + carroLoja.Placa);
            Console.WriteLine("Cor:" + carroLoja.Cor);
            Console.WriteLine("Preço:" + carroLoja.Preco.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Km: " + carroLoja.Km.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------");
        }

        public double Lucro(double valorCarro)
        {
            this.lucroLoja = valorCarro;

            return lucroLoja;
        }
    }
}
