using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPicker : MonoBehaviour
{

    public GameObject theAmmo;

    void OnTriggerEnter(Collider other)
    {
        theAmmo.SetActive(false);
    }

}
