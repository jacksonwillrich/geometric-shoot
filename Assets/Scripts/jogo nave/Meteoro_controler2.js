#pragma strict
var vel = 15;
var velLado = 2;
var inicio = 30;
var fim = -6;
var contador = 0;

function Start () {
transform.position.z= inicio*2;
contador = 0;
}

function Update () {
contador++;
if(contador == 2)
{
transform.Translate(velLado*Time.deltaTime, 0, -vel*Time.deltaTime);

if(transform.position.z<=fim){
transform.position.z=inicio;
transform.position.x=Random.Range(-15, 15);

}
contador = 0;
}


}