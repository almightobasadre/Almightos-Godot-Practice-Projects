using Godot;
using System;

public partial class enemy_cs : Area2D
{
	private float _angularSpeed = Mathf.Pi;
    private Vector2 _radius = new Vector2(500f, 200f);

    private float _angle = 0f;

	private Vector2 _startPosition;
	private Vector2 _previousPosition;

    public override void _Ready()
    {
        _startPosition = Position;
		_previousPosition = _startPosition;
    }

    public override void _Process(double delta)
    {
        _angle = Mathf.Wrap(_angle + _angularSpeed * (float)delta, 0f, 2 * Mathf.Pi);
        Vector2 direction = new Vector2(Mathf.Cos(_angle), Mathf.Sin(2 * _angle));

        _previousPosition = Position;
        Position = _startPosition + direction * _radius;
        Rotation = (Position - _previousPosition).Angle();
    }
}
