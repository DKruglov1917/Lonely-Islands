using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldUserInterface : MonoBehaviour
{
    [SerializeField] private GameObject InventoryCanvas, EquipmentCanvas;
    private bool inventoryIsActive;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        InventoryCanvas.SetActive(inventoryIsActive);
        EquipmentCanvas.SetActive(inventoryIsActive);
        inventoryIsActive = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !inventoryIsActive)
        {
            inventoryIsActive = true;
            Cursor.visible = inventoryIsActive;

            InventoryCanvas.SetActive(inventoryIsActive);
            EquipmentCanvas.SetActive(inventoryIsActive);

            Cursor.lockState = CursorLockMode.Confined;
        }
        else if (Input.GetKeyDown(KeyCode.I) && inventoryIsActive)
        {
            inventoryIsActive = false;
            Cursor.visible = inventoryIsActive;

            InventoryCanvas.SetActive(inventoryIsActive);
            EquipmentCanvas.SetActive(inventoryIsActive);

            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
