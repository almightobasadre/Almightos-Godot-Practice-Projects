using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class sprite_cs_2d : Sprite2D
{
    private int _speed = 400;
    private float _angularSpeed = Mathf.Pi;

    public override void _Process(double delta)
    {
        Rotation += _angularSpeed * (float)delta;
        var velocity = Vector2.Up.Rotated(Rotation) * _speed;

        Position += velocity * (float)delta;

    }

    //public sprite_cs_2d()
    //{
    //    GD.Print("Hello, World!");
    //}

    //public override void _UnhandledInput(InputEvent @event)
    //{
    //    if (@event is InputEventKey eventKey)
    //    {
    //        if (eventKey.Pressed && eventKey.Keycode == Key.Escape)
    //        {
    //            GetTree().Quit();
    //        }
    //    }
    //}

}
