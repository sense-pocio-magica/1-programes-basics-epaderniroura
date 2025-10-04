namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin és el teu nom?");
        var nom = Console.ReadLine();

        Console.WriteLine("Any de naixement");
        var edat = Console.ReadLine();
        int edat1 = Convert.ToInt16(edat);
        int any = 2025 - edat1;


        Console.WriteLine($"Hola {nom}! Ja tens {any} anys?");
        
    }
}
