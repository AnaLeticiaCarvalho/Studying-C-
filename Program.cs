using boot1.models;

/*Pessoa pessoa1 = new Pessoa();

pessoa1.Name = "Kauã";
pessoa1.Age = 10;

pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);*/

// Convertendo tipos de variáveis

int a = Convert.ToInt32("5") ; // Primeira forma de converter variável

Console.WriteLine(a);

int b = int.Parse("2"); // Segunda forma de converter variáveis 

/* Diferança entre Convert e Parse

NO Convert se passar o valor Null, ele converte para 0
Já o Parse, não aceita o Valor Null, dá erro
Obs: Professor orientou o uso do Convert, para que se houver o Null, não dẽ erro
e o programa não pare
*/