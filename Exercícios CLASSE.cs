\\ exercicio 1 verificação de nome
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite seu nome ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade \r\n");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade \r\n");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + p1.Nome);
            } else
            {
                Console.WriteLine("A pessoa mais velha é: " + p2.Nome);
            }
 \\ classe exercicio 1 
 namespace Projeto4
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;
    }
}
\\\\\\\\\\\\\\\\\\\\\\\\\\
\\Exercicio 2 (Media salarios)

using Projeto4;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valor p1, p2;
            p1 = new Valor();
            p2 = new Valor();

            Console.WriteLine("Digite seu nome ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu salário");
            p1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu salário");
            p2.Salario = int.Parse(Console.ReadLine());

            double media = (p1.Salario + p2.Salario) /2;
            Console.WriteLine("A média do salário dos 2 funcionários é: " + media);
            Console.ReadKey();
        }
    }
}

\Classe exercicio 2
namespace Projeto4
{
    internal class Valor
    {
        public string Nome;
        public int Salario;
    }
}
