namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm un nom d'usuari");
        string usuari = Console.ReadLine();

        Console.WriteLine("Ara digue'm un domini");
        string domini = Console.ReadLine();

        Console.WriteLine($"La teva nova adreça de correu electrònic és {usuari}@{domini}.com");
    }
};
