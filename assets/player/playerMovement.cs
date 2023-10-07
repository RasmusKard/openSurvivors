using Godot;
using System;

public partial class playerMovement : CharacterBody2D
{

	[Export]
	public int Speed {get; set; } = 400;

	public void GetInput()
	{
		Vector2 InputDirection = Input.GetVector("left", "right", "down", "up");
		Velocity = InputDirection * Speed;
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide();
	}

}
