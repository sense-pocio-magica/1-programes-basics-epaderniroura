namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hora actual");
        var horaactual = Console.ReadLine();
        int horaactual1 = Convert.ToInt16(horaactual);

        float hores = horaactual1 + 3;
        Console.WriteLine("Hores a incrementar: 3");
        Console.WriteLine($"D'aqui a 3 hores seràn les {hores}");
        
    }
};
