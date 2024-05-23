using Godot;
using System;

public partial class player_cs : Area2D
{
    [Signal]
    public delegate void HealthDepletedEventHandler(int new_value);

    private int _health = 10;

    private void TakeDamage(int amount)
    {
        _health -= amount;
        if (_health < 0)
        {
            _health = 0;
        }

        GetNode<AnimationPlayer>("AnimationPlayer").Play("take_damage");
        EmitSignal(nameof(HealthDepletedEventHandler), _health);
    }

    private void OnAreaEntered(Area2D area)
    {
        TakeDamage(2);
    }
}
