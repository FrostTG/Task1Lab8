using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
            string path = "C:\\DOS";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкатологи:");
                string[] dirs = Directory.GetDirectories(path, searchPattern: ".", SearchOption.AllDirectories);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(path, searchPattern: ".", SearchOption.AllDirectories);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
