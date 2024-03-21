using CSharp_Projeto2;

Industria industria = new Industria();
industria.Nome = "FSMS Enterprises";
industria.Localizacao = "Curitiba-PR";
industria.AnoFundacao = 1909;

LinhaProducao linhaProducao1 = new LinhaProducao();
linhaProducao1.Numero = 1;
linhaProducao1.Capacidade = 10;
linhaProducao1.Tipo = "Echimento e Corte";

LinhaProducao linhaProducao2 = new LinhaProducao();
linhaProducao2.Numero = 2;
linhaProducao2.Capacidade = 35;
linhaProducao2.Tipo = "Embalagem";

Produto produto1 = new Produto();
produto1.Nome = "Prego";
produto1.Codigo = 99001;
produto1.Preco = 0.90m;

Produto produto2 = new Produto();
produto2.Nome = "Cola de Madeira";
produto2.Codigo = 99002;
produto2.Preco = 10.90m;

Produto produto3 = new Produto();
produto3.Nome = "Lixa";
produto3.Codigo = 99003;
produto3.Preco = 7.50m;

Produto produto4 = new Produto();
produto4.Nome = "Parafuso (1 Pacote)";
produto4.Codigo = 99004;
produto4.Preco = 25.50m;

Maquina maquina1 = new Maquina();
maquina1.Id = 1;
maquina1.Marca = "Bosch";
maquina1.Modelo = "ZT-100";
maquina1.Produto = produto1;

Maquina maquina2 = new Maquina();
maquina2.Id = 2;
maquina2.Marca = "Vonder";
maquina2.Modelo = "Delux V80";
maquina2.Produto = produto2;

Maquina maquina3 = new Maquina();
maquina3.Id = 3;
maquina3.Marca = "Bosch";
maquina3.Modelo = "Vaniker-787";
maquina3.Produto = produto3;

Maquina maquina4 = new Maquina();
maquina4.Id = 4;
maquina4.Marca = "Makita";
maquina4.Modelo = "VX-Bluster";
maquina4.Produto = produto4;

linhaProducao1.AdicionarMaquina(maquina1);
linhaProducao1.AdicionarMaquina(maquina2);

linhaProducao2.AdicionarMaquina(maquina3);
linhaProducao2.AdicionarMaquina(maquina4);

industria.AdicionarLinhaProducao(linhaProducao1);
industria.AdicionarLinhaProducao(linhaProducao2);

industria.ExibirInformacao();
