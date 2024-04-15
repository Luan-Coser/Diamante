
int tamanho = 0, linha = 0, meio = 0, comeco = 1;

    Console.WriteLine("Tamanho:");
    tamanho = int.Parse(Console.ReadLine());


meio = tamanho / 2;

for (int j = 0; j < tamanho/2; j++)
{
    for (int i = 0; i < meio; i++)
    {
        Console.Write(" ");

    }
    meio = meio - 1;
    for (int i = 0; i < comeco; i++)
    {
        Console.Write("x");

    }
    comeco = comeco + 2;
    Console.WriteLine("\t");
}

for (int i = 0; i < tamanho; i++)
{
    Console.Write("x");
}
Console.WriteLine("\t");

meio = meio + 1;
comeco = comeco - 2;

for (int j = 0; j < tamanho / 2; j++)
{
    for (int i = 0; i < meio; i++)
    {
        Console.Write(" ");

    }
    meio = meio + 1;
    for (int i = 0; i < comeco; i++)
    {
        Console.Write("x");

    }
    comeco = comeco - 2;
    Console.WriteLine("\t");
}