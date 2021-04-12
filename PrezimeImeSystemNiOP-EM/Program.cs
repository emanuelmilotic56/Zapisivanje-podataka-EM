using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrezimeImeSystemNiOP_EM
{
    class Program
    {
        static void Main(string[] args)
        {
            string zapis = "";
            string path = @"D:\Documents\TestNiop.csv ";

            Console.Write("Upisi ime: ");

            Ime = Convert.ToString(Console.ReadLine()) + System.Environment.NewLine;
            Console.Write("Upiši Prezime: ");

            Prezime = Console.ReadLine() + System.Environment.NewLine;
            Console.Write("Upisi email: ");
            Email = Console.ReadLine() + System.Environment.NewLine;

            Console.Write("Upisi godinu rodjenja ");
            GodRodjenja = Console.ReadLine() + System.Environment.NewLine;



        }
    }
}
