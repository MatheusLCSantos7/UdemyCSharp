using System.Globalization;
namespace primeiroprojeto
{
    internal class program
    {
        static void Main(string[] args)
        {
            //operadores (math.)
            double duplo = 10.2342;
            float b = (float)duplo;
            int a = 5;
            int c = 2;
            double d = (double)a / c;
            double raiz = Math.Sqrt(b);
            double quadrado = Math.Pow(a, 2);

            Console.WriteLine(raiz);
            Console.WriteLine(quadrado);
            Console.WriteLine(d);
            Console.WriteLine(b);
            Console.WriteLine(duplo.ToString("F4", CultureInfo.InvariantCulture));

            // entrada de dados 2

            int n1 = int.Parse(Console.ReadLine());
            char nh = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] veti = Console.ReadLine().Split(' ');
            string nome = veti[0];
            char sexo = char.Parse(veti[1]);
            int idade = int.Parse(veti[2]);
            double altura = double.Parse(veti[3], CultureInfo.InvariantCulture);

            Console.WriteLine(n1);
            Console.WriteLine(nh);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            // operadores logicos e comparativos no capítulo
            // if e else
            //



        }
    }
}
