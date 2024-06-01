using Godot;
using System;

public partial class Test : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		MultiPlayCore mpc = MultiPlayCore.GetFromNode(GetNode<Node>("../"));
		GD.Print("mpc.Port: ", mpc.Port);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
