using Godot;
using System;

public partial class player_cs : Area2D
{
	private int _health = 10;

	private void TakeDamage(int amount)
	{
		_health -= amount;
		if (_health < 0)
		{
			_health = 0;
		}
		GD.Print(_health);
	}

	private void OnAreaEntered(Area2D area)
	{
		TakeDamage(2);
	}
}
