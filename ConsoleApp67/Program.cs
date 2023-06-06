using ConsoleApp67;
using System.Net.Http.Headers;

Parking[] cars = new Parking[10];

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

