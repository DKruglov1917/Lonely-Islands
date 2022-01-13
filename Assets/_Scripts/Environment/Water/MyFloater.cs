using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFloater : MonoBehaviour
{
    private Rigidbody rigidBody;
    public float floatUpSpeedLimit = 1.15f;
    public float floatUpSpeed = 1f;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 4)
        {
            float difference = (other.transform.position.y - transform.position.y) * floatUpSpeed;
            rigidBody.AddForce(new Vector3(0f, Mathf.Clamp((Mathf.Abs(Physics.gravity.y) * difference), 0, Mathf.Abs(Physics.gravity.y) * floatUpSpeedLimit), 0f), ForceMode.Acceleration);
            rigidBody.drag = 0.99f;
            rigidBody.angularDrag = 0.8f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 4)
        {
            rigidBody.drag = 0f;
            rigidBody.angularDrag = 0f;
        }
    }
}
