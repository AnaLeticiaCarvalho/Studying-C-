using boot1.models;

/*Pessoa pessoa1 = new Pessoa();

pessoa1.Name = "Kauã";
pessoa1.Age = 10;

pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);*/

// Convertendo tipos de variáveis

internal class Program
{
    private static void Main(string[] args)


    {
        // switch case

        Console.WriteLine("Digite uma letra: ");
        string letra = Console.ReadLine();

        switch (letra)
        {
         case"a":
         case"e":
         case"i":
         case"o":
         case"u":
         Console.WriteLine("Vogal");
         break;

         default:

         Console.WriteLine("Consoante");
         break;


        }










          /*   int quantidade = 10;
             int quantidadeCompra = 4;
             bool possivelVenda = quantidade >= quantidadeCompra;

             if (possivelVenda)
             {
                Console.WriteLine("Venda realizada!");
             }

             else
             {
                Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque!");
             }
             */
















/*Pessoa pessoa1 = new Pessoa();

pessoa1.Name = "Kauã";
pessoa1.Age = 10;

pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);*/

// Convertendo tipos de variáveis


        
        
        // TryParse tenta converter, se não conseguir, roda o resto do programa

        

       /* int a = Convert.ToInt32("5"); // Primeira forma de converter variável

        Console.WriteLine(a);

        int b = int.Parse("2"); // Segunda forma de converter variáveis */

        /* Diferança entre Convert e Parse

        NO Convert se passar o valor Null, ele converte para 0
        Já o Parse, não aceita o Valor Null, dá erro
        Obs: Professor orientou o uso do Convert, para que se houver o Null, não dẽ erro
        e o programa não pare
        */

        //Exemplo de como converter para string

      /*  int inteiro = 5;
= inteiro.ToString; */

/*int inteiro = 5;
string c = inteiro.ToString();
 Console.WriteLine(c);*/
    }
}



