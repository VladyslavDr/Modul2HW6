using System;

public class TaxiStationServise : ITaxiStationServise
{
    public int GetTheCostOfTheTaxiCompany(CarModel[] taxiStation)
    {
        var cost = 0;

        foreach (var car in taxiStation)
        {
            cost += car.Cost.Value;
        }

        return cost;
    }

    public CarModel[] ArraySort(CarModel[] cars)
    {
        Array.Sort(cars, new CarComparer());

        return cars;
    }
}