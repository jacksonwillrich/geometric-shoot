#pragma strict
#pragma strict
var modo1 = false;
var modo2 = false;
static var modoS = 0;
function Start () {
modoS = 0;
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
			if(modo1 == true){
			modoS = 1;
				Application.LoadLevel("gameplay");
			}
			if(modo2 == true){
			modoS = 2;
					Application.LoadLevel("gameplay2");
			}
	       break;
	    
	      case TouchPhase.Ended: // se o toque começar
	       
	      break;
	   
	   }
	  
	  }

	 }


	}

}
function OnMouseOver () {
if(modo1 == true){
	if(Input.GetButtonDown ("Fire1")){
	modoS = 1;
		Application.LoadLevel("gameplay");
	}
}
if(modo2 == true){
	if(Input.GetButtonDown ("Fire1")){
	modoS = 2;
		Application.LoadLevel("gameplay2");
	}
}
}