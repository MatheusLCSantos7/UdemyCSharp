using ConsoleApp2;
using System;
using System.Globalization;

namespace Item1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome:  ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço:  ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque:  ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("\nDados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adiciondos");

            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);
            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine("Digite o número de produtos a ser Removido");

            int qtd2 = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd2);
            Console.WriteLine("\nDados atualizados: " + p);
        }
    }
}