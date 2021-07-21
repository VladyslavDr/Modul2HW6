public class BMWCarModel : LuxuryCarModel
{
    public ClassOfCar ClassOfCar => ClassOfCar.Business;
    public BMWModel Model { get; set; }
}
