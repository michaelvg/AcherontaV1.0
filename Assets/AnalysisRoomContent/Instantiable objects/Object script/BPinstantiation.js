#pragma strict

var myBlueBall : GameObject;

var maxUpAndDown : double = 0.07;        // amount of meters going up and down
var speed        : float = 25;        // up and down speed
var mvgtest      = 50;
var mvgtest2     = mvgtest/100; 

protected var angle        : float = -90;       // angle to determin the height by using the sinus
protected var toDegrees     : float = Mathf.PI/180;    // radians to degrees
protected var startHeight   : float;          // height of the object when the script starts

function Start()
{
    startHeight = transform.localPosition.y;
        
}

function Update () {
    angle += speed * Time.deltaTime;
    if (angle > 270) angle -= 360;
    Debug.Log(maxUpAndDown * Mathf.Sin(angle * toDegrees));
    transform.localPosition.y = startHeight + 0.1 * (1 + Mathf.Sin(angle * toDegrees)) / 2;
}