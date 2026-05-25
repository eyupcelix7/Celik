using System.Data.Linq;
using System.Linq;
using Modul._10_1;

string baglanti = "Server=localhost;Database=TestDB;Trusted_Connection=True;";

try
{
    DataContext context =
        new DataContext(baglanti);

    Table<Customer> Customers =
        context.GetTable<Customer>();

    var q =
        from c in Customers
        where c.City == "Ağrı"
        select c;

    Console.WriteLine("Ağrılı Müşteriler: \n");

    foreach (var item in q)
    {
        Console.WriteLine("Adres  : " + item.Address);
        Console.WriteLine("Telefon: " + item.Phone);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();
