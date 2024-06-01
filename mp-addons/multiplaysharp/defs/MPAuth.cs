
using Godot;
using System;

public partial class MPAuth : MPExtension
{
    public new GodotObject gds;

    public Callable AuthenticateFunction {
                        get { return (Callable)gds.Get("authenticate_function"); }
                        set { gds.Set("authenticate_function", value); }
                      }


    
            public new static MPAuth GetFromNode(Node node)
            {
                MPAuth n = new MPAuth();
                n.gds = (GodotObject)node;
                return n;
            }

    


}        
            