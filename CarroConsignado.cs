using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TrabCarro
{
    class CarroConsignado : Carro, IAvalia1
    {

        public string texto { get; set; }

        public void Avaliado(string text)
        {
            this.texto = text;
        }
        public void imprimeAvalia()
        {
            Console.WriteLine("Avaliação:" + this.texto);
        }
        public void venderCarroConsignado(CarroConsignado carroConsginado, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Cliente:" + cliente.Nome);
            Console.WriteLine("Telefone:" + cliente.Telefone);
            Console.WriteLine("Endereço:" + cliente.Endereco);
            Console.WriteLine("------------------------");

            Console.WriteLine("Carro vendido:");
            Console.WriteLine("Nome:" + carroConsginado.Nome);
            Console.WriteLine("Placa:" + carroConsginado.Placa);
            Console.WriteLine("Cor:" + carroConsginado.Cor);
            Console.WriteLine("Preço:" + carroConsginado.Preco.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Km: " + carroConsginado.Km.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------");
        }

        public double Lucro(double valorCarro)
        {

            this.lucroLoja = valorCarro * 0.1;
            Console.WriteLine("------------------------");
            Console.WriteLine("Comissão:" + this.lucroLoja.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Taxa de preparação:" + 250.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Taxa de divulgação:" + 200.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("------------------------");
            this.lucroLoja = this.lucroLoja + 450;
            return lucroLoja;
        }
    }
}
