/*
 Objective:
- connect button node's signal in the editor
- create visibility function on timer timeout
- call and connect timer node's signal via code
 */
using Godot;
using System;

public partial class sprite_cs_2d_3 : Sprite2D
{
    private int _speed = 400;
    private float _angularSpeed = Mathf.Pi;

    public override void _Ready()
    {
        var timer = GetNode<Timer>("Timer"); //retrieves node named <NodeName> in the scene hierarchy
        timer.Timeout += OnTimerTimeout; //establishes connection for signal, node, and function
    }

    public override void _Process(double delta)
    {
        Rotation += _angularSpeed * (float)delta;
        var velocity = Vector2.Up.Rotated(Rotation) * _speed;
        Position += velocity * (float)delta;
    }

    private void OnToggleMotionPressed()
    {
        SetProcess(!IsProcessing()); //enable and disable node's process
    }

    private void OnTimerTimeout() //called when Timer node emits timeout signal
    {
        Visible = !Visible;
    }
}
