/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada 
de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence.
O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA 
(nesta situação sem escrever mensagem alguma).*/

int x, y;

string[] vet = Console.ReadLine().Split(" ");
x = int.Parse(vet[0]);
y = int.Parse(vet[1]);

while (true)
{

    if (x > 0 && y > 0)
    {
        Console.WriteLine("primeiro");
    }

    else if (x > 0 && y < 0)
    {
        Console.WriteLine("quarto");
    }

    else if (x < 0 && y < 0)
    {
        Console.WriteLine("terceiro");
    }

    else if (x < 0 && y > 0)
    {
        Console.WriteLine("segundo");
    }

    else if (x == 0 || y == 0)
    {
        break;
    }
    vet = Console.ReadLine().Split(" ");
    x = int.Parse(vet[0]);
    y = int.Parse(vet[1]);
}
