using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    public GameObject player;
    private TextMeshProUGUI textMesh;

    private void Awake()
    {
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        player = GameObject.Find("Player").transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        transform.LookAt(player.transform);
    }

    public void Setup(int damageAmount)
    {
        textMesh.SetText(damageAmount.ToString());
        Destroy(gameObject, 1);
    }
}
