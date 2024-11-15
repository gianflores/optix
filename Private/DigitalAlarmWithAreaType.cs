using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "FeaturesDemo2", Guid = "cef85446637f96f78a635cae805a1266")]
public class DigitalAlarmWithAreaType : FTOptix.Alarm.DigitalAlarm
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public string Area
    {
        get
        {
            return (string)Refs.GetVariable("Area").Value.Value;
        }
        set
        {
            Refs.GetVariable("Area").SetValue(value);
        }
    }
    public IUAVariable AreaVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Area");
        }
    }
#endregion
}
