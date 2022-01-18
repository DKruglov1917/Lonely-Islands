using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    [SerializeField] private GameObject shipCamera, player, onFootCanvas;
    [SerializeField] private OnBoardTrigger onBoardTrigger;
    private float moveForce = 10f;
    private float rotateForce = 25f;

    private void Start()
    {
        OnBoardTrigger.onBoard = false;
    }

    void Update()
    {
        if (OnBoardTrigger.onBoard)
        {
            player.SetActive(false);
            onFootCanvas.SetActive(false);
            shipCamera.SetActive(true);

            float move = Input.GetAxis("Vertical");
            float rotate = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.forward * move * moveForce * Time.deltaTime);

            transform.eulerAngles = new Vector3(transform.eulerAngles.x,
            transform.eulerAngles.y + rotate * rotateForce * Time.deltaTime,
            transform.eulerAngles.z);
        }
        else
        {
            player.SetActive(true);
            onFootCanvas.SetActive(true);
            shipCamera.SetActive(false);
        }
    }
}