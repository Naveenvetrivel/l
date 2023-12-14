using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string display = " ";
        char[][,] charArray = new char[3][,] { new char[,] { { 'A', 'B', 'C' }, { 'D', 'E', 'F' } }, new char[,] { { 'G', 'H' }, { 'I', 'J' } }, new char[,] { { 'K', 'L', 'M', 'N' }, { 'O', 'P', 'Q', 'R' } }, };
        for (int i = 0; i < charArray.Length; i++)
        {
            display += $"Element ({i}) \n";

            for (int j = 0; j < charArray[i].GetLength(0); j++)
            {
                for (int k = 0; k < charArray[i].GetLength(1); k++)
                {
                    display += charArray[i][j, k].ToString() + " ";
                }
                display += "\n";
            }
        }
        Console.WriteLine(display);
    }
}
