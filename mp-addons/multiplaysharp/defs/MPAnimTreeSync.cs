
using Godot;
using System;

public partial class MPAnimTreeSync : MPSyncBase
{
    public new GodotObject gds;

    public Variant PropertyList {
                        get { return (Variant)gds.Get("property_list"); }
                        set { gds.Set("property_list", value); }
                      }


    
            public new static MPAnimTreeSync GetFromNode(Node node)
            {
                MPAnimTreeSync n = new MPAnimTreeSync();
                n.gds = (GodotObject)node;
                return n;
            }

    


}        
            