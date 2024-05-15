using Godot;
using System;

public partial class sprite_cs_2d_3 : Sprite2D
{
    private int _speed = 400;
    private float _angularSpeed = Mathf.Pi;

    public override void _Process(double delta)
    {
        Rotation += _angularSpeed * (float)delta;
        var velocity = Vector2.Up.Rotated(Rotation) * _speed;
        Position += velocity * (float)delta;
    }

    private void OnToggleMotionPressed()
    {
        SetProcess(!IsProcessing());
    }
}
