int[] sayi = { 1, 2, 3, 3 };
int toplam = 0;

foreach (int i in sayi)
{
    toplam = toplam + i;
}

Console.WriteLine("Toplam:" + toplam);
Console.WriteLine("\nKapatmak için bir tuşa basınız.");
Console.ReadKey();