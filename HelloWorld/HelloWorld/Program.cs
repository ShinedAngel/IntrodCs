using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            var name = Console.ReadLine();

            Console.WriteLine("Quantos anos você tem?");
            var age = Console.ReadLine();

            Console.WriteLine($"Olá {name}, belo nome! Você tem {age} anos. Tenho um prazer enorme em conhecer você!");

            var date = DateTime.Now;
            Console.WriteLine($"Esse programa foi rodando em {date:d} as {date:t}");

            Console.Write("Pressione qualquer tecla para fechar...");
            Console.ReadKey(true);
        }
    }
}
