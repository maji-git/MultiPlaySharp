
using Godot;
using System;

public partial class MPNetProtocolBase : MPExtension
{
    public new GodotObject gds;

    public Variant NetProtocols {
                        get { return (Variant)gds.Get("net_protocols"); }
                        set { gds.Set("net_protocols", value); }
                      }


    
            public new static MPNetProtocolBase GetFromNode(Node node)
            {
                MPNetProtocolBase n = new MPNetProtocolBase();
                n.gds = (GodotObject)node;
                return n;
            }

    public MultiplayerPeer Host( Variant Port, Variant BindIp, Variant MaxPlayers )
                        {
                            return (MultiplayerPeer)gds.Call("host", Port, BindIp, MaxPlayers );
                        }
public MultiplayerPeer Join( Variant Address, Variant Port )
                        {
                            return (MultiplayerPeer)gds.Call("join", Address, Port );
                        }



}        
            