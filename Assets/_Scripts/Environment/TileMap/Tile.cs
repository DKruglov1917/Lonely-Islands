using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public enum Type { Quest, Trade, Dungeoun, Grind, Water, Portal };

    public bool wasVisited;
    public Type type;

    private void OnEnable()
    {
        switch (type)
        {
            case Type.Quest:
                break;
            case Type.Trade:
                break;
            case Type.Dungeoun:
                break;
            case Type.Grind:
                break;
            case Type.Water:
                break;
            case Type.Portal:
                break;
        }
    }
}
