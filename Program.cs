using System.Drawing;
using System.Text;

namespace DesafioCarnaval7;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("O numero de ordem minimo para essa sequencia é 2");
        Console.WriteLine("====================================================");
        Console.Write("coloca o numero de ordem da sequencia de Fibinnacci: ");
        int.TryParse(Console.ReadLine(), out int ordem);

        if (ordem == 0 && ordem == 1)
        {
            Console.WriteLine("numero de Ordem invalido! \n O numero de ordem minimo para essa sequencia é 2");
        }
        Console.Clear();
        //var sequencia = SequenciaFibonacci(ordem); 
        var triangulo = MontadorDeTriangulo(ordem);
        Console.WriteLine(triangulo);
    }

    private static string MontadorDeTriangulo(int valor)
    {
        StringBuilder stringBuilder = new StringBuilder(); 

        //Construir a sequencia de fibonacci
        int[] fibonacci = new int[valor];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 2; i < fibonacci.Length; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        //iterar sobre os elementos da sequencia de fibonacci
        for (int i = 0; i < valor; i++)
        {
            for (int j = 0; j <= i; j++)
            {

                stringBuilder.Append($"{fibonacci[j]}  ");
            }
            stringBuilder.Append("\n");
        }
        return stringBuilder.ToString();
    }
}
