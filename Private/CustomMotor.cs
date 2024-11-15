using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "FeaturesDemo2", Guid = "3e8c8082a2418fafb151a5266d3eb6ea")]
public class CustomMotor : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public bool Running
    {
        get
        {
            return (bool)Refs.GetVariable("Running").Value.Value;
        }
        set
        {
            Refs.GetVariable("Running").SetValue(value);
        }
    }
    public IUAVariable RunningVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Running");
        }
    }
    public bool Mode
    {
        get
        {
            return (bool)Refs.GetVariable("Mode").Value.Value;
        }
        set
        {
            Refs.GetVariable("Mode").SetValue(value);
        }
    }
    public IUAVariable ModeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Mode");
        }
    }
#endregion
}
