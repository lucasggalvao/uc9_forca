int i, tentativas;
int encontrado = 0;
string letra;

string[] palavrasecreta = new string[10];
string[] palavravisivel = new string[10];

Console.WriteLine("Informe o nome do " + (i + 1) );





for (i = 0; i < 10; i++)
{
    Console.WriteLine((i + 1) + "ª Letra da palavra (total 10 letras");
    palavrasecreta[i] = Console.ReadLine();
}

for (i = 0; i < 10; i++)
{
    Console.Write(palavrasecreta[i] + " ");
    
}
Console.WriteLine("");
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

Console.Clear();

tentativas = 0;
while (tentativas < 10)
{
    Console.Clear();
    for (i = 0; i < 10; i++)
    {
        Console.Write(palavravisivel[i] + " ");
    }
    
    Console.WriteLine("Qual letra deseja tentar?");
    letra = Console.ReadLine();

    for (i = 0;i < 10; i++)
    {
        if (letra == palavrasecreta[i])
        {
            palavravisivel[i] = letra;
        }
    }
    
    if (encontrado == 0)
    {
        Console.WriteLine("Letra nao encontrada");
    }

    encontrado = 0;
    tentativas++;

    Console.WriteLine("");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}
