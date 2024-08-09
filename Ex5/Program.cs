string frase = "metal is the law";
char[] alfabeto = ['a','b','c','d','e','f','g','h','i','j','k','l','m'
                ,'n','o','p','q','r','s','t','u','v','w','x','y','z'];

foreach (char l in alfabeto)
{
    int index = 0;
    int quantidade = 0;
    if (frase.Contains(l))
    {
        while (index < frase.Length)
        {
            if (frase[index] == l)
            {
                quantidade++;
                index++;
            }
            else
            {
                index++;
            }

        };
        System.Console.WriteLine($"a letra {l} aparece {quantidade} vezes");
    }

}
