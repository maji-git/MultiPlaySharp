
using Godot;
using System;

public partial class MPBase : Node
{
    public  GodotObject gds;

    

    
            public  static MPBase GetFromNode(Node node)
            {
                MPBase n = new MPBase();
                n.gds = (GodotObject)node;
                return n;
            }

    


}        
            