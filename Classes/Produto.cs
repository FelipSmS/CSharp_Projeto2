using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Projeto2
{
    public class Produto
    {
        public string Nome {get; set;} = "";
        public int Codigo {get; set;}
        public decimal Preco {get; set;}

        public void ExibirInformacao()
        {
            Console.WriteLine($"______PRODUTO: {Nome}, {Codigo}, {Preco}");
        }

        public void AtualizaValor(decimal novoPreco)
        {   
            Console.WriteLine("");
            Console.WriteLine("************ALTERANDO VALOR************");
            Console.WriteLine("");
            Console.WriteLine($"PRECO ANTERIOR: {Preco}");
            this.Preco = novoPreco;
            Console.WriteLine($"PRECO ATUAL: {Preco}");


        }
    }
}