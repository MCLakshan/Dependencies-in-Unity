using System;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class UIHandlerExpnsive : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI type1CountText;
    [SerializeField] private TextMeshProUGUI type2CountText;

    private void Update()
    {
        var inventory = FindObjectOfType<Inventory>();
        if (inventory == null)
        {
            Debug.Log("No inventory found");
        }

        var type1Count = inventory.GetCount("Tile_1");
        type1CountText.text = type1Count.ToString();
        
        var type2Count = inventory.GetCount("Tile_2");
        type2CountText.text = type2Count.ToString();
    }
}
