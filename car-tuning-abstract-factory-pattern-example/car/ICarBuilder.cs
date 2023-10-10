using car_tuning_abstract_factory_pattern_example.tuning_company;

namespace car_tuning_abstract_factory_pattern_example.car;

public interface ICarBuilder
{
    Car Make(string make);
    Car Model(string model);
    Car Year(int year);
    Car TuningCompany(ITuningCompany tuningCompany);
    
    public static Car BuildCar() { return new Car(); }
}