#pragma strict
var vel = 30;
function Start () {

}

function Update () {
transform.Rotate(0, 0, vel*Time.deltaTime);

}