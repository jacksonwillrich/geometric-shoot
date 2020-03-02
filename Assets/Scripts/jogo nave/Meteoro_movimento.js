#pragma strict
var velx = 30;
var vely = 20;
var velz = 40;
var contador = 0;
function Start () {
contador = 0;
}

function Update () {
if(this.transform.position.z < -2 && this.transform.position.z > -22);
{contador++;
if(contador == 2)
{
transform.Rotate(velx*Time.deltaTime * 2, vely*Time.deltaTime * 2, velz*Time.deltaTime * 2);
contador = 0;
}
}
}