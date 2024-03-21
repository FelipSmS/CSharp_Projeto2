using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Projeto2
{
    public class Maquina
    {
        public int Id {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public Produto Produto = new Produto();

        public void ExibirInformacao()
        {
            Console.WriteLine($"____MAQUINA: {Id}, {Marca}, {Modelo}, {Produto.Nome}");
            Produto.ExibirInformacao();
        }

        public void InciarProducao()
        {
            Console.WriteLine($"Iniciando producao");
            Thread.Sleep(500);
            Console.WriteLine($"3");
            Thread.Sleep(500);
            Console.WriteLine($"2");
            Thread.Sleep(500);
            Console.WriteLine($"1");
        }
    }
}