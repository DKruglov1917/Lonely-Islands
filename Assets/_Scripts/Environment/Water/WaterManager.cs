using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class WaterManager : MonoBehaviour
{
    private MeshFilter meshFilter;

    private void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
    }

    private void Update()
    {
        Vector3[] verticies = meshFilter.mesh.vertices;
        for (int i = 0; i < verticies.Length; i++)
        {
            verticies[i].y = WaveManager.instance.GetWaveHeight(transform.position.x + verticies[i].x);
        }

        meshFilter.mesh.vertices = verticies;
        meshFilter.mesh.RecalculateNormals();
    }
}
