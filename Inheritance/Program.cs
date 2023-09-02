
using Inheritance;


Car car = new Car();

Corolla myCar = new Corolla();

// Phone phone = new SmartPhone();

List<Phone> phones = new List<Phone>();

phones.Add(new CellPhone());

phones.Add(new SmartPhone());

foreach (var phone in phones)
{
    if (phone is CellPhone cell)
    {
        cell.Carrier = "";
    }

    if (phone is SmartPhone smartphone)
    {
        smartphone.ConnectToInternet();
    }
}

Console.ReadLine();