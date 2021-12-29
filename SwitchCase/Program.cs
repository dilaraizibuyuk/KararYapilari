using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATM UYGULAMA
            //1. BAKİYE GÖRÜNTÜLE
            //2. PARA ÇEK
            //3. PARA YATIR
            //4. ÇIKIŞ YAP
            //1-2-3-4 DIŞI BİR TUŞA BASTIYSA HATA VERSİN

            int bakiye = 1000;
            Console.WriteLine("ATM'YE HOŞGELDİNİZ");
            Console.WriteLine("LÜTFEN BİR İŞLEM SEÇİNİZ");
            Console.WriteLine("1. BAKİYE GÖRÜNTÜLE");
            Console.WriteLine("2. PARA ÇEK");
            Console.WriteLine("3. PARA YATIR");
            Console.WriteLine("4. ÇIKIŞ YAP");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("bakiyeniz: {0}", +bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Çekmek istediğiniz para tutarını giriniz:");
                    int tutar=Convert.ToInt32(Console.ReadLine());
                    if (tutar>bakiye)
                    {
                        Console.WriteLine("Bakiyeniz yetersizdir..");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz:" +(bakiye-tutar));
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Yatırmak istediğiniz para miktarını giriniz:");
                    int para_tutari = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("yeni para tutarınız:" + (bakiye + para_tutari));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Hesabınızdan çıkış işlemi yapılıyor.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir işlem seçiniz");
                    Console.ReadLine();
                    break;
            }


        }
    }
}
