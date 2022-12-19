using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMag : MonoBehaviour
{
    public Transform magspawn;
    public GameObject Mag;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMagazine()
    {
        Instantiate(Mag, magspawn.position, magspawn.rotation);
    }
}
