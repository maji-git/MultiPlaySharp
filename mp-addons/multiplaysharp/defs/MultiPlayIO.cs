
using Godot;
using System;

public partial class MultiPlayIO : MPBase
{
    public new GodotObject gds;

    public MultiPlayCore Mpc {
                        get { return (MultiPlayCore)gds.Get("mpc"); }
                        set { gds.Set("mpc", value); }
                      }
public int PlrId {
                        get { return (int)gds.Get("plr_id"); }
                        set { gds.Set("plr_id", value); }
                      }


    
            public new static MultiPlayIO GetFromNode(Node node)
            {
                MultiPlayIO n = new MultiPlayIO();
                n.gds = (GodotObject)node;
                return n;
            }

    public void Logdata( Variant Data)
                        {
                            gds.Call("logdata" , Data);
                        }
public void Logerr( Variant Data)
                        {
                            gds.Call("logerr" , Data);
                        }
public void Logwarn( Variant Data)
                        {
                            gds.Call("logwarn" , Data);
                        }



}        
            