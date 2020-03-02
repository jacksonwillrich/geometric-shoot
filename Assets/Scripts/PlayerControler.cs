using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {
    float xPos, yPos, zPos; //player position on screen
    float speed; //player speed movement
    float nextFire; // the time that ship will can shoot again (time now + fire rate gun)
    public GameObject primaryGun; //the principal gun player
    public Transform bulletSpawnPoint1; //where the bullet will be spawned
    public Transform bulletSpawnPoint2; //where the bullet will be spawned case ship have two guns


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
