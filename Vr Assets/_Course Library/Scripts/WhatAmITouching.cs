using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatAmITouching : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name+ " COLLISION: " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + "TRIGGER: " + other.gameObject.name);
    }
}
