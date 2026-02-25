using ConsoleApp2;

ComparablePair<int, string> AB = new ComparablePair<int, string>(1, "Lena");
ComparablePair<int, string> CD = new ComparablePair<int, string>(1, "Gena");
ComparablePair<int, string> EF = new ComparablePair<int, string>(2, "Liza");

ComparablePair<int, string>[] pairs = { AB, CD, EF};
Array.Sort(pairs);

foreach (ComparablePair<int, string> p in pairs)
{
    Console.WriteLine(p);
}
