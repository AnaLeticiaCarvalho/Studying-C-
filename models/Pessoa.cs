using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boot1.models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Name} e eu tenho {Age} anos.");
        }
    }
}