
using Godot;
using System;

public partial class MPSyncBase : MPBase
{
    public new GodotObject gds;

    

    
            public new static MPSyncBase GetFromNode(Node node)
            {
                MPSyncBase n = new MPSyncBase();
                n.gds = (GodotObject)node;
                return n;
            }

    public Variant CheckIsLocal( )
                        {
                            return (Variant)gds.Call("check_is_local" );
                        }
public Variant CheckRecvPermission( bool IsServerCmd)
                        {
                            return (Variant)gds.Call("check_recv_permission" , IsServerCmd);
                        }
public Variant CheckSendPermission( )
                        {
                            return (Variant)gds.Call("check_send_permission" );
                        }
public Variant ShouldSync( )
                        {
                            return (Variant)gds.Call("should_sync" );
                        }



}        
            