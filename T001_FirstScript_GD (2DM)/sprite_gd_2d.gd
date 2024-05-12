extends Sprite2D


var speed = 400
var angular_speed = PI

func _process(delta):
	rotation += angular_speed * delta #rotates sprite in place
	
	var velocity = Vector2.UP.rotated(rotation) * speed
	
	position += velocity * delta #sprite moves in circle using Vector2 and rotated()

#func _init():
	#print("Hello, World!")

#tried using input callbacks that don't happen every frame
#func  _unhandled_input(event):
	#if event is InputEventKey:
		#if event.pressed and event.keycode == KEY_ESCAPE:
			#get_tree().quit()
