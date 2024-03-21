using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CSharp_Projeto2
{
    public class LinhaProducao
    {
        public int Numero {get; set;}
        public string Tipo {get; set;} = "";
        public int Capacidade {get; set;}
        public List<Maquina> Maquina = new List<Maquina>();

        public void ExibirInformacao()
        {  
            Console.WriteLine($"LINHA: {Numero}, {Tipo}, {Capacidade}");
            foreach(var maquina in Maquina)
            {
                maquina.ExibirInformacao();
                Console.WriteLine("");
            }
        }

        public void AdicionarMaquina(Maquina maquina)
        {
            this.Maquina.Add(maquina);
        }
    }



}