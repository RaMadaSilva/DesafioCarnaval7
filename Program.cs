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
        var triangulo = MontadorDeTriangulo(ordem); 

            
    }

    private static string MontadorDeTriangulo(int valor)
    {

    }
}
