using System;
using System.IO;

namespace Rus_OOP_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("D:\\input.txt");
            string sentence = fromFile.ReadLine();
            fromFile.Close();
            Console.WriteLine(sentence);
            char[] c = sentence.ToCharArray();
            int n = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (Char.IsNumber(c[i]))
                {
                    n++;
                }
            }
            Console.WriteLine("кількість чисел у тексті {0}",n);
            File.WriteAllText("D:\\output.txt", string.Join("кількість чисел у тексті {0} ", n));

        }
    }
}
