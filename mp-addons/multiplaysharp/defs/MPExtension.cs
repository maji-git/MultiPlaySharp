
using Godot;
using System;

public partial class MPExtension : MPBase
{
    public new GodotObject gds;

    public MultiPlayCore Mpc {
                        get { return (MultiPlayCore)gds.Get("mpc"); }
                        set { gds.Set("mpc", value); }
                      }


    
            public new static MPExtension GetFromNode(Node node)
            {
                MPExtension n = new MPExtension();
                n.gds = (GodotObject)node;
                return n;
            }

    


}        
            