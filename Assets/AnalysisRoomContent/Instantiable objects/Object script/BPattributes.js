#pragma strict

 var isType: int; 
 var colorMin : int = 0;
 var colorMax : int = 6; 
 var partnerID: int; 
 var salesVolume: int; 
 var risk: int; 
 var potential: int; 
 var location: int; 

function Start () {

isType = Random.Range(colorMin,colorMax); 

 switch (isType)
 {
 case 1: gameObject.renderer.material.color = Color.gray; break; 
 case 2: gameObject.renderer.material.color = Color.black; break;
 case 3: gameObject.renderer.material.color = Color.blue; break;
 case 4: gameObject.renderer.material.color = Color.gray; break;
 case 5: gameObject.renderer.material.color = Color.cyan; break;
 }
}

function Update () {

	var Hspeed : float = 2.0;    	
	var totalBalls : int = 50;
	if(Input.GetKey ("z")){
	    if(isType == 3){
	    gameObject.transform.Translate(Vector2.right*Hspeed*Time.deltaTime);
	    }
      } 
	if(Input.GetKey ("e")){
	    if(isType == 1){
	    gameObject.transform.Translate(Vector3.left*Hspeed*Time.deltaTime);
	    }
      }  
    // Trigger the destruction of all objects
    	if(Input.GetKeyDown ("w")){
			Destroy(gameObject);
			}           	
}