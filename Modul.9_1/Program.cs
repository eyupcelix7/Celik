
public delegate void Handler(ref string[] dizi);

string[] isimler = { "Eyüp", "Ahmet", "Mehmed", "Çelik" };
Console.WriteLine("Sıralanmış: " + string.Join(", ", isimler));
Handler handler = new Handler(AlfabetikSirala);
handler(ref isimler);
Console.WriteLine(string.Join(", ", isimler));

handler = TersSirala;
handler(ref isimler);
Console.WriteLine(string.Join(", ", isimler));
Console.ReadKey();
static void AlfabetikSirala(ref string[] dizi)
{
    Array.Sort(dizi);
    Console.WriteLine("A-Z Siralandi.");
}
static void TersSirala(ref string[] dizi)
{
    Array.Sort(dizi);
    Array.Reverse(dizi);
    Console.WriteLine("Z-A Siralandi.");
}