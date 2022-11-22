using Projeto3;

namespace Projeto4;
internal class Program
{
    static void Main(string[] args)
    {
        Triangulo x, y;
        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X: ");
        x.A = double.Parse(Console.ReadLine());
        x.B = double.Parse(Console.ReadLine());
        x.C = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com as medidas do triânguloY: ");
        y.A = double.Parse(Console.ReadLine());
        y.B = double.Parse(Console.ReadLine());
        y.C = double.Parse(Console.ReadLine());

        double areaX = x.Area();

        double areaY = y.Area();

        Console.WriteLine("Área de X : " + areaX.ToString());
        Console.WriteLine("Área de y : " + areaY.ToString());

        if (areaX > areaY)
        {
            Console.WriteLine("Maior área é a do triângulo X");
        }
        else
        {
            Console.WriteLine("Maior área é a do triângulo Y");
        }
    }
}