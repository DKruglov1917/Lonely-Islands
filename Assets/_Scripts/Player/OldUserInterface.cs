using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldUserInterface : MonoBehaviour
{
    [SerializeField] private GameObject InventoryCanvas;
    private bool inventoryIsActive;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        InventoryCanvas.SetActive(false);
        inventoryIsActive = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && inventoryIsActive == false)
        {
            inventoryIsActive = true;
            Cursor.visible = inventoryIsActive;
            InventoryCanvas.SetActive(inventoryIsActive);
            Cursor.lockState = CursorLockMode.Confined;
        }
        else if (Input.GetKeyDown(KeyCode.I) && inventoryIsActive == true)
        {
            inventoryIsActive = false;
            Cursor.visible = inventoryIsActive;
            InventoryCanvas.SetActive(inventoryIsActive);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
