public static class CarExtension
{
    public static CarModel GetCarByFuelConsumption(this CarModel[] cars, FuelConsumption fuelConsumption)
    {
        var myCar = new CarModel();

        foreach (var car in cars)
        {
            if (car.FuelConsumption.Value == fuelConsumption.Value)
            {
                myCar = car;
            }
        }

        return myCar;
    }
}
