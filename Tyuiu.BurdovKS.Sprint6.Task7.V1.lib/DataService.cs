

using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.BurdovKS.Sprint6.Task7.V1.lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {
            var lines = File.ReadAllLines(path);
            int rows = lines.Length;

            if (rows == 0) // Проверка на пустой файл
                throw new InvalidOperationException("Файл пустой.");

            
            int cols = lines[0].Split(';').Length;

            int[,] arr = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] linr = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    if (c == 2) 
                    {
                        if (int.TryParse(linr[c], out int value) && value < 0)
                        {
                            arr[r, c] = 1;
                        }
                        else if (int.TryParse(linr[c], out value))
                        {
                            arr[r, c] = value;
                        }
                        else
                        {
                            throw new FormatException($"Невозможно преобразовать '{linr[c]}' в целое число.");
                        }
                    }
                    else
                    {
                        if (!int.TryParse(linr[c], out int value))
                        {
                            throw new FormatException($"Невозможно преобразовать '{linr[c]}' в целое число.");
                        }
                        arr[r, c] = value;
                    }
                }
            }

            return arr;



        }
    }
}
