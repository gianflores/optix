using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "FeaturesDemo2", Guid = "62a7d50dcafe522c0b99cef3634b79a0")]
public class MotorWithBehavior : UAObject
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
#endregion
}
