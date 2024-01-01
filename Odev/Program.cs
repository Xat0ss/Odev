using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sayı Bilme Oyununa Hoş Geldiniz!");

        Console.WriteLine("Zorluk seviyesini seçin: 1-Kolay 2-Orta 3-Zor");
        int zorlukSeviyesi = Convert.ToInt32(Console.ReadLine());

        int min, max;

        switch (zorlukSeviyesi)
        {
            case 1:
                min = 1;
                max = 10;
                break;
            case 2:
                min = 1;
                max = 50;
                break;
            case 3:
                min = 1;
                max = 100;
                break;
            default:
                Console.WriteLine("Geçersiz zorluk seviyesi. Varsayılan olarak orta seviye seçili.");
                min = 1;
                max = 50;
                break;
        }

        int dogruCevap = new Random().Next(min, max + 1);
        int puan = 0;

        while (true)
        {
            Console.WriteLine($"Tahminin ({min}-{max}): ");
            int tahmin;

            while (!int.TryParse(Console.ReadLine(), out tahmin) || tahmin < min || tahmin > max)
            {
                Console.WriteLine($"Kör müsün? Lütfen {min}-{max} arasında bir sayı gir.");
            }

            if (tahmin == dogruCevap)
            {
                puan += 100;
                Console.WriteLine($"Tebrikler! Doğru tahmin. Puanınız: {puan}");
                break;
            }
            else
            {
                puan -= 3;
                Console.WriteLine($"Yanlış tahmin. Puanınız: {puan}");
            }
        }
    }
}
