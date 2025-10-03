namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entra el primer número");
        var numero1 = Console.ReadLine();
        int numero11 = Convert.ToInt16(numero1);

        Console.WriteLine("Entra el segon número");
        var numero2 = Console.ReadLine();
        int numero22 = Convert.ToInt16(numero2);

        double suma = numero11 + numero22;
        double resta = numero11 - numero22;
        double multiplicacio = numero11 * numero22;
        double divisio = (double)numero11 / (double)numero22;
        double divisio2 = divisio % numero22;

        Console.WriteLine($"{numero11} + {numero22} = {suma}");
        Console.WriteLine($"{numero11} - {numero22} = {resta}");
        Console.WriteLine($"{numero11} * {numero22} = {multiplicacio}");
        Console.WriteLine($"{numero11} / {numero22} = {divisio} i en sobra {divisio2}");

    }
};
