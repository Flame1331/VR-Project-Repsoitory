using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Add the XR Interaction Toolkit
using UnityEngine.XR.Interaction.Toolkit;

public class ResetAmmo : MonoBehaviour
{
    //GameManager
    public GameManager gamemanager;

    //The socket that you will put something in.
    public XRSocketInteractor socket;

    //The tag that you are looking for
    public string keyTag;

    //The object that will be spawned
    public GameObject spawnObject;

    //The position to spawn the object
    public Transform spawnPosition;

    void Start()
    {
        //get gamemanager
        gamemanager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        //Assign the socket to the variable

        socket = GetComponent<XRSocketInteractor>();
    }



    //Check to see if the objects tag matches the tag you are looking for.
    public bool CheckSocket(string keyTag)
    {
        GameObject item = socket.selectTarget.gameObject;

        if (item.CompareTag(keyTag))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SpawnObjectIfTagMatches()
    {
        if (CheckSocket(keyTag))
        {
            Instantiate(spawnObject, spawnPosition.position, spawnPosition.rotation);
        }
    }
}