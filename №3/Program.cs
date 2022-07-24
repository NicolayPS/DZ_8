using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textMass;
            StreamReader sr = new StreamReader(@"D:\Temp\Text.txt");
            string s = "";
            while (sr.EndOfStream != true)
            {
                s += sr.ReadLine();
            }
            textMass = s.Split(' ');
            Console.Write("Количество слов:");
            Console.WriteLine(textMass.Length);
            sr.Close();
                Console.ReadLine();
        }
    }

}
