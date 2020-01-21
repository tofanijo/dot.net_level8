using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD1_unitTest_
{
    public class Program
    {
        public static string ApverstiSakini(string sakynis)
        {
            string rezultatas = "";

            for (int i = sakynis.Length - 1; i >= 0; i--)
            {
                rezultatas = rezultatas + sakynis[i].ToString();
            }
            return rezultatas;
        }

        static void Main(string[] args)
        {
            //Sukurti funkciją kuri
            //apverčia stringą ir parašyti
            //jai testus su ilgu stringu, su
            //stringu iš 1 simbolio, su
            //tuščiu stringu

            Console.WriteLine("Iveskite sakyni");
            string sakynis = Console.ReadLine();
            string rezultatas = ApverstiSakini(sakynis);
            Console.Write(rezultatas);
            Console.ReadLine();

        }

    }
}
