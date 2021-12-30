using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int range, damage;
    private int numWeapon;
    List<GameObject> typeOfWeapon;

    public void ChangeWeapon()
    {
        if (Input.GetMouseButtonDown(2))
        {
            typeOfWeapon[numWeapon].SetActive(false);

            numWeapon += 1;
            if (numWeapon >= typeOfWeapon.Count)
                numWeapon = 0;

            typeOfWeapon[numWeapon].SetActive(true);

        }
    }

    private void Start()
    {
        AddWeapon();

        range = 10;
    }

    private void Update()
    {
        ChangeWeapon();
        ManageWeaponDamage();
    }

    private void ManageWeaponDamage()
    {
        switch (numWeapon)
        {
            case 0:
                damage = 10;
                return;
            case 1:
                damage = 20;
                return;
            case 2:
                damage = 30;
                return;
        }
    }

    private void AddWeapon()
    {
        typeOfWeapon = new List<GameObject>();
        numWeapon = 0;

        for (int i = 0; i < transform.childCount; i++)
        {
            typeOfWeapon.Add(transform.GetChild(i).gameObject);
        }

        typeOfWeapon[numWeapon].SetActive(true);
    }
}
