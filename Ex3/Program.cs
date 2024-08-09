int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};
int soma = 0;

for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        soma+= numeros[i];
    }
}

Console.WriteLine($"A soma dos pares do vetor é de {soma}");
