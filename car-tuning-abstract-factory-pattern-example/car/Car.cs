using car_tuning_abstract_factory_pattern_example.front_diffuser;
using car_tuning_abstract_factory_pattern_example.rear_diffuser;
using car_tuning_abstract_factory_pattern_example.rear_wing;
using car_tuning_abstract_factory_pattern_example.side_skirts;
using car_tuning_abstract_factory_pattern_example.tuning_company;

namespace car_tuning_abstract_factory_pattern_example.car;

public class Car : ICarBuilder
{
    private string _make;
    private string _model;
    private int _year;
    private ITuningCompany _tuningCompany;
    
    // Modifications
    private IFrontDiffuser _frontDiffuser;
    private IRearDiffuser _rearDiffuser;
    private IRearWing _rearWing;
    private ISideSkirts _sideSkirts;

    // Constructors
    
    public Car()
    {
        _make = "none";
        _model = "none";
        _year = -1;
        _tuningCompany = null!;
    }
    
    #region ACCESSORS

    public string GetMake() { return _make; }
    public string GetModel(){ return _model; }
    public int GetYear() { return _year; }
    public ITuningCompany GetTuningCompany() { return _tuningCompany; }
    public void SetMake(string make) { _make = make; }
    public void SetModel(string model){ _model = model; }
    public void SetYear(int year) { _year = year; }
    public void SetTuningCompany(ITuningCompany tuningCompany) { _tuningCompany = tuningCompany; }

    public void SetFrontDiffuser(IFrontDiffuser frontDiffuser)
    {
        _frontDiffuser = frontDiffuser;
    }

    public void SetRearDiffuser(IRearDiffuser rearDiffuser)
    {
        _rearDiffuser = rearDiffuser;
    }

    public void SetRearWing(IRearWing rearWing)
    {
        _rearWing = rearWing;
    }

    public void SetSideSkirts(ISideSkirts sideSkirts)
    {
        _sideSkirts = sideSkirts;
    }
    
    #endregion
    
    #region BUILDER
    
    public Car Make(string make)
    {
        _make = make;
        return this;
    }

    public Car Model(string model)
    {
        _model = model;
        return this;
    }

    public Car Year(int year)
    {
        _year = year;
        return this;
    }

    public Car TuningCompany(ITuningCompany tuningCompany)
    {
        _tuningCompany = tuningCompany;
        return this;
    }
    
    #endregion

    #region PUBLIC_METHODS

    public override string ToString()
    {
        string desc = "";
        desc += $"Make : {_make}\n";
        desc += $"Model : {_model}\n";
        desc += $"Year : {_year}\n";
        desc += "\nParts:\n";
        desc += _frontDiffuser.ToString();
        desc += _rearDiffuser.ToString();
        desc += _rearWing.ToString();
        desc += _sideSkirts.ToString();
        return desc;
    }

    public void ApplyTuning()
    {
        _tuningCompany.InstallFrontDiffuser(this);
        _tuningCompany.InstallRearDiffuser(this);
        _tuningCompany.InstallRearWing(this);
        _tuningCompany.InstallSideSkirts(this);
    }
    
    #endregion
}