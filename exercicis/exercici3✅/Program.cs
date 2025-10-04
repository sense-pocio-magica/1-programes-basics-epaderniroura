namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nom del producte");
        string producte = Console.ReadLine();

        Console.WriteLine("El seu preu");
        var preu = Console.ReadLine();

        Console.WriteLine("Està en estoc?");
        string respostastock = Console.ReadLine();
        bool stock = respostastock.ToLower() == "sí" || respostastock.ToLower() == "true";


        if (stock == true)
        {
            Console.WriteLine("El producte està disponible");
        }
        else
        {
            Console.WriteLine("El producte no està disponible");
        }


        Console.WriteLine($"El producte {producte}, costa {preu}, i està {stock}");
    }
}
