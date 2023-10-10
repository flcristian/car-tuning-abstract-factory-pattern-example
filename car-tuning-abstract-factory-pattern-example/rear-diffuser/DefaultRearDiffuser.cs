namespace car_tuning_abstract_factory_pattern_example.rear_diffuser;

public class DefaultRearDiffuser : IRearDiffuser
{
    public void Display()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        String desc = "";
        desc += "Default Rear Diffuser\n";
        return desc;
    }
}