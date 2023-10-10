using car_tuning_abstract_factory_pattern_example.car;

namespace car_tuning_abstract_factory_pattern_example.front_diffuser;

public class LibertyWalkFrontDiffuser : IFrontDiffuser
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Liberty Walk Front Diffuser\n";
        return desc;
    }
}