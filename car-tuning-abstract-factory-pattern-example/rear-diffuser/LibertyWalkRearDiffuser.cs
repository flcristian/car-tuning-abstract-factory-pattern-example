namespace car_tuning_abstract_factory_pattern_example.rear_diffuser;

public class LibertyWalkRearDiffuser : IRearDiffuser
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Liberty Walk Rear Diffuser\n";
        return desc;
    }
} 