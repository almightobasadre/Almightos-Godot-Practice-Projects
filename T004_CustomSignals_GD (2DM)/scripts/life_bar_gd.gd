extends TextureProgressBar

func _on_player_gd_health_changed(new_health : int):
	value = new_health
