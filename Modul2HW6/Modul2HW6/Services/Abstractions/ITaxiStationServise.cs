public interface ITaxiStationServise
{
    public int GetTheCostOfTheTaxiCompany(CarModel[] taxiStation);
    public CarModel[] ArraySort(CarModel[] cars);
    public CarModel GetCar(CarModel[] cars, FuelConsumption fuelConsumption);
}