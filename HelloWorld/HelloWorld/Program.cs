using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"Olá, {name}, esse programa está rodando em {date:d} as {date:t}");
            Console.Write("Pressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}
