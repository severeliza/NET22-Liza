using hw7;

Console.OutputEncoding = System.Text.Encoding.UTF8;

CreditCard[] creditCards = {
new CreditCard(1111111111111, 10.2),
new CreditCard(1111111111111, 10.2),
new CreditCard(3333333333333, 0)
};

try
{
    CreditCard card4 = new CreditCard(333333333333, 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

creditCards[0].Deposit(1000);
creditCards[1].Deposit(200);
creditCards[2].WithdrawFromCard(10);
creditCards[0].WithdrawFromCard(10);

foreach(CreditCard creditCard in creditCards)
{
    creditCard.Info();
}

