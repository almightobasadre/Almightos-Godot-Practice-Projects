using Godot;
using System;

public partial class life_bar_cs : TextureProgressBar
{
    private void OnPlayerCSHealthDepleted(int new_value)
    {
        Value = new_value;
        GD.Print(new_value);
    }
}
