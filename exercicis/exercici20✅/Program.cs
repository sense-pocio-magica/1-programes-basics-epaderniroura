namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escriu un número de tres xifres: ");
        var num = Console.ReadLine();
        int num1 = Convert.ToInt16(num);

        int unitats = num1 % 10;
        int centenes = num1 / 100;
        int desenes = (num1 % 100) / 10; 
        // string res = new string(num.Reverse().ToArray());
        Console.WriteLine($"{unitats}{desenes}{centenes}");
    }
};
