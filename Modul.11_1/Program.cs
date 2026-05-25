using Modul._11_1;

Screen sc1 = new Screen(0, 0);

int xPos = sc1.X;

int xpos = sc1.OkuX();

sc1.YazX(xpos + 10);

sc1.X += 10;

Screen2 sc2 = new Screen2(0, 0);

Console.WriteLine(sc2.X);

sc2.X = 200;

sc2.X += 10;

Console.ReadKey();
