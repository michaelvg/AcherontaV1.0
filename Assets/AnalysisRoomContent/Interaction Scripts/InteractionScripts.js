private var motor : CharacterMotor;

var myBlueBall : GameObject;
var myGrShball : GameObject;
var balls = [];

function Start () {
}

function Update () {

    // Trigger instantiation of thousands of objects 
    	if(Input.GetKeyDown ("a")){
	     var minX : double = -12.5;
	     var maxX : double = 12.5;
	     var minY : double = 2.5;
	     var maxY : double = 3.5;
	     var minZ : double = -12.5;
	     var maxZ : double = 12.5;

	     var totalCubes : int = 2500; 
	     var rot: Quaternion = Quaternion.identity;
	     for ( var i=0; i < totalCubes; i++){ 
	       var pos: Vector3 = Vector3(Random.Range(minX,maxX),Random.Range(minY,maxY),Random.Range(minZ,maxZ)); 
	       var ball = Instantiate(myBlueBall, pos, rot);
	       ball.name = "Ball" + i;
	       } 
    	}
    	
    // Trigger instantiation of big objects 
    	if(Input.GetKeyDown ("b")){
	     var minX2 : double = -12.5;
	     var maxX2 : double = 12.5;
	     var minY2 : double = 2.5;
	     var maxY2 : double = 3.5;
	     var minZ2 : double = -12.5;
	     var maxZ2 : double = 12.5;
	     var minSize: double = 0.1; 
	     var maxSize: double = 1.7; 

	     var totalCubes2 : int = 20; 
	     var rot2: Quaternion = Quaternion.identity;
	     for ( var i2=0; i2 < totalCubes2; i2++){ 
	       var pos2: Vector3 = Vector3(Random.Range(minX2,maxX2),Random.Range(minY2,maxY2),Random.Range(minZ2,maxZ2)); 
	       var ball2 = Instantiate(myBlueBall, pos2, rot2);
	       ball2.name = "Ball" + i2;
	       var ballSize = Random.Range(minSize,maxSize); 
	       ball2.transform.localScale = new Vector3(ballSize,ballSize,ballSize); 
	       } 
    	}  

    // Trigger instantiation of growing and shrinking balls
    	if(Input.GetKeyDown ("v")){
	     var minX3 : double = -12.5;
	     var maxX3 : double = 12.5;
	     var minY3 : double = 2.5;
	     var maxY3 : double = 3.5;
	     var minZ3 : double = -12.5;
	     var maxZ3 : double = 12.5;
	     var minSize3: double = 0.1; 
	     var maxSize3: double = 0.5; 

	     var totalCubes3 : int = 3; 
	     var rot3: Quaternion = Quaternion.identity;
	     for ( var i3=0; i3 < totalCubes3; i3++){ 
	       var pos3: Vector3 = Vector3(Random.Range(minX3,maxX3),Random.Range(minY3,maxY3),Random.Range(minZ3,maxZ3)); 
	       var ball3 = Instantiate(myGrShball, pos3, rot3);
	       ball3.name = "Ball" + i3;
	       var ballSize3 = Random.Range(minSize3,maxSize3); 
	       ball3.transform.localScale = new Vector3(ballSize3,ballSize3,ballSize3); 
	       } 
    	}     	    	
  	
}


