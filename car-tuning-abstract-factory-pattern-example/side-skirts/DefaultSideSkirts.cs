namespace car_tuning_abstract_factory_pattern_example.side_skirts;

public class DefaultSideSkirts : ISideSkirts
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Default Side Skirts\n";
        return desc;
    }
}