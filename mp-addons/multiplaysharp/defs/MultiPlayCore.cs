
using Godot;
using System;

public partial class MultiPlayCore : MPBase
{
    public new GodotObject gds;

    public bool AssignClientAuthority {
                        get { return (bool)gds.Get("assign_client_authority"); }
                        set { gds.Set("assign_client_authority", value); }
                      }
public string BindAddress {
                        get { return (string)gds.Get("bind_address"); }
                        set { gds.Set("bind_address", value); }
                      }
public int ConnectTimeoutMs {
                        get { return (int)gds.Get("connect_timeout_ms"); }
                        set { gds.Set("connect_timeout_ms", value); }
                      }
public Node CurrentScene {
                        get { return (Node)gds.Get("current_scene"); }
                        set { gds.Set("current_scene", value); }
                      }
public int CurrentSwapIndex {
                        get { return (int)gds.Get("current_swap_index"); }
                        set { gds.Set("current_swap_index", value); }
                      }
public bool DebugGuiEnabled {
                        get { return (bool)gds.Get("debug_gui_enabled"); }
                        set { gds.Set("debug_gui_enabled", value); }
                      }
public Variant DebugStatusTxt {
                        get { return (Variant)gds.Get("debug_status_txt"); }
                        set { gds.Set("debug_status_txt", value); }
                      }
public PackedScene FirstScene {
                        get { return (PackedScene)gds.Get("first_scene"); }
                        set { gds.Set("first_scene", value); }
                      }
public bool IsServer {
                        get { return (bool)gds.Get("is_server"); }
                        set { gds.Set("is_server", value); }
                      }
public MPPlayer LocalPlayer {
                        get { return (MPPlayer)gds.Get("local_player"); }
                        set { gds.Set("local_player", value); }
                      }
public int MaxPlayers {
                        get { return (int)gds.Get("max_players"); }
                        set { gds.Set("max_players", value); }
                      }
public int Mode {
                        get { return (int)gds.Get("mode"); }
                        set { gds.Set("mode", value); }
                      }
public bool OnlineConnected {
                        get { return (bool)gds.Get("online_connected"); }
                        set { gds.Set("online_connected", value); }
                      }
public MultiplayerPeer OnlinePeer {
                        get { return (MultiplayerPeer)gds.Get("online_peer"); }
                        set { gds.Set("online_peer", value); }
                      }
public int PlayerCount {
                        get { return (int)gds.Get("player_count"); }
                        set { gds.Set("player_count", value); }
                      }
public bool PlayerNodeReady {
                        get { return (bool)gds.Get("player_node_ready"); }
                        set { gds.Set("player_node_ready", value); }
                      }
public PackedScene PlayerScene {
                        get { return (PackedScene)gds.Get("player_scene"); }
                        set { gds.Set("player_scene", value); }
                      }
public MPPlayersCollection Players {
                        get { return (MPPlayersCollection)gds.Get("players"); }
                        set { gds.Set("players", value); }
                      }
public int Port {
                        get { return (int)gds.Get("port"); }
                        set { gds.Set("port", value); }
                      }
public bool Started {
                        get { return (bool)gds.Get("started"); }
                        set { gds.Set("started", value); }
                      }
public string SwapInputAction {
                        get { return (string)gds.Get("swap_input_action"); }
                        set { gds.Set("swap_input_action", value); }
                      }
enum PlayMode {
Online,
OneScreen,
Swap,
Solo,
}
enum ConnectionError {
Unknown,
ServerFull,
AuthFailed,
Timeout,
ConnectionFailure,
InvalidHandshake,
VersionMismatch,
}


    
            public new static MultiPlayCore GetFromNode(Node node)
            {
                MultiPlayCore n = new MultiPlayCore();
                n.gds = (GodotObject)node;
                return n;
            }

    public void CreatePlayer( Variant PlayerId, Variant HandshakeData )
                        {
                            gds.Call("create_player", PlayerId, HandshakeData );
                        }
public void LoadScene( string ScenePath, Variant RespawnPlayers )
                        {
                            gds.Call("load_scene", ScenePath, RespawnPlayers );
                        }
public void StartOneScreen( )
                        {
                            gds.Call("start_one_screen" );
                        }
public void StartOnlineHost( bool ActClient, Godot.Collections.Dictionary ActClientHandshakeData, Godot.Collections.Dictionary ActClientCredentialsData )
                        {
                            gds.Call("start_online_host", ActClient, ActClientHandshakeData, ActClientCredentialsData );
                        }
public void StartOnlineJoin( string Url, Godot.Collections.Dictionary HandshakeData, Godot.Collections.Dictionary CredentialsData )
                        {
                            gds.Call("start_online_join", Url, HandshakeData, CredentialsData );
                        }
public void StartSolo( )
                        {
                            gds.Call("start_solo" );
                        }
public void StartSwap( )
                        {
                            gds.Call("start_swap" );
                        }
public void SwapIncrement( )
                        {
                            gds.Call("swap_increment" );
                        }
public void SwapTo( Variant Index)
                        {
                            gds.Call("swap_to" , Index);
                        }



}        
            