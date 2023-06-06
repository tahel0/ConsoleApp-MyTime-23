using ConsoleApp67;
using System.Net.Http.Headers;

Parking[] cars = new Parking[10];
//שאלה א
static void First(Parking[] cars)
{
    int firstCar = 0;
    for (int i = 1; i < cars.Length; i++)
    {
        if (cars[i].GetIn1().Before(cars[firstCar].GetIn1()))
        {
            firstCar = i;
        }
    }

    Console.WriteLine(cars[firstCar].GetId());
}

//שאלה ב.2
static int SumMoney(Parking[] cars)
{
    int sumMoney = 0;
    for (int i = 0; i < cars.Length; i++)
    {
        if (cars[i].total()>120)
        {
            sumMoney+=cars[i].total()-120;
        }
    }
    return sumMoney;
}