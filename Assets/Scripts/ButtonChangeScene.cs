using UnityEngine;
using System.Collections;

public class ButtonChangeScene : MonoBehaviour {

    SpriteRenderer mySpriteRenderer;
    public Sprite spriteOff;
    public Sprite spriteOn;
    public string sceneToGo;
	// Use this for initialization
	void Start () {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = spriteOff;
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Debug.Log("toucou no botao");
                mySpriteRenderer.sprite = spriteOff;
            }
        }
	}
}
