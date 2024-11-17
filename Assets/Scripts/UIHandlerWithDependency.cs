using UnityEngine;
using TMPro;

public class UIHandlerWithDependency : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI type1CountText;
    [SerializeField] private TextMeshProUGUI type2CountText;

    // The Dependency
    private Inventory _inventory;
    private void Start()
    {
        _inventory = FindObjectOfType<Inventory>();
        if (_inventory == null)
        {
            Debug.Log("No inventory found");
        }
    }
    private void Update()
    {
        var type1Count = _inventory.GetCount("Tile_1");
        type1CountText.text = type1Count.ToString();
        
        var type2Count = _inventory.GetCount("Tile_2");
        type2CountText.text = type2Count.ToString();
    }
}
