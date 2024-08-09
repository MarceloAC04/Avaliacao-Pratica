string[] nomes = new string[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine("Os nomes cadastrados foram:");
Array.Sort(nomes);
foreach (string n in nomes)
{
    Console.WriteLine(n);
}