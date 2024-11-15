using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "FeaturesDemo2", Guid = "a5968f81e70d1330b98bdc421399ca97")]
public class FavoriteTab : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public string Tile_Title
    {
        get
        {
            return (string)Refs.GetVariable("Tile_Title").Value.Value;
        }
        set
        {
            Refs.GetVariable("Tile_Title").SetValue(value);
        }
    }
    public IUAVariable Tile_TitleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Tile_Title");
        }
    }
    public string Tile_Subtitle
    {
        get
        {
            return (string)Refs.GetVariable("Tile_Subtitle").Value.Value;
        }
        set
        {
            Refs.GetVariable("Tile_Subtitle").SetValue(value);
        }
    }
    public IUAVariable Tile_SubtitleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Tile_Subtitle");
        }
    }
    public FTOptix.Core.ResourceUri Tile_Icon
    {
        get
        {
            return new FTOptix.Core.ResourceUri(Refs.GetVariable("Tile_Icon").Value);
        }
        set
        {
            Refs.GetVariable("Tile_Icon").SetValue((string)value);
        }
    }
    public IUAVariable Tile_IconVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Tile_Icon");
        }
    }
    public UAManagedCore.NodeId Tile_Open_Panel
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("Tile_Open_Panel").Value.Value;
        }
        set
        {
            Refs.GetVariable("Tile_Open_Panel").SetValue(value);
        }
    }
    public IUAVariable Tile_Open_PanelVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Tile_Open_Panel");
        }
    }
    public bool Tile_Favorite
    {
        get
        {
            return (bool)Refs.GetVariable("Tile_Favorite").Value.Value;
        }
        set
        {
            Refs.GetVariable("Tile_Favorite").SetValue(value);
        }
    }
    public IUAVariable Tile_FavoriteVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Tile_Favorite");
        }
    }
    public string Tile_Description
    {
        get
        {
            return (string)Refs.GetVariable("Tile_Description").Value.Value;
        }
        set
        {
            Refs.GetVariable("Tile_Description").SetValue(value);
        }
    }
    public IUAVariable Tile_DescriptionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Tile_Description");
        }
    }
#endregion
}
