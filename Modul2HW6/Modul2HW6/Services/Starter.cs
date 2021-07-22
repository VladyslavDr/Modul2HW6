using System;

public class Starter
{
    public static void Run()
    {
        var myTaxyStation = new TaxiStation().Cars;
        myTaxyStation = new CarProvider().GetCars();

        var cost = new TaxiStationServise().GetTheCostOfTheTaxiCompany(myTaxyStation);

        foreach (var car in myTaxyStation)
        {
            Console.WriteLine($"car: {car}, fuel consumption: {car.FuelConsumption.Value}, cost: {car.Cost.Value}");
        }

        var sortCars = new TaxiStationServise().ArraySort(myTaxyStation);

        Console.WriteLine();

        foreach (var car in sortCars)
        {
            Console.WriteLine($"car: {car}, fuel consumption: {car.FuelConsumption.Value}, cost: {car.Cost.Value}");
        }

        Console.WriteLine();

        var carWithFuelConsumption = new TaxiStationServise().GetCar(myTaxyStation, new FuelConsumption { Value = 8.8 });

        Console.WriteLine($"carWithFuelConsumption 8.8: {carWithFuelConsumption}");

        Console.WriteLine();

        Console.WriteLine($"total cost of the car = {cost}");
    }
}
