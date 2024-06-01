
using Godot;
using System;

public partial class MPStartTransform2D : Node2D
{
    public new GodotObject gds;

    

    
            public new static MPStartTransform2D GetFromNode(Node node)
            {
                MPStartTransform2D n = new MPStartTransform2D();
                n.gds = (GodotObject)node;
                return n;
            }

    


}        
            