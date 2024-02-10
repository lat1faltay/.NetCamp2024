using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelamVer("Latif");
            SelamVer("Ali");
            SelamVer("Ayşe");
            SelamVer();

            int sonuc = Topla(5, 58);


            string ogrenci1 = "Latif";
            string ogrenci2 = "Ahmet";
            string ogrenci3 = "Mehmet";


            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            // Diziler / Arrays
            Console.WriteLine();
            Console.WriteLine("Array");
            Console.WriteLine();

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Latif";
            ogrenciler[1] = "Ahmet";
            ogrenciler[2] = "Mehmet";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "İstanbul", "Ankara", "İzmir" };
            string[] sehirler2 = new[] { "Sakarya", "Antalya", "Bursa" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;


            Person person1 = new Person();
            person1.FirstName = "Murat";

            Person person2 = new Person();
            person1.FirstName = "Teoman";


            foreach (string sehir in sehirler2) 
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yeniSehirler1.Add("İzmit");

            foreach (string yeniSehir in yeniSehirler1) 
            {
                Console.WriteLine(yeniSehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz") 
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2= 10) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
    }
}
