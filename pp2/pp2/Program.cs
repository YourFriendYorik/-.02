using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "output.txt"; // имя выходного файла
        int N = 5; // целое число N

        using (StreamWriter writer = File.CreateText(fileName))
        {
            for (int i = 1; i <= N; i++)
            {
                string line = "";
                for (char c = 'a'; c < 'a' + i; c++)
                {
                    line += c;
                }
                writer.WriteLine(line);
            }
        }

        // Выводим сообщение об успешном завершении
        Console.WriteLine($"Файл {fileName} успешно создан с содержимым по условию.");
    }
}