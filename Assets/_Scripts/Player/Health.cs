using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHP, curHP;
    public bool dead;

    public void TakeDamage(int damage)
    {
        curHP -= damage;
    }

    private void Start()
    {
        curHP = maxHP;
        dead = false;
    }

    private void Update()
    {
        if (curHP <= 0)
        {
            dead = true;
            Destroy(gameObject, 10);
        }
    }
}
