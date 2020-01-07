using System;
using Godot;

public class Player: KinematicBody2D
{
    public int moveSpeed = 250;
    public override void _Ready()
    {
        Console.WriteLine("[Basic] Game instance is ready!");
    }

    public override void _PhysicsProcess(float delta)
    {
        var motion = new Vector2();
        motion.x = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
        motion.y = Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up");

        MoveAndCollide(motion.Normalized() * moveSpeed * delta);
    }
}