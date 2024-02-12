using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Speciality speciality;
    public Transform fireSocket;
    public float fireForce;
         

    public void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    public void shoot()
    {
        GameObject balle = Instantiate(speciality.projectile, fireSocket.position, fireSocket.rotation);
        balle.GetComponent<Rigidbody2D>().AddForce(fireSocket.up * fireForce, ForceMode2D.Impulse);
    }


}
