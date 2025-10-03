namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm un nom");
        string nom = Console.ReadLine();

        Console.WriteLine("Digue'm un cognom");
        string cognom = Console.ReadLine();


        string nommaju = char.ToUpper(nom[0]) + nom.Substring(1);
        string cognommaju = char.ToUpper(cognom[0]) + nom.Substring(1);

        Console.WriteLine($"Hola {nommaju} {cognommaju}");
    }
};
