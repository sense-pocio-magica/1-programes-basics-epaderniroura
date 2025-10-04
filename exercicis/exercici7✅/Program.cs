namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main()
    {
        Console.WriteLine("Digue'm una nota");
        var nota1 = Console.ReadLine();
        int nota11 = Convert.ToInt16(nota1);
        Console.WriteLine("Digue'm una segona nota");
        var nota2 = Console.ReadLine();
        int nota22 = Convert.ToInt16(nota2);
        Console.WriteLine("Digue'm la tercera nota");
        var nota3 = Console.ReadLine();
        int nota33 = Convert.ToInt16(nota3);

        float suma_mitjana = nota11 + nota22 + nota33;
        float divi_mitjana = suma_mitjana / 3;
        Console.WriteLine($"La teva mitjana és {divi_mitjana}");
    }
};
