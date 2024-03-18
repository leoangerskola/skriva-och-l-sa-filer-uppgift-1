using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skriva_och_läsa_filer_uppgift_1
{
    internal class Program
    {

        static int avarage(int a, int b) 
        {
            return (a + b)/2;
        
        }
        static string write()
        {
            string row = null;
            string Out = null;
            using (StreamReader sr = new StreamReader("resultat.txt")) //
            {
                while (!sr.EndOfStream)
                {
                    row = sr.ReadLine();
                    string[] split = row.Split(' ');
                    string name = split[0];
                    int test1 = int.Parse(split[1]);
                    int test2 = int.Parse(split[2]);
                    row += $" totalpoäng: {test1 + test1}    medelvärde: {avarage(test1,test2)} \n";
                }
                return row;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(write());

            Console.ReadKey();
        }
    }
}
