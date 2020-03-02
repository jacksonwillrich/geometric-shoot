using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

    public float fireRate;
    public float lastFire;
    float counter;
    public GameObject bullet; 


	void Start () {
        lastFire = Time.fixedTime;
	}
	
	void Update () {
	}

	public void Fire () {
        if (Time.fixedTime >= lastFire + fireRate)
        {
            lastFire = Time.fixedTime;
            Instantiate(bullet, transform.position, transform.rotation);
        }
	}
}
