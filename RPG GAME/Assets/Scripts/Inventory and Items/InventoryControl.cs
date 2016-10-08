using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventoryControl : MonoBehaviour {

    public GameObject inventoryPanel;
    private bool IsActive = false;

	void Update () 
    {
	    if (Input.GetButtonDown("Inventory"))
        {
            IsActive = !IsActive;
        }
        inventoryPanel.SetActive(IsActive);
	}
}
