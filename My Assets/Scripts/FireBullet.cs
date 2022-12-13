using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    //game objects
    public GameObject bullet;
    public GameObject bullet_Case;
    public Transform bullet_exit;
    public Transform case_exit;



    public void Shoot()
    {
        //spawn bullet
        Instantiate(bullet, bullet_exit.position, bullet_exit.rotation);

        //spawn empty bullet case
        Instantiate(bullet_Case, case_exit.position, case_exit.rotation);

    }


}
