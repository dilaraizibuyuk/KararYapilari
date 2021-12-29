using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrencinin notunu giriniz:");
            string not = Console.ReadLine();
            int not1 = Convert.ToInt32(not);

            //int not = 65;
            if (not1 > 45)
            {
                Console.WriteLine("öğrenci başarılı olmuştur.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("öğrenci başarısız olmuştur.");
                Console.ReadLine();

            }
        }
    }
}
