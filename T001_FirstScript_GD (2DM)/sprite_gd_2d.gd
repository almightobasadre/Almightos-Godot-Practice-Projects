extends Sprite2D


var speed = 400
var angular_speed = PI

func _process(delta):
	rotation += angular_speed * delta
	
	var velocity = Vector2.UP.rotated(rotation) * speed
	
	position += velocity * delta

#func _init():
	#print("Hello, World!")

#func  _unhandled_input(event):
	#if event is InputEventKey:
		#if event.pressed and event.keycode == KEY_ESCAPE:
			#get_tree().quit()
