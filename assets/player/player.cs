using Godot;
using System;

public partial class player : CharacterBody2D
{
	
	[Export]
	public int Speed { get; set; } = 400;

	public void GetInput()
	{
		Vector2 inputDirection = Input.GetVector("right", "left", "down", "up");
		Velocity = inputDirection * Speed ;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta) {
			GetInput();
			MoveAndSlide();
	}
}
