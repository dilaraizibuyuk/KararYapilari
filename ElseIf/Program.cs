using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIf
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //öğrencinin 3 notunun ortalamasını alan ve öğrencinin notunu yazdıran program 
            //şartlar 85-100 A+, 65-85 A, 45-65 B+, not<45 F.

            Console.WriteLine("Lütfen 1. notu giriniz:");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. notu giriniz:");
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 3. notu giriniz:");
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());
            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

            if (sonuc>=85 && sonuc<=100)
            {
                Console.WriteLine("Not Değeri: A+");
            }

            else if(sonuc>=65 && sonuc<85){

                Console.WriteLine("Not Değeri: A");

            }
            else if(sonuc >= 45 && sonuc <65){

                Console.WriteLine("Not Değeri: B+");

            }
            else
                Console.WriteLine("Not Değeri: F");
            Console.ReadLine();
            

        }
    }
}

