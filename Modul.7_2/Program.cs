using System.Collections;

ArrayList sayilar = new();

int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < 10; i++)
{
    sayilar.Add(num[i]);
}
sayilar.RemoveAt(2);

sayilar.Insert(5, 2345);

for (int i = 0; i < sayilar.Count; i++)
{
    Console.WriteLine(sayilar[i]);
}
Console.ReadKey();
