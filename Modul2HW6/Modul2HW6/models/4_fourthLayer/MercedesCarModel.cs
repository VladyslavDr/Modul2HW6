public class MercedesCarModel : LuxuryCarModel
{
    public ClassOfCar ClassOfCar => ClassOfCar.Business;
    public MercedesModel Model { get; set; }
}
