#pragma strict
import UnityEngine.UI;
 
 static var someText: Text;
 
 function Start()
 {
   someText = GetComponent.<Text>(); //
   //someText.rectTransform.sizeDelta = new Vector2(Screen.width * 1.7, 100);
   //someText.rectTransform.localPosition = new Vector2(0, Screen.height * 0.8 * -1);
   //someText.fontSize = Screen.width / 18;   
   
 }