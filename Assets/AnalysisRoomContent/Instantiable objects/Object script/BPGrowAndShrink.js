#pragma strict
 
var maxSize: double = 2.0;
var minSize: double = 1.0; 
var growthRate: double = 0.5;
var scale: double = 0.1;
var flip = 0; 

function Start () {
var factor : int = Random.Range(5,10);
scale = transform.localScale.y;
maxSize = scale * factor;
}
 
function Update () {
        // Grow the ball randomly
	    if (scale < maxSize) {
	    transform.localScale = Vector3.one * scale;
	    scale += growthRate * (Time.deltaTime/10);}

    
        // Trigger the destruction of all objects
    	if(Input.GetKeyDown ("w")){
			Destroy(gameObject);
			}  	    
}