using car_tuning_abstract_factory_pattern_example.car;
using car_tuning_abstract_factory_pattern_example.front_diffuser;
using car_tuning_abstract_factory_pattern_example.rear_diffuser;
using car_tuning_abstract_factory_pattern_example.rear_wing;
using car_tuning_abstract_factory_pattern_example.side_skirts;

namespace car_tuning_abstract_factory_pattern_example.tuning_company;

public class RocketBunnyTuningCompany : ITuningCompany
{
    public void InstallFrontDiffuser(Car car)
    {
        car.SetFrontDiffuser(new RocketBunnyFrontDiffuser());
    }

    public void InstallRearDiffuser(Car car)
    {
        car.SetRearDiffuser(new RocketBunnyRearDiffuser());
    }

    public void InstallSideSkirts(Car car)
    {
        car.SetSideSkirts(new RocketBunnySideSkirts());
    }

    public void InstallRearWing(Car car)
    {
        car.SetRearWing(new RocketBunnyRearWing());
    }
}