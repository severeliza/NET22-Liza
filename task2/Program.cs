using task2;

IJob[] сolleagues = { new Director(), new Worker(), new Accountant()};

foreach (IJob colleague in сolleagues)
{
    colleague.PrintPosition();
}