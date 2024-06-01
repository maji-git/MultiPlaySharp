
using Godot;
using System;

public partial class ENetProtocol : MPNetProtocolBase
{
    public new GodotObject gds;

    public int BandwidthInLimit {
                        get { return (int)gds.Get("bandwidth_in_limit"); }
                        set { gds.Set("bandwidth_in_limit", value); }
                      }
public int BandwidthOutLimit {
                        get { return (int)gds.Get("bandwidth_out_limit"); }
                        set { gds.Set("bandwidth_out_limit", value); }
                      }
public int CompressionMode {
                        get { return (int)gds.Get("compression_mode"); }
                        set { gds.Set("compression_mode", value); }
                      }
public Variant Role {
                        get { return (Variant)gds.Get("role"); }
                        set { gds.Set("role", value); }
                      }
public bool Secure {
                        get { return (bool)gds.Get("secure"); }
                        set { gds.Set("secure", value); }
                      }
public CryptoKey ServerPrivateKey {
                        get { return (CryptoKey)gds.Get("server_private_key"); }
                        set { gds.Set("server_private_key", value); }
                      }
public X509Certificate SslCertificate {
                        get { return (X509Certificate)gds.Get("ssl_certificate"); }
                        set { gds.Set("ssl_certificate", value); }
                      }


    
            public new static ENetProtocol GetFromNode(Node node)
            {
                ENetProtocol n = new ENetProtocol();
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
            