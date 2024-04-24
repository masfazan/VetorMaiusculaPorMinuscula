char[] vogais = new char[5];
//laço para passar as vogais, começa no zero e deve ir até 4 posição, incrementando 1
for (int i = 0; i < 5; i++)
{   //[i] para adicionar o 'char' no vetor letras
    Console.Write($"Digite a letra ({i}): ");
    //inicializa o 'char'
    vogais[i] = char.Parse(Console.ReadLine()); 

    switch (vogais[i]) //parametro do switch, será o vetor para usar nos casos
    {//a conversão é de [minúscula] para [MAIÚSCULA]
        case 'a': //se caso 'a' pega e troca no vetor pelo 'A'
            vogais[i] = 'A'; 
            break;
        case 'e':
            vogais[i] = 'E';
            break;
        case 'i':
            vogais[i] = 'I';
            break;
        case 'o':
            vogais[i] = 'O';
            break;
        case 'u':
            vogais[i] = 'U';
            break;
        default:
            break;
    }
}

Console.WriteLine("Texto alterado de minúscula para maiúscula: ");
//imprimir 
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(vogais[i]);
}
