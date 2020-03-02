#pragma strict

function Start () {

}

function Update () {
for(var i:int =0; i < Input.touches.Length; i++){ // quantos toques voce tem ??

	var touch:Touch=Input.touches[i]; //o toque
	var ray = Camera.main.ScreenPointToRay (Input.GetTouch(i).position);
	var hit:RaycastHit =new RaycastHit ();

	 if(Physics.Raycast(ray,hit,1000)){
	  if(hit.collider.gameObject ==this.gameObject){
	   
	   switch (touch.phase) {
	   
	    case TouchPhase.Began: // se o toque começar
			Application.Quit();
	       break;
	    
	      case TouchPhase.Ended: // se o toque começar
	       
	      break;
	   
	   }
	  
	  }

	 }


	}
}
function OnMouseOver() 
{
if(Input.GetButtonDown ("Fire1"))
	{
 		Application.Quit();
	}
}