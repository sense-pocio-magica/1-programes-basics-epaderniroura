namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm una paraula");
        string paraula = Console.ReadLine();

        var longitud = paraula.Length;
       // string longitud =
        Console.WriteLine($"La longitud de la teva {paraula} és {longitud}");
    }
};
