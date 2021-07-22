public class ExecuteCarModel : TraditionalCarModel
{
    public override int NumberOfChildSeats => 1;
    public override bool IsThereAnAirConditioner => true;
    public override bool IsThereInternet => false;
}