using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "FeaturesDemo2", Guid = "23aa64d100d55501dca100bac3541b8c")]
public class FeaturesNavigationScreen : FTOptix.UI.Screen
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public FTOptix.UI.NavigationPanel NavigationPanel
    {
        get
        {
            return (FTOptix.UI.NavigationPanel)Refs.GetObject("NavigationPanel");
        }
    }
    public FTOptix.NetLogic.NetLogicObject CheckFavoriteTab
    {
        get
        {
            return (FTOptix.NetLogic.NetLogicObject)Refs.GetObject("CheckFavoriteTab");
        }
    }
#endregion
}
