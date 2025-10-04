namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 9

*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nota de pràctiques");
        var notaprac = Console.ReadLine();
        int notaprac1 = Convert.ToInt16(notaprac);

        Console.WriteLine("Nota de l'examen");
        var notaexam = Console.ReadLine();
        int notaexam1 = Convert.ToInt16(notaexam);

        float suma = notaprac1 + notaexam1;
        float divisio = suma / 2;
        int rodo = Convert.ToInt16(divisio);

        Console.WriteLine($"La nota final és {divisio} o sigui un {rodo}");
    }
};
