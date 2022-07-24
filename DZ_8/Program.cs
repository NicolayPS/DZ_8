using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DZ_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp";
            var dirP = @"D:\Temp";
            var dir = Directory.EnumerateDirectories(dirP, "*", SearchOption.AllDirectories);
            foreach (var item in dir)
            {
                Console.WriteLine(item);
            }
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            DirectoryInfo Disk = new DirectoryInfo(path);
            DirectoryInfo[] disk = Disk.GetDirectories();
            foreach (string file in files)
            {
                
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
