using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1SoftTheme
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("INPUT.txt");
            sw.Write("000011111000101011110111011111111111111101110111111");
            sw.Close();
            string line = File.ReadAllText("INPUT.txt");
            // Второй способ реализован с использованием метода Split();
            string[] LinesArray = line.Split('0'); // создаем массив, элементами которого будят строки содержащие только единицы.Так как разделителем есть ноль.
            // Задача сводится к поиску максимального.
            int max = 0;
            for (int i = 0; i < LinesArray.Length; i++)
            {
                if (LinesArray[i].Length > max)
                    max = LinesArray[i].Length;

            }
            sw = new StreamWriter("OUTPUT.txt");
            sw.Write(max);
            sw.Close();
            Console.ReadLine();
        }
    }
}
