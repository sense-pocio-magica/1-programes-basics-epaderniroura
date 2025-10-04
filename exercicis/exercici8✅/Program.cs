namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm minuts totals que vols passar a hores i minuts restants exactes");
        var minuts = Console.ReadLine();
        int minuts1 = Convert.ToInt16(minuts);

        var hores = minuts1 / 60;
        int totalminuts = minuts1 % 60;

        Console.WriteLine($"Seràn {hores} hores, i {totalminuts} minuts");
    }   
};
