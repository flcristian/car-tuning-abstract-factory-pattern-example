namespace car_tuning_abstract_factory_pattern_example.front_diffuser;

public class RocketBunnyFrontDiffuser : IFrontDiffuser
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Rocket Bunny Front Diffuser\n";
        return desc;
    }
}