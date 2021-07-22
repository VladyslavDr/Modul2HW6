using System;
using System.Collections.Generic;

public class CarComparer : IComparer<CarModel>
{
    public int Compare(CarModel car1, CarModel car2)
    {
        if (car1.FuelConsumption.Value > car2.FuelConsumption.Value)
        {
            return 1;
        }
        else if (car1.FuelConsumption.Value < car2.FuelConsumption.Value)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}