using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

    public int slotsX, slotsY;
    public GUISkin skin;

    public List<Items> slots = new List<Items>();
    public List<Items> inventory = new List<Items>();
    private bool showInventory;
    private ItemDatabase database;
    private bool showTooltip;
    private string tooltip;

	void Start () 
    {
        for (int i = 0; i < (slotsX * slotsY); i++)
        {
            slots.Add(new Items());
        }
        database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();
        inventory.Add(database.items[1]);
        print(InventoryContains(1));
        RemoveItem(1);
        print(InventoryContains(1));
	}

    void Update ()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            showInventory = !showInventory;
        }
    }
	
	void OnGUI () 
    {
        tooltip = "";
        GUI.skin = skin;
        if (showInventory)
        {
            DrawInventory();
        }

        if (showTooltip)
        {
            GUI.Box(new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y, 200, 200), tooltip);
        }
	}

    void DrawInventory ()
    {
        int i = 0;
        for (int y  = 0; y < slotsY; y++)
        {
            for (int x = 0; x < slotsX; x++)
            {
                Rect slotRect = new Rect(x * 50, y * 50, 40, 40);
                //GUI.Box(slotRect, "", skin.GetStyle("Slot"));
                GUI.Box(slotRect, "");
                slots[i] = inventory[i];
                if (slots[i].itemName != null)
                {
                    GUI.DrawTexture(slotRect, slots[i].itemIcon);
                    if (slotRect.Contains(Event.current.mousePosition))
                    {
                        tooltip = CreateTooltip(slots[i]);
                        showTooltip = true;
                    }
                }
                i++;
            }
        }

    }

    string CreateTooltip(Items item)
    {
        tooltip = item.itemName;
        return tooltip;
    }

    void RemoveItem(int id)
    {
        for(int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemID ==id)
            {
                inventory[i] = new Items();
                break;
            }
        }
    }

    bool InventoryContains(int id)
    {
        foreach (Items item in inventory)
        {
            if (item.itemID == id) return true;
        }
        return false;
    }
}
