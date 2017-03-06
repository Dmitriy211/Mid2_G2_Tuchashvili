using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mid2_G2_Tuchashvili
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Path:");
            string path = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("X:");
            string x = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(path);

            for (int i = 0; i < dir.GetFiles().Length; i++)
            {
                string t = File.ReadAllText(dir.GetFiles()[i].FullName);

                bool b = t.Contains(x);
                
                if (b==true)
                    Console.WriteLine(dir.GetFiles()[i].Name);


            /*    if (t == x)
                    Console.WriteLine(dir.GetFiles()[i].Name);*/
            }
        }
    }
}
