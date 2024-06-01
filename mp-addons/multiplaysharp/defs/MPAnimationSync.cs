
using Godot;
using System;

public partial class MPAnimationSync : MPSyncBase
{
    public new GodotObject gds;

    

    
            public new static MPAnimationSync GetFromNode(Node node)
            {
                MPAnimationSync n = new MPAnimationSync();
                n.gds = (GodotObject)node;
                return n;
            }

    


}        
            