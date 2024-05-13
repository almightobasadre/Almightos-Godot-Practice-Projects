/*
Objective:
- use Godot's Input singleton to move the sprite
- steer sprite by adding direction in rotation
- only let sprite move forward upon key press
*/
using Godot;
using System;

public partial class sprite_cs_2d_2 : Sprite2D
{
    private int _speed = 400;
    private float _angularSpeed = Mathf.Pi;

    //Warning: declaring variables in this process to global, leads to its value not resetting per frame
    public override void _Process(double delta)
    {
        var direction = 0;
        if (Input.IsActionPressed("ui_left"))
        {
            direction = -1;
        }
        if (Input.IsActionPressed("ui_right"))
        {
            direction = 1;
        }

        Rotation += _angularSpeed * direction * (float)delta;

        var velocity = Vector2.Zero;
        if (Input.IsActionPressed("ui_up"))
        {
            velocity = Vector2.Up.Rotated(Rotation) * _speed;
        }

        Position += velocity * (float)delta;
    }
}
