using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    //game manager
    public GameManager gamemanager;

    private float points;

    public GameObject Door;


    void Start()
    {
        gamemanager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        points = gamemanager.tPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OpenExit()
    {
        if(points > 2000)
        {
            Door.transform.Translate(Vector3.up * 100 * Time.deltaTime);
        }
    }
}
