namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm el teu carrer");
        string carrer = Console.ReadLine();

        Console.WriteLine("Digue'm el teu número de carrer");
        string numero = Console.ReadLine();

        Console.WriteLine("Quin és el teu codi postal?");
        var codi = Console.ReadLine();

        Console.WriteLine("On vius?");
        string poblacio = Console.ReadLine();

        Console.WriteLine($"El meu carrer és {carrer}, el número és {numero}, el codi postal és {codi}, i visc a {poblacio}");
    }
}
