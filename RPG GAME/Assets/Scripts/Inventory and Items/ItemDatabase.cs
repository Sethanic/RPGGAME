using UnityEngine;
using System.Collections.Generic;
using System.IO;
using LitJson;

public class ItemDatabase : MonoBehaviour {
    private List<Item> database = new List<Item>();
    private JsonData itemData;
    SaveInformation information;

    void Start ()
    {
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
        ConstructItemDatabase();
        information.Save();
    }

    public Item FetchItemByID(int id)
    {
        for (int i = 0; i < database.Count; i++) 
        {
            if (database[i].ID == id)
            {
                return database[i];
            }
        }
        return null;
    }

    void ConstructItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            database.Add(new Item((int)itemData[i]["id"], 
            itemData[i]["title"].ToString(),
            itemData[i]["slug"].ToString(),
            itemData[i]["type"].ToString(),
            itemData[i]["variant"].ToString(),
            itemData[i]["desc"].ToString(),
            (bool)itemData[i]["stackable"],
            (int)itemData[i]["value"],
            (int)itemData[i]["rarity"],
            (int)itemData[i]["trait"],
            (int)itemData[i]["stats"]["damage"],
            (int)itemData[i]["stats"]["armour"]));
        }
    }
}

public class Item
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public string Type { get; set; }
    public string Variant { get; set; }
    public string Desc { get; set; }
    public bool Stackable { get; set; }
    public int Value { get; set; }
    public int Rarity { get; set; }
    public int Trait { get; set; }
    public int Damage { get; set; }
    public int Armour { get; set; }
    public Sprite Sprite { get; set; }

    public Item(int id, string title, string slug, string type, string variant, string desc, bool stackable, int value, int rarity, int trait, int damage, int armour)
    {
        this.ID = id;
        this.Title = title;
        this.Slug = slug;
        this.Type = type;
        this.Variant = variant;
        this.Desc = desc;
        this.Stackable = stackable;
        this.Value = value;
        this.Rarity = rarity;
        this.Trait = Trait;
        this.Damage = damage;
        this.Armour = armour;
        this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug);
    }

    public Item()
    {
        this.ID = -1;
    }
}
