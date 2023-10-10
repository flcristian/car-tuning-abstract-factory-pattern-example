using car_tuning_abstract_factory_pattern_example.car;

namespace car_tuning_abstract_factory_pattern_example.tuning_company;

public interface ITuningCompany
{
    void InstallFrontDiffuser(Car car);
    void InstallRearDiffuser(Car car);
    void InstallSideSkirts(Car car);
    void InstallRearWing(Car car);
}