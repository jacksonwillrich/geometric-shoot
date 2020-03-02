using UnityEngine;
using System.Collections;

public class CanvasGameplay : MonoBehaviour {

    public Ship ship;
    public RectTransform shipEnergyBar;

	void Start () {
        GameObject shipGO = GameObject.FindGameObjectWithTag("Ship");
        ship = shipGO.GetComponent<Ship>();
        shipEnergyBar = transform.GetChild(0).gameObject.GetComponent<RectTransform>();
	}
	
	void Update () {
        shipEnergyBar.sizeDelta = new Vector2(ship.energy * 3, shipEnergyBar.rect.height);
	}
}
