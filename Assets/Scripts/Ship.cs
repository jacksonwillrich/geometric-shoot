using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

    Gun gun;
    public float velocityTurn;
    public float velocityTurnMax;
    float velocityTurnDelta;
    public float acelerationTurn;
    public float limitScreenRight = 3.2f;
    public float limitScreenLeft = -3.2f;
    public float energy;
    public float energyCost;
    public float energyRecovery;
    public float secondsDelayTime;
    bool pushing;
    bool moving;
    bool fireing;

	void Start () {
        transform.position = new Vector3(0, -2.5f, 0);
        gun = GetComponentInChildren<Gun>();
        gun.gameObject.transform.position = new Vector3(0, -2.5f, 0); ;

        energy = 100;
        pushing = false;
        moving = false;
        fireing = false;
	}
	
	void Update () {
        if (Input.GetMouseButton(0))
        {
            if (energy > 5)
            {
                pushing = true;
                moving = true;
                StartCoroutine("DelayMoving");
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            pushing = false;
            moving = false;
            fireing = false;
            velocityTurn = 0;
            StopCoroutine("DelayMoving");
        }

        if (moving)
        {
            if (energy > 0)
            {
                if (fireing)
                    gun.Fire();

                energy -= energyCost * Time.deltaTime;

                if (velocityTurn < velocityTurnMax)
                    velocityTurn += acelerationTurn;

                velocityTurnDelta = velocityTurn * Time.deltaTime;

                if (Input.mousePosition.x > (Screen.width * 0.5f))
                    ToRight();
                else
                    ToLeft();
            }

        }
        else
        {
            if (energy < 100)
            energy += energyRecovery * Time.deltaTime;
            if (energy > 100)
                energy = 100;
        }
	}

    IEnumerator DelayMoving()
    {
        yield return new WaitForSeconds(gun.fireRate);
        if (pushing)
            fireing = true;
    }

    void ToRight()
    {
        if (transform.position.x + velocityTurnDelta < limitScreenRight)
            transform.Translate(velocityTurnDelta, 0, 0);
    }

    void ToLeft()
    {
        if (transform.position.x - velocityTurnDelta > limitScreenLeft)
            transform.Translate(-velocityTurnDelta, 0, 0);
    }
}
