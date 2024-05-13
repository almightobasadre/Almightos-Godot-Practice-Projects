"""
Objective:
- use Godot's Input singleton to move the sprite
- steer sprite by adding direction in rotation
- only let sprite move forward upon key press
"""
extends Sprite2D

var speed = 400
var angular_speed = PI

"""Warning: declaring variables in this process to global, leads to its value not resetting per frame"""
func _process(delta):
	var direction = 0
	if Input.is_action_pressed("ui_left"):
		direction = -1
	if Input.is_action_pressed("ui_right"):
		direction = 1
	
	rotation += angular_speed * direction * delta
	
	var velocity = Vector2.ZERO
	if Input.is_action_pressed("ui_up"):
		velocity += Vector2.UP.rotated(rotation) * speed
	
	position += velocity * delta
