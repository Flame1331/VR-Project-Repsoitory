using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Add this to allow you to use XR Toolkit
using UnityEngine.XR.Interaction.Toolkit;

public class SocketCheck: MonoBehaviour
{
    private XRSocketInteractor socket;
    
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();         
    }

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

}
