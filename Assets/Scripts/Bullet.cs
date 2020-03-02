using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public float velocity;
    int counterFrames;
    bool collided;


    void Start()
    {
        collided = false;
        counterFrames = 0;
    }

    void Update()
    {
        transform.Translate(0, velocity * Time.deltaTime, 0);

        if (transform.position.y >= 9 || transform.position.y <= -7)
            Destroy(gameObject);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (collided == false)
            {
                transform.Translate(0, 200, 0);
                Destroy(gameObject);
                collided = true;
            }
        }
    }
}
