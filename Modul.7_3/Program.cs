static int toplam(params int[] paramList)
{
    int c = paramList[0];
    int d = paramList[0];

    foreach (int i in paramList)
    {
        if (i < c)
            c = i;
    }
    return c + d;
}
int toplami = toplam(9, 4, 5, 6, 19);
Console.WriteLine("En Küçük ve En Büyük Sayının Toplam: " + toplami);
Console.Read();
