using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<string> inventory;
    public int ItemsCount = 0;

    private void Update()
    {
        ItemsCount = inventory.Count;
    }

    //No need this because since Inventory is a MonoBehaviour, Unity will not call its constructor
    // public Inventory ()
    // {
    //     Debug.Log("Constructor");
    //     inventory = new List<string>();
    // }

    public int GetCount(string text) => inventory.FindAll(item => item == text).Count;
}


// For the sake of learning this is a prompt from ChatGPT --->

// If it worked without explicitly initializing inventory,
// it’s likely because Unity automatically initializes public fields in MonoBehaviour scripts when they're serialized and assigned in the Unity Editor.

// When you declare a public field in a MonoBehaviour (like public List<string> inventory;),
// Unity serializes this field, and even if you don’t assign it,
// Unity sometimes assigns a default empty instance of the list in the background.

// Here’s why that can happen:

// Unity’s Serialization: Public fields in Unity,
//                        especially those that are reference types like List<T>, are serialized when you attach the script to a GameObject.
//                        Unity will often auto-initialize these serialized fields to avoid null references, giving inventory an empty List<string> by default.
//
// The Unity Editor: If you attach the Inventory script to a GameObject in the editor and then look at it in the Inspector,
//                   Unity will allocate an empty list for inventory even if you don’t initialize it in code.
//                   This is why it might have worked without an explicit inventory = new List<string>(); in your code.


// In summary, Unity's serialization system provides an empty list for public fields like inventory in the Inspector,
// which is why your code ran without issues despite not initializing inventory directly.
// However, it’s usually safer to initialize lists yourself,
// especially if the field is private or if you plan to instantiate Inventory dynamically rather than through the Editor.
