
using Godot;
using System;

public partial class MPTransformSync : MPSyncBase
{
    public new GodotObject gds;

    public bool LerpEnabled {
                        get { return (bool)gds.Get("lerp_enabled"); }
                        set { gds.Set("lerp_enabled", value); }
                      }
public int LerpSpeed {
                        get { return (int)gds.Get("lerp_speed"); }
                        set { gds.Set("lerp_speed", value); }
                      }
public float PositionSensitivity {
                        get { return (float)gds.Get("position_sensitivity"); }
                        set { gds.Set("position_sensitivity", value); }
                      }
public float RotationSensitivity {
                        get { return (float)gds.Get("rotation_sensitivity"); }
                        set { gds.Set("rotation_sensitivity", value); }
                      }
public float ScaleSensitivity {
                        get { return (float)gds.Get("scale_sensitivity"); }
                        set { gds.Set("scale_sensitivity", value); }
                      }
public bool SyncPosition {
                        get { return (bool)gds.Get("sync_position"); }
                        set { gds.Set("sync_position", value); }
                      }
public bool SyncRotation {
                        get { return (bool)gds.Get("sync_rotation"); }
                        set { gds.Set("sync_rotation", value); }
                      }
public bool SyncScale {
                        get { return (bool)gds.Get("sync_scale"); }
                        set { gds.Set("sync_scale", value); }
                      }


    
            public new static MPTransformSync GetFromNode(Node node)
            {
                MPTransformSync n = new MPTransformSync();
                n.gds = (GodotObject)node;
                return n;
            }

    public void SetPosition2d( Vector2 To)
                        {
                            gds.Call("set_position_2d" , To);
                        }
public void SetPosition3d( Vector3 To)
                        {
                            gds.Call("set_position_3d" , To);
                        }
public void SetRotation2d( float To)
                        {
                            gds.Call("set_rotation_2d" , To);
                        }
public void SetRotation3d( Vector3 To)
                        {
                            gds.Call("set_rotation_3d" , To);
                        }
public void SetScale2d( Vector2 To)
                        {
                            gds.Call("set_scale_2d" , To);
                        }
public void SetScale3d( Vector3 To)
                        {
                            gds.Call("set_scale_3d" , To);
                        }



}        
            