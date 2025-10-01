namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main()
    {
        Console.WriteLine("Digue'm una nota");
        var nota1 = Console.ReadLine();
        Console.WriteLine("Digue'm una segona nota");
        var nota2 = Console.ReadLine();
        Console.WriteLine("Digue'm la tercera nota");
        var nota3 = Console.ReadLine();

        float numero1 = float.Parse(nota1);
        float numero2 = float.Parse(nota2);
        float numero3 = float.Parse(nota3);


        float suma_mitjana = nota1 + nota2 + nota3;
        float divi_mitjana = suma_mitjana / 3;
  
        Console.WriteLine($"La teva mitjana és {divi_mitjana}");
    }
};
