using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHP, curHP;

    public void TakeDamage(int damage)
    {
        curHP -= damage;
    }

    private void Start()
    {
        curHP = maxHP;
    }

    private void Update()
    {
        if (curHP <= 0)
        {
            Destroy(gameObject, 10);
        }
    }
}
