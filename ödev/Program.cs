namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kaç tane öğrenci kaydetmek istiyorsunuz:");
                int ogrencisayi = int.Parse(Console.ReadLine());


                string[,] bilgiler = new string[ogrencisayi, 7];
                double[] notlar = new double[ogrencisayi];

                double sortalama = 0, yükseknot = double.MinValue, düşüknot = double.MaxValue;

                for (int i = 0; i < ogrencisayi; i++)
                {
                    Console.Write($"{i + 1}. Öğrenci Numarası:");
                    long ogrencinumara = long.Parse(Console.ReadLine());

                    Console.Write($"{i + 1}. Öğrenci Adı:");
                    string ogrenciadı = Console.ReadLine();

                    Console.Write($"{i + 1}. Öğrenci Soyadı:");
                    string ogrencisoyad = Console.ReadLine();


                    Console.Write($"{i + 1}. Vize Notu:");
                    double vizenotu = double.Parse(Console.ReadLine());
                   while (true)
{
    if (vizenotu <= 0 || vizenotu >= 100)
    {
        Console.WriteLine("Sadece 0 ile 100 arası sayıları kullanın.");
    }
    else
    {
        vizenotu = double.Parse(Console.ReadLine());

        break;
    }
}





                    Console.Write($"{i + 1}. Final Notu:");
                    double finalnotu = double.Parse(Console.ReadLine());
                   while (true)
{
    if (finalnotu <= 0 || finalnotu >= 100)
    {
        Console.WriteLine("Sadece 0 ile 100 arası sayıları kullanın.");
    }
    else
    {
        finalnotu = double.Parse(Console.ReadLine());
        break;
    }
}


                    double ortalama = vizenotu * 0.4 + finalnotu * 0.6;
                    string harfnotu = HarfNotuHesapla(ortalama);

                    bilgiler[i, 0] = ogrencinumara.ToString();
                    bilgiler[i, 1] = ogrenciadı;
                    bilgiler[i, 2] = ogrencisoyad;
                    bilgiler[i, 3] = vizenotu.ToString("F2");
                    bilgiler[i, 4] = finalnotu.ToString("F2");
                    bilgiler[i, 5] = ortalama.ToString("F2");
                    bilgiler[i, 6] = harfnotu;

                    notlar[i] = ortalama;

                    sortalama += ortalama;
                    yükseknot = Math.Max(yükseknot, ortalama);
                    düşüknot = Math.Min(düşüknot, ortalama);


                }
                Console.WriteLine($"{"Numarası",-15} {"Adı",-10} {"Soyadı",-10} {"Vize Notu",-15} {"Final Notu",-15} {"Ortalama",-15} {"Harf Notu",-15} ");
                Console.WriteLine(new string('-', 100));

                for (int i = 0; i < ogrencisayi; i++)
                {
                    Console.WriteLine($"{bilgiler[i, 0],-15} {bilgiler[i, 1],-10} {bilgiler[i, 2],-10} {bilgiler[i, 3],-15} {bilgiler[i, 4],-15} {bilgiler[i, 5],-15}  {bilgiler[i, 6],-15} ");
                }

                double ortalamas = sortalama / ogrencisayi;
                Console.WriteLine($"\n SINIF ORTALAMASI :{ortalamas:F2}");
                Console.WriteLine($"\n  EN DÜŞÜK NOT :{düşüknot:F2}");
                Console.WriteLine($"\n  EN YÜKSEK NOT :{yükseknot:F2}");
                string HarfNotuHesapla(double ortalama)
                {
                    if (ortalama >= 85) return "AA";
                    if (ortalama >= 75) return "BA";
                    if (ortalama >= 60) return "BB";
                    if (ortalama >= 50) return "CB";
                    if (ortalama >= 40) return "CC";
                    if (ortalama >= 30) return "DC";
                    if (ortalama >= 20) return "DD";
                    if (ortalama >= 10) return "FD";
                    return "FF";



                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Bir hata oluştu...");
                Console.WriteLine($"Hata mesajı: {ex.Message}\n Tarih: {DateTime.Now} \n Detaylı hata mesajı :{ex.StackTrace} ");
            }
        }
    }
}
