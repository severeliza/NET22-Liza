using task3;

IDocument[] docs =
{
    new SupplyOfGoods(),
    new SupplyOfGoods(123, new DateOnly(1,1,5), SupplyType.Orange, 5),
    new EmployeeContract(256),
    new EmployeeContract(267, new DateOnly(2025,12,5), new DateOnly(2020,10,5), new DateOnly(2025,12,30), "Mikel"),
    new FinancialInvoice(36548, new DateOnly(), 52461, 2)
};

Register register = new Register();

foreach (var doc in docs)
{
    register.SaveDocument(doc);
}

register.PrintAll();