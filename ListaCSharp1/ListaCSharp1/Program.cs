using System;
namespace ListaCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTÃO 01
            Console.WriteLine("Questão 01");
            Console.Write("\n\t01 , 02, 03, 04, 05, 06, 07, 08, 09, 10");
            Console.Write("\n\t11 , 12, 13, 14, 15, 16, 17, 18, 19, 20");
            Console.Write("\n\t21 , 22, 23, 24, 25, 26, 27, 28, 29, 30");
            Console.Write("\n\t31 , 32, 33, 34, 35, 36, 37, 38, 39, 40");

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 02
            Console.WriteLine("\n");
            Console.WriteLine("Questão 02");

            int x = 2;
            int y = 3;

            Console.WriteLine("\n\tx = " + x); // Mostra o valor de X
            Console.WriteLine("\n\tO valor de x + x é = " + (x + x)); // Soma X+X
            Console.WriteLine("\n\ty = " + y); // Mostra o valor de y
            Console.WriteLine("\n\t(x + y)" + " = " + (y + x)); // Soma x+y

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 03
            Console.WriteLine("\n");
            Console.WriteLine("Questão 03");

            Console.WriteLine("*\n * *\n * **\n * ***\n * ****"); //Imprime uma só linha com várias quebras de texto

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 04
            Console.WriteLine("\n");
            Console.WriteLine("Questão 04");

            Console.Write("*"); // Texto em uma linha
            Console.Write("***"); // Não deu quebra de linha e permaneceu junto com o texto anterior
            Console.WriteLine("*****"); // Deu quebra de linha
            Console.Write("****"); // Não deu quebra de linha e permaneceu junto com o texto anterior
            Console.WriteLine("**");  // Deu quebra de linha

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 05
            Console.WriteLine("\n");
            Console.WriteLine("Questão 05");

            Console.WriteLine("\n\tQual o seu nome?");
            var name = Console.ReadLine();

            Console.WriteLine("\n\tQual o seu sobrenome?");
            var subna = Console.ReadLine();

            Console.WriteLine("\n\tQual o seu RA?");
            var reg = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"\n\t{reg}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{name} {subna}");
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 06
            Console.WriteLine("\n");
            Console.WriteLine("Questão 06");

            double numero1, numero2;

            Console.WriteLine("\n\tDigite um número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\tDigite outro número: ");
            numero2 = double.Parse(Console.ReadLine());

            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;
            double divisao = numero1 / numero2;

            Console.WriteLine("\tA soma dos números é {0}\n\tA subtração dos números é {1}\n\tA multiplicação dos número é {2}\n\tA divisão dos números é {3:N1}", soma, subtracao, multiplicacao, divisao);

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 07
            Console.WriteLine("\n");
            Console.WriteLine("\nQuestão 07");

            const double PI = 3.14D;
            double area = 0;
            double raio = 0;
            double diam = 0;
            double circ = 0;

            Console.Write("Qual o valor do raio? ");
            raio = double.Parse(Console.ReadLine());

            area = PI * raio * raio;
            diam = 2 * raio;
            circ = PI * diam;

            Console.Write("\n\tA área do circulo é: " + area);
            Console.Write("\n\tO diâmetro do circulo é: " + diam);
            Console.Write("\n\tA circunferência do circulo é: " + circ);

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 08
            Console.WriteLine("\n");
            Console.WriteLine("\nQuestão 08");

            int a;
            int b;
            int resto = 0;

            Console.WriteLine("Informe um valor para a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe um valor para b: ");
            b = Convert.ToInt32(Console.ReadLine());

            resto = a % b;

            if (resto == 0)
            {
                Console.WriteLine($"{a} é divisível de {b}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{a} não é divisível de {b}");
                Console.ReadKey();
                Console.Clear();
            }

            // QUESTÃO 09
            //Console.WriteLine("\n");
            //Console.WriteLine("\nQuestão 09");

            //Console.ReadKey();
            //Console.Clear();

            // QUESTÃO 10
            Console.WriteLine("\n");
            Console.WriteLine("\nQuestão 10");

            int S, H;
            S = 0 * 0;
            H = 0 * 0 * 0;

            Console.Write("\nNúmero \t\t Quadrado \t Cubo");
            Console.WriteLine("\n");
            
            Console.WriteLine("0000\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);
            S = 0 * 0;
            H = 0 * 0 * 0;

            S = 1 * 1;
            H = 1 * 1 * 1;
            Console.WriteLine("0001\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 2 * 2;
            H = 2 * 2 * 2;
            Console.WriteLine("0002\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 3 * 3;
            H = 3 * 3 * 3;
            Console.WriteLine("0003\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 4 * 4;
            H = 4 * 4 * 4;
            Console.WriteLine("0004\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 5 * 5;
            H = 5 * 5 * 5;
            Console.WriteLine("0005\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 6 * 6;
            H = 6 * 6 * 6;
            Console.WriteLine("0006\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 7 * 7;
            H = 7 * 7 * 7;
            Console.WriteLine("0007\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 8 * 8;
            H = 8 * 8 * 8;
            Console.WriteLine("0008\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 9 * 9;
            H = 9 * 9 * 9;
            Console.WriteLine("0009\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            S = 10 * 10;
            H = 10 * 10 * 10;
            Console.WriteLine("0010\t\t" + S);
            Console.WriteLine("\t\t\t\t" + H);

            Console.ReadKey();
            Console.Clear();
        }
            
    }
}
