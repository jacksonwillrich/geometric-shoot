#pragma strict
import UnityEngine.UI;
 
static var BestScore = 0;
var someText: Text;

 
function Awake()
{
    

}

 function Start()
 {
 try{BestScore = PlayerPrefs.GetInt("maiorScore");}
catch(err: System.Exception) {
		Debug.Log("Got: " + err);
}
   someText = GetComponent.<Text>(); //
   //someText.rectTransform.sizeDelta = new Vector2(Screen.width * 2, 200);
   //someText.fontSize = Screen.width * 0.15;
   someText.text = "Best Score: " + BestScore;
 }
 
 function Update()
 {
   
 }