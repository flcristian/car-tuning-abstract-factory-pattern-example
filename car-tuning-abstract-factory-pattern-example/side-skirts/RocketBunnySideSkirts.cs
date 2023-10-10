namespace car_tuning_abstract_factory_pattern_example.side_skirts;

public class RocketBunnySideSkirts : ISideSkirts
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Rocket Bunny Side Skirts\n";
        return desc;
    }
}