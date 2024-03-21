using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Projeto2
{
    public class Industria
    {
        public string Nome {get; set;} = "";
        public string Localizacao {get; set;} = "";
        public int AnoFundacao {get; set;}
        public List<LinhaProducao> LinhaProducao = new List<LinhaProducao>();

        public void ExibirInformacao()
        {
            Console.WriteLine($"*******************************************");
            Console.WriteLine($"{Nome}, {Localizacao}, {AnoFundacao}");
            Console.WriteLine($"*******************************************");
            Console.WriteLine($"");
                foreach(var linha in LinhaProducao)
                {
                    linha.ExibirInformacao();
                    Console.WriteLine($"===================================================");
                }
        }

        public void AdicionarLinhaProducao(LinhaProducao linhaProducao)
        {
            this.LinhaProducao.Add(linhaProducao);
        }
    }


}


