namespace primeiroprojeto
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1,n2,n3);
            Console.WriteLine("Maior: " + resultado);
        }

        static int Maior(int x1, int x2, int x3)
        {
            int m;
            if (x1 > x2 && x1 > x3)
            {
                m = x1;
            } else if (x2 > x3)
            {
                m = x2;
            } else
            {
                m = x3;
            }
            return m;
        }
        
    }
}
