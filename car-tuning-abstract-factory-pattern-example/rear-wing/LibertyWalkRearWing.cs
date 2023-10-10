namespace car_tuning_abstract_factory_pattern_example.rear_wing;

public class LibertyWalkRearWing : IRearWing
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Liberty Walk Rear Wing\n";
        return desc;
    }
}