using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject firePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shot();
        }
    }

    void Shot()
    {
        Instantiate(firePrefab, firePoint.position, firePoint.rotation);
    }
}
