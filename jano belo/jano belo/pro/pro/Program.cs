using System;

class Program
{
    static void Main()
    {
        int horniMez = 10;

        for (int i = 1; i <= horniMez; i++)
        {
            for (int j = 1; j <= horniMez; j++)
            {
                int vysledek = i * j;
                Console.Write($"{vysledek}\t");
            }
            Console.WriteLine();
        }
    }
}
