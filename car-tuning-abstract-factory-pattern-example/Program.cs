using car_tuning_abstract_factory_pattern_example.car;
using car_tuning_abstract_factory_pattern_example.tuning_company;

internal class Program
{
    public static void Main(string[] args)
    {
        Car car = ICarBuilder.BuildCar()
            .Make("Subaru")
            .Model("WRX STI")
            .Year(2018);
        car.SetTuningCompany(new LibertyWalkTuningCompany());
        car.ApplyTuning();
        Console.WriteLine(car);
    }
}