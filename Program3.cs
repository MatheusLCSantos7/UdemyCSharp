
namespace Projeto3;

internal class Program
{
    static void Main(string[] args)
    {
        double xa, xb, xc, ya, yb, yc;
        Console.WriteLine("Entre com as medidas do triângulo X: ");
        xa = double.Parse(Console.ReadLine());
        xb= double.Parse(Console.ReadLine());
        xc = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com as medidas do triânguloY: ");

        ya = double.Parse(Console.ReadLine());
        yb = double.Parse(Console.ReadLine());
        yc = double.Parse(Console.ReadLine());

        double p = (xa + xb + xc) / 2;
        double areaX = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

        p = (ya + yc + yc) / 2;
        double areaY = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

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