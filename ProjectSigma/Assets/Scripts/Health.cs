using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float maxHP = 100f;
    public float HP;

    private void Start()
    {
        HP = maxHP;
    }

    private void Update()
    {
        if (HP == 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float dmg)
    {
        HP -= dmg;
    }
}
