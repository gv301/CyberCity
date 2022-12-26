using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //List of items
    [SerializeField]
    private Dictionary<string,int> items = new Dictionary<string, int>();

    [SerializeField]
    private SaveData savedata;

    [SerializeField]
    protected Sprite icon_sprite;

    private Dictionary<string, Sprite> indivisual_item = new Dictionary<string, Sprite>();

    private void Start()
    {
        // Checks if there already items saved 
        if (savedata.get_items().Count > 0)
            items = savedata.get_items();
        
    }
    public Dictionary<string, int> get_items() { return items; }

    //Add items
    public void add_item(string new_item)                                                                                           
    {
        // Adds item to inventory
        if (items.ContainsKey(new_item))
            items[new_item] += 1;
        else
            items.Add(new_item, 1);
        // Saves data into sciptable object
        savedata.set_items(this.items);                    
    }
}