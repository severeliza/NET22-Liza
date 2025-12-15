using hw6;

Phone[] phones =
{
    new Phone("132456789", "Xiaomi Redmi Node 123"),
    new Phone("132456788", "Iphone 13 mini"),
    new Phone("132456790", "Honor 400")
};

Console.WriteLine("Phones:");

foreach (Phone phone in phones)
{
    string weightInfo = phone.Weight > 0 ? phone.Weight.ToString(): "weight is not specified";
    Console.WriteLine($"{phone.GetNumber()}, {phone.Model}, {weightInfo}");
}

foreach (Phone phone in phones)
{
    phone.ReceiveCall("Anna Maria");
    phone.ReceiveCall("Anna Maria", "4659156");
    phone.SendMessage("132456790", "132456788", "132456789");
}



