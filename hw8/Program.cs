
using hw8;

Figure[] figures = {
    new Triangle([1,5,6,2.4,0,5]),
    new Triangle([new Point(), new Point(5,1.0), new Point(15,31.5)]),
    new Rectangle(),
    new Сircle(),
    new Сircle(new Point(), 5)
};

double sumPerimeters = 0;

for (int i = 0; i < figures.Length; i++)
{
    sumPerimeters += figures[0].GetPerimeter();
}

Console.WriteLine(sumPerimeters);