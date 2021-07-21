public class TaxiStationServise
{
    public int GetTheCostOfTheTaxiCompany(TaxiStation taxiStation)
    {
        var cost = 0;

        foreach (var car in taxiStation.Cars)
        {
            cost += car.Cost.Value;
        }

        return cost;
    }
}