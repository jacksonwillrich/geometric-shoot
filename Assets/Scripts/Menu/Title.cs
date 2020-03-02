using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.transform.position = new Vector3(0, 5.5f, 15);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (this.transform.position.z > 0) 
		{
			this.transform.Translate( 0 , 0.7f , 0);
		}

	}
}
