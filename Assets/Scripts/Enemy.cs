using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float velocity;
    Gun gun;

	void Start () {
        gun = GetComponentInChildren<Gun>();
	}
	
	void Update () {
        gun.Fire();

        transform.Translate(0, velocity * Time.deltaTime, 0);
        if (transform.position.y < -7)
            Destroy(gameObject);
	}
}
