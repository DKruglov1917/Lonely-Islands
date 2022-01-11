using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
    public GameObject tileMap;
    public Tile pfTile;
    private Tile[,] grid;

    private int GridSize = 10;

    private void OnEnable()
    {
        grid = new Tile[GridSize, GridSize];
        CreateMap();
    }

    private void CreateMap()
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Tile tile = Instantiate(pfTile, new Vector3(i * 2, 0, j * 2), Quaternion.identity);
                tile.transform.parent = tileMap.transform;

                int rnd = Random.Range(0, Tile.Type.GetNames(typeof(Tile.Type)).Length);
                tile.type = (Tile.Type)rnd;
            }
        }
    }
}
