using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tooltip : MonoBehaviour {

    private Item item;
    private string data;
    GameObject tooltip;

    void Start ()
    {
        tooltip = GameObject.Find("Tooltip");
        tooltip.SetActive(false);
        Debug.Log("Finished Start");
    }

    void Update ()
    {
        if (tooltip.activeSelf)
        {
            Debug.Log("Updated");
            tooltip.transform.position = Input.mousePosition;
        }
    }

    public void Activate(Item item)
    {
        Debug.Log("Activated");
        this.item = item;
        ConstructString();
        tooltip.SetActive(true);
    }

    public void Deactivate()
    {
        tooltip.SetActive(false);
    }

    public void ConstructString()
    {
        if (item.Type == "Weapon")
        {
            data = "<color=#45CCB8>" + item.Title + "</color>\n" + item.Desc + "\n" + item.Variant + "\nDamage: " + item.Damage;
        }

        if (item.Type == "Armour")
        {
            data = "<color=#45CCB8>" + item.Title + "</color>\n" + item.Desc + "\n" + item.Variant + "\nArmour: " + item.Armour;
        }
        
        tooltip.transform.GetChild(0).GetComponent<Text>().text = data;
    }
}
