using System;
using System.IO;
using System.Text;

namespace Rus_OOP_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("D:\\3.2.txt");
            string sentence = fromFile.ReadLine();
            fromFile.Close();
            Console.WriteLine(sentence);
            char[] c = sentence.ToCharArray();
            char c1 = c[0];
            c[0] = c[3];
            c[3] = c1;
            for (int i = 0; i < sentence.Length; i++)
            {
               Console.Write(c[i]);
                
            }
            string s1 = new string(c);
            File.WriteAllText("d:\\one.txt", s1);
        }
    }
}
