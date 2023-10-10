namespace car_tuning_abstract_factory_pattern_example.rear_wing;

public class DefaultRearWing : IRearWing
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Default Rear Wing\n";
        return desc;
    }
}