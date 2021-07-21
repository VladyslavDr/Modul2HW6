public class CarProvider : ICarProvider
{
    public CarModel[] GetCars()
    {
        return new CarModel[]
        {
            new BMWCarModel
            {
                Model = BMWModel.X7,

                FuelConsumption = new FuelConsumption
                {
                    Value = 7.8,
                    FuelConsumptionUnit = FuelConsumptionUnit.L_100Km
                },

                Capacity = 5,

                Cost = new Cost
                {
                    Value = 74900,
                    Currency = Currency.USD
                },
            },

            new MercedesCarModel
            {
                Model = MercedesModel.E220,

                FuelConsumption = new FuelConsumption
                {
                    Value = 8.8,
                    FuelConsumptionUnit = FuelConsumptionUnit.L_100Km
                },

                Capacity = 4,

                Cost = new Cost
                {
                    Value = 85600,
                    Currency = Currency.USD
                }
            },

            new ChevroletCarModel
            {
                Model = СhevroletModel.Aveo,

                FuelConsumption = new FuelConsumption
                {
                    Value = 6.8,
                    FuelConsumptionUnit = FuelConsumptionUnit.L_100Km
                },

                Capacity = 4,

                Cost = new Cost
                {
                    Value = 30000,
                    Currency = Currency.USD
                }
            },

            new KiaCarModel
            {
                Model = KiaModel.Optima,

                FuelConsumption = new FuelConsumption
                {
                    Value = 7.3,
                    FuelConsumptionUnit = FuelConsumptionUnit.L_100Km
                },

                Capacity = 5,

                Cost = new Cost
                {
                    Value = 45050,
                    Currency = Currency.USD
                }
            },

            new ToyotaCarModel
            {
                Model = ToyotaModel.Camry,

                FuelConsumption = new FuelConsumption
                {
                    Value = 7.1,
                    FuelConsumptionUnit = FuelConsumptionUnit.L_100Km
                },

                Capacity = 5,

                Cost = new Cost
                {
                    Value = 32500,
                    Currency = Currency.USD
                }
            },

            new MercedesCarModel
            {
                Model = MercedesModel.GLS450,

                FuelConsumption = new FuelConsumption
                {
                    Value = 7.8,
                    FuelConsumptionUnit = FuelConsumptionUnit.L_100Km
                },

                Capacity = 5,

                Cost = new Cost
                {
                    Value = 89950,
                    Currency = Currency.USD
                }
            }
        };
    }
}