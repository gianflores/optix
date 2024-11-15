using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "FeaturesDemo2", Guid = "01a7e8933afd7c95fe894b0859308138")]
public class MainWindow : FTOptix.UI.Window
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public FTOptix.UI.PanelLoader PanelLoader
    {
        get
        {
            return (FTOptix.UI.PanelLoader)Refs.GetObject("PanelLoader");
        }
    }
    public FTOptix.UI.Panel Header
    {
        get
        {
            return (FTOptix.UI.Panel)Refs.GetObject("Header");
        }
    }
    public FTOptix.UI.Rectangle OutherBackground
    {
        get
        {
            return (FTOptix.UI.Rectangle)Refs.GetObject("OutherBackground");
        }
    }
    public FTOptix.UI.Panel SideMenu
    {
        get
        {
            return (FTOptix.UI.Panel)Refs.GetObject("SideMenu");
        }
    }
    public bool ToggleMenu
    {
        get
        {
            return (bool)Refs.GetVariable("ToggleMenu").Value.Value;
        }
        set
        {
            Refs.GetVariable("ToggleMenu").SetValue(value);
        }
    }
    public IUAVariable ToggleMenuVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ToggleMenu");
        }
    }
    public UAManagedCore.NodeId CurrentStylesheet
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("CurrentStylesheet").Value.Value;
        }
        set
        {
            Refs.GetVariable("CurrentStylesheet").SetValue(value);
        }
    }
    public FTOptix.Core.Alias CurrentStylesheetVariable
    {
        get
        {
            return (FTOptix.Core.Alias)Refs.GetVariable("CurrentStylesheet");
        }
    }
    public FTOptix.UI.Panel HelpMenu
    {
        get
        {
            return (FTOptix.UI.Panel)Refs.GetObject("HelpMenu");
        }
    }
    public FTOptix.NetLogic.NetLogicObject GetCurrentStylesheet
    {
        get
        {
            return (FTOptix.NetLogic.NetLogicObject)Refs.GetObject("GetCurrentStylesheet");
        }
    }
    public bool ToggleHelp
    {
        get
        {
            return (bool)Refs.GetVariable("ToggleHelp").Value.Value;
        }
        set
        {
            Refs.GetVariable("ToggleHelp").SetValue(value);
        }
    }
    public IUAVariable ToggleHelpVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ToggleHelp");
        }
    }
#endregion
}
