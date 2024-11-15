using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "FeaturesDemo2", Guid = "7a72d14bf62ef6760f7b98497372717c")]
public class CustomUISession : FTOptix.UI.UISession
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int LastTabIndex
    {
        get
        {
            return (int)Refs.GetVariable("LastTabIndex").Value.Value;
        }
        set
        {
            Refs.GetVariable("LastTabIndex").SetValue(value);
        }
    }
    public IUAVariable LastTabIndexVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("LastTabIndex");
        }
    }
#endregion
}
