using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //variables
    public float launchForce = 10f; // Move speed

    //Game manager
    public GameManager gamemanager;

    //rigidbody
    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * launchForce, ForceMode.Impulse);
        body = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Range1"))
        {
            gamemanager.updateScore1(Random.Range(100, 150));
            StartCoroutine(destroytime());
        }
        if (collision.gameObject.CompareTag("Range2"))
        {
            gamemanager.updateScore2(Random.Range(100, 150));
            StartCoroutine(destroytime());
        }
        if (collision.gameObject.CompareTag("Room Parts"))
        {
            body.AddForce(Vector3.forward * 0, ForceMode.Impulse);
            StartCoroutine(destroytime());
        }
    }

    IEnumerator destroytime()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

}
