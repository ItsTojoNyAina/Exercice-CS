using System;

int x = 5;
int y = 5;
char[,] a = new char[x, y];


for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        a[i, j] = '.';
    }
}

int PlayerCol = 0;
int PlayerLig = 0;
a[PlayerLig, PlayerCol] = 'P';

Console.WriteLine("Entrer la position du trésor :");
Console.WriteLine("ligne: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("colonne: ");
int y1 = int.Parse(Console.ReadLine());


a[x1, y1] = 'T';

while (true)
{
    Console.Clear();
    DisplayGrid(a);

    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    char move = keyInfo.KeyChar;

    a[PlayerLig, PlayerCol] = '.';

    switch (move)
    {
        case 'z':
            if (PlayerLig > 0) PlayerLig--;
            break;
        case 's':
            if (PlayerLig < x - 1) PlayerLig++;
            break;
        case 'q':
            if (PlayerCol > 0) PlayerCol--;
            break;
        case 'd':
            if (PlayerCol < y - 1) PlayerCol++;
            break;
    }

    a[PlayerLig, PlayerCol] = 'P';

    if (PlayerLig == x1 && PlayerCol == y1)
    {
        Console.Clear();
        DisplayGrid(a);
        Console.WriteLine("Félicitation Zanjy kobonao le Aferaaaaa!!!");
        break;
    }
}

void DisplayGrid(char[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i, j] + " ");
        }
        Console.WriteLine();
    }
}
