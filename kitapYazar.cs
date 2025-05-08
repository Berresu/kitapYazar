using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sınavCalismaSorusu_1_
{
    internal class Program
    {
        public class Kitap
        {
            public string Baslik { get; set; }
            public Yazar Yazar { get; set; }

            public Kitap(string baslik) 
            {
                Baslik = baslik;
            }

            public void yazarAta(Yazar yazar)
            {
                Yazar = yazar;
            }

            public void kitapBilgileriniGoster()
            {
                Console.WriteLine($"Kitap Adı: {Baslik}");
                if (Yazar != null)
                {
                    Console.WriteLine($"Yazar: {Yazar.Ad}");
                }
                else
                {
                    Console.WriteLine("Yazar Bilgisi Bulunmamaktadır.");
                }
            }
        }

        public class Yazar
        {
            public string Ad { get; set; }
            public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();

            public Yazar (string ad)
            {
                this.Ad = ad;
            }

            public void kitapEkle(Kitap kitap)
            {
                Kitaplar.Add(kitap);
                kitap.yazarAta(this);
            }

            public void yazarınKitaplariniGoster() 
            {
                Console.WriteLine($"{Ad}'ın Yazdığı Kitaplar:");
                foreach(var kitap in Kitaplar)
                {
                    Console.WriteLine($"- {kitap.Baslik}");
                }
            }
        }

        public class AssociationOrnek
        {
            public static void Main(string[] args)
            {
                Yazar yazar1 = new Yazar("Suzanne Collins");
                Kitap kitap1 = new Kitap("Açlık Oyunları");
                Kitap kitap2 = new Kitap("Ateşi Yakalamak");
                Kitap kitap3 = new Kitap("Alaycı Kuş");
                Kitap kitap4 = new Kitap("Kuşların ve Yılanların Şarkısı");
                Kitap kitap5 = new Kitap("Hasatta Gündoğumu");

                yazar1.kitapEkle(kitap1);
                yazar1.kitapEkle(kitap2);
                yazar1.kitapEkle(kitap3);
                yazar1.kitapEkle(kitap4);
                yazar1.kitapEkle(kitap5);

                kitap1.kitapBilgileriniGoster();
                kitap2.kitapBilgileriniGoster();
                kitap3.kitapBilgileriniGoster();
                kitap4.kitapBilgileriniGoster();
                kitap5.kitapBilgileriniGoster();
            }
        }
    }
}
