using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Inventory PlayerInventory;

    // private void Start()
    // {
    //     PlayerInventory = new Inventory();
    // }

    public void AddTileType1ToInventory(GameObject tile)
    {
        PlayerInventory.inventory.Add("Tile_1");
        Destroy(tile);
        Debug.Log("Added Tile 1 to Inventory ---> ");
    }
    public void AddTileType2ToInventory(GameObject tile)
    {
        PlayerInventory.inventory.Add("Tile_2");
        Destroy(tile);
        Debug.Log("Added Tile 1 to Inventory ---> ");
    }
}
