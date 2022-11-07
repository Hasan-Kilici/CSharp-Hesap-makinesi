using System;

    class Program
    {
        static void Main(string[] args)
        {
            int sayi1_giris, sayi2_giris;

            double sonuc;

            int islem;

            Console.WriteLine("Bir sayı girin:");
            sayi1_giris = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("İkinci sayıyı girin:");
            sayi2_giris = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("İşlem seçin(1 [Çarpma],2 [Bölme] ,3 [Topama], 4 [Çıkarma])");
            islem = Convert.ToInt32(Console.ReadLine());

          switch(islem){
          case 1:
          sonuc = sayi1_giris * sayi2_giris;
          Console.WriteLine("Sonuç: " + sonuc);
          break;  
          case 2:
          sonuc = sayi1_giris / sayi2_giris;
          Console.WriteLine("Sonuç: " + sonuc);
          break;  
          case 3:
          sonuc = sayi1_giris + sayi2_giris;
          Console.WriteLine("Sonuç: " + sonuc);
          break;  
          case 4:
          sonuc = sayi1_giris - sayi2_giris;
          Console.WriteLine("Sonuç: " + sonuc);
          break;  
        }
     }
  }
