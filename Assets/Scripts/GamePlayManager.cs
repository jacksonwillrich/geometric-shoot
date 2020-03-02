using UnityEngine;
using System.Collections;

public class GamePlayManager : MonoBehaviour {

    public float enemySpawnRate;
    public float lastEnemySpawnTime;
    public GameObject enemyBasic;
    public GameObject explosion1;

	void Start () {
        Instantiate(enemyBasic, new Vector3(Random.Range(-2.7f, 2.71f), 9, 0), transform.rotation);
        lastEnemySpawnTime = Time.fixedTime;
	}
	
	void Update () {
        if (Time.fixedTime > lastEnemySpawnTime + enemySpawnRate)
        {
            Instantiate(enemyBasic, new Vector3(Random.Range(-2.7f, 2.71f), 9, 0), transform.rotation);
            lastEnemySpawnTime = Time.fixedTime;
        }
	}

    public void InstantiateExplosion1(Vector3 position)
    {
        Instantiate(explosion1, position, transform.rotation);
    }
}
