using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_dealing : MonoBehaviour
{
    public float dmg;


    private void Start()
    {
        dmg = GameObject.Find("Player").GetComponent<Combat>().dmg;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.gameObject.GetComponent<Health>().TakeDamage(dmg);
        }
    }


}
