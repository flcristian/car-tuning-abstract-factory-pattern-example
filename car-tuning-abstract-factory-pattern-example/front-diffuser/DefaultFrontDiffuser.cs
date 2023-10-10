using car_tuning_abstract_factory_pattern_example.rear_diffuser;

namespace car_tuning_abstract_factory_pattern_example.front_diffuser;

public class DefaultFrontDiffuser : IFrontDiffuser
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Default Front Diffuser\n";
        return desc;
    }
}