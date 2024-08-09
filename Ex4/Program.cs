static void Tabuada(int n)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{n}x{i} = {n * i}");
        Console.ResetColor();
    };
};

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine($"Tabuada do {numero}:");
Tabuada(numero);
