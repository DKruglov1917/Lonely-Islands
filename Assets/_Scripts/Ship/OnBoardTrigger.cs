using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTrigger : MonoBehaviour
{
    public static bool onBoard;
    private bool isNear;

    private void ManageState()
    {
        if (!onBoard && isNear && Input.GetKeyDown(KeyCode.F))
            onBoard = true;
        else if (onBoard && Input.GetKeyDown(KeyCode.F))
            onBoard = false;
    }

    private void Update()
    {
        ManageState();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            isNear = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            isNear = false;
    }
}
