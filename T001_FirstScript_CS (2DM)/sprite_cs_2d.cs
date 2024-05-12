using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class sprite_cs_2d : Sprite2D
{
    private int _speed = 400;
    private float _angularSpeed = Mathf.Pi;

    public override void _Process(double delta)
    {
        Rotation += _angularSpeed * (float)delta; //rotates sprite in place

        var velocity = Vector2.Up.Rotated(Rotation) * _speed;

        Position += velocity * (float)delta; //sprite moves in circle using Vector2 and rotated()

    }

    //public sprite_cs_2d()
    //{
    //    GD.Print("Hello, World!");
    //}

    //tried using input callbacks that don't happen every frame
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
