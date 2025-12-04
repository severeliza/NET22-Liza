using TestOOP;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Car sport = new SportsCar(0);

Console.WriteLine("Заправили до 10 литров " + sport.Refuel(10));

Console.WriteLine("Через 5 км машина движется? ");
sport.Drive(5);





