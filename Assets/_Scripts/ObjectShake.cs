using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShake : MonoBehaviour
{
    public float _duration = .4f;
    private Transform _objectTransform;
    private Vector3 _originalPosition;

    void Start()
    {
        _objectTransform = GetComponent<Transform>();
        _originalPosition = _objectTransform.transform.position;
    }

    public void Shake()
    {
        StartCoroutine(_Shake());
    }

    IEnumerator _Shake()
    {
        float x;
        float y;
        float timeLeft = Time.time;

        while ((timeLeft + _duration) > Time.time)
        {
            x = Random.Range(-.05f, .05f);
            y = Random.Range(-.05f, .05f);

            _objectTransform.position = new Vector3(_objectTransform.transform.position.x + x,
                _objectTransform.transform.position.y + y, _originalPosition.z); yield return new WaitForSeconds(0.025f);
        }

        _objectTransform.position = _originalPosition;
    }
}