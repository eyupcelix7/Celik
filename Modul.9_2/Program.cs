using Modul._9_2;

Sepet sepett = new Sepet();
sepett.UrunEklendi += new Sepet.SepetHandler(ToplamHesapla);

while (true)
{
    Urun yeniUrun = new Urun();
    Console.Write("Urun Adi: ");
    yeniUrun.Ad = Console.ReadLine();
    Console.Write("Fiyati: ");
    yeniUrun.Fiyat = Convert.ToDouble(Console.ReadLine());
    sepett.Ekle(yeniUrun);
    Console.WriteLine(" ");
}
void ToplamHesapla()
{
    Console.WriteLine("Toplam Tutar: " + sepett.ToplamTutar());
}
