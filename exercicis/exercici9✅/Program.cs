namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dona'm un valor en metre");
        var valor = Console.ReadLine();
        int valor1 = Convert.ToInt32(valor);

        var multiplicar = valor1 * 3.28084;

        Console.WriteLine($"El valor a peus és {multiplicar}");
    }
};
