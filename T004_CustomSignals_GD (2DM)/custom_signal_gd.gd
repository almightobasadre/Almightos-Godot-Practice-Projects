extends Node2D

func _ready():
	var playerGD = $PlayerGD
	var lifeBarGD = $LifeBarGD
	
	playerGD.connect("health_depleted", Callable(lifeBarGD, "_on_player_gd_health_depleted"))
	
