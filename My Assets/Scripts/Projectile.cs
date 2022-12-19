using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //variables
    private float launchForce = 30f; // Move speed

    //Game manager
    public GameManager gamemanager;

    //rigidbody
    private Rigidbody body;

    public float score1 = 0;
    public float score2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * launchForce, ForceMode.Impulse);
        body = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Range 1"))
        {
            score1 = score1 + Random.Range(100, 150);
            gamemanager.updateScore1(score1);
            StartCoroutine(destroytime());
        }
        if (collision.gameObject.CompareTag("Range 2"))
        {
            score2 = score2 + Random.Range(100, 150);
            gamemanager.updateScore2(score2 + Random.Range(100, 150));
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
