extends Area2D

var angular_speed = PI
var radius = Vector2(500.0, 200.0)

var angle = 0.0

@onready var start_position = position

func _process(delta):
	angle = wrapf(angle + angular_speed * delta, 0.0, 2 * angular_speed)
	
	var direction = Vector2(cos(angle), sin(2*angle))
	
	position = start_position + direction * radius
