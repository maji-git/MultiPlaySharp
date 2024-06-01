
using Godot;
using System;

public partial class MPPlayersCollection : MPBase
{
    public new GodotObject gds;

    public Godot.Collections.Dictionary Players {
                        get { return (Godot.Collections.Dictionary)gds.Get("players"); }
                        set { gds.Set("players", value); }
                      }


    
            public new static MPPlayersCollection GetFromNode(Node node)
            {
                MPPlayersCollection n = new MPPlayersCollection();
                n.gds = (GodotObject)node;
                return n;
            }

    public void DespawnNodeAll( )
                        {
                            gds.Call("despawn_node_all" );
                        }
public MPPlayer GetPlayerById( int PlayerId)
                        {
                            return (MPPlayer)gds.Call("get_player_by_id" , PlayerId);
                        }
public MPPlayer GetPlayerByIndex( int PlayerIndex)
                        {
                            return (MPPlayer)gds.Call("get_player_by_index" , PlayerIndex);
                        }
public Godot.Collections.Dictionary GetPlayers( )
                        {
                            return (Godot.Collections.Dictionary)gds.Call("get_players" );
                        }
public void RespawnNodeAll( )
                        {
                            gds.Call("respawn_node_all" );
                        }
public void SpawnNodeAll( )
                        {
                            gds.Call("spawn_node_all" );
                        }



}        
            