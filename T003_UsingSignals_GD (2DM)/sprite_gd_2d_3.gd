"""
 Objective:
- connect button node's signal in the editor
- create visibility function on timer timeout
- call and connect timer node's signal via code
"""
extends Sprite2D

var speed = 400
var angular_speed = PI

func _process(delta):
	rotation += angular_speed * delta
	var velocity = Vector2.UP.rotated(rotation) * speed
	position += velocity * delta


func _on_toggle_motion_pressed():
	set_process(not is_processing()) #enable and disable node's process
