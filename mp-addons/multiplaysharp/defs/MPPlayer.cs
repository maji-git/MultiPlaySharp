
using Godot;
using System;

public partial class MPPlayer : MPBase
{
    public new GodotObject gds;

    public Variant AuthData {
                        get { return (Variant)gds.Get("auth_data"); }
                        set { gds.Set("auth_data", value); }
                      }
public Variant HandshakeData {
                        get { return (Variant)gds.Get("handshake_data"); }
                        set { gds.Set("handshake_data", value); }
                      }
public bool IsLocal {
                        get { return (bool)gds.Get("is_local"); }
                        set { gds.Set("is_local", value); }
                      }
public bool IsReady {
                        get { return (bool)gds.Get("is_ready"); }
                        set { gds.Set("is_ready", value); }
                      }
public bool IsSwapFocused {
                        get { return (bool)gds.Get("is_swap_focused"); }
                        set { gds.Set("is_swap_focused", value); }
                      }
public MultiPlayCore Mpc {
                        get { return (MultiPlayCore)gds.Get("mpc"); }
                        set { gds.Set("mpc", value); }
                      }
public int PingMs {
                        get { return (int)gds.Get("ping_ms"); }
                        set { gds.Set("ping_ms", value); }
                      }
public int PlayerId {
                        get { return (int)gds.Get("player_id"); }
                        set { gds.Set("player_id", value); }
                      }
public int PlayerIndex {
                        get { return (int)gds.Get("player_index"); }
                        set { gds.Set("player_index", value); }
                      }
public Node PlayerNode {
                        get { return (Node)gds.Get("player_node"); }
                        set { gds.Set("player_node", value); }
                      }
public string PlayerNodeResourcePath {
                        get { return (string)gds.Get("player_node_resource_path"); }
                        set { gds.Set("player_node_resource_path", value); }
                      }


    
            public new static MPPlayer GetFromNode(Node node)
            {
                MPPlayer n = new MPPlayer();
                n.gds = (GodotObject)node;
                return n;
            }

    public void DespawnNode( )
                        {
                            gds.Call("despawn_node" );
                        }
public void DisconnectPlayer( )
                        {
                            gds.Call("disconnect_player" );
                        }
public void Kick( string Reason)
                        {
                            gds.Call("kick" , Reason);
                        }
public Variant Ma( StringName ActionName)
                        {
                            return (Variant)gds.Call("ma" , ActionName);
                        }
public void RespawnNode( )
                        {
                            gds.Call("respawn_node" );
                        }
public void SpawnNode( )
                        {
                            gds.Call("spawn_node" );
                        }
public StringName TranslateAction( StringName OriginAction)
                        {
                            return (StringName)gds.Call("translate_action" , OriginAction);
                        }



}        
            