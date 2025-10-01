Console.WriteLine("Dammi un numero!");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
    Console.WriteLine("il numero da te inserito è pari!");
else
    Console.WriteLine("il numero da te inserito NON è pari");

int un_altro_numero = 1;
while (un_altro_numero <= 100)
{
    if (un_altro_numero % 3 == 0)
        Console.WriteLine($"il numero '{un_altro_numero}' è divisibile per 3!");
    else
        Console.WriteLine($"il numero '{un_altro_numero}' NON è divisibile per 3!");
    un_altro_numero++;
}