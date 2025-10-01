namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm una variable per al costat d'un quadrat");
        var variable = Console.ReadLine();
        int variable1 = Convert.ToInt16(variable);

        int multiplicar = variable1 * 4;

        Console.WriteLine($"El permímetre del quadrat creat és {multiplicar}");
    }
}
