using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    //Game Manager
    public GameManager gamemanager;

    //game objects
    public GameObject bullet;
    public GameObject bullet_Case;
    public Transform bullet_exit;
    public Transform case_exit;
    public GameObject Slide;

    //Variables
    public bool magIn = true;
    public int ammo = 10;
    public int recoil = -50;

    void Start()
    {
        gamemanager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    public void MagIN()
    {
        magIn = true;
        if(ammo <= 0)
        {
            ammo = 10;
        }
        gamemanager.updateAmmo(ammo);
    }
    public void MagOut()
    {
        magIn = false;
    }


    public void Shoot()
    {
        if (magIn && ammo > 0)
        {

            //spawn bullet
            Instantiate(bullet, bullet_exit.position, bullet_exit.rotation);

            //spawn empty bullet case
            Instantiate(bullet_Case, case_exit.position, case_exit.rotation);

            //Push slide back
            Slide.transform.Translate(Vector3.forward * recoil * Time.deltaTime);

            ammo -= 1;
            gamemanager.updateAmmo(ammo);
        }
    }


}
