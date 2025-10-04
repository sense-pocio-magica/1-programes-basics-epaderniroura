namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm una paraula");
        var paraula = Console.ReadLine();

        char primera = paraula[0];
        char ultima = paraula[paraula.Length - 1];
        char mig = paraula[paraula.Length / 2];
        Console.WriteLine($"La primera lletra és {primera}, l'última lletra és {ultima}, i la lletra del mig és {mig} ");
    }
};
