using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler {
    public Item item;
    public int amount;
    public int slot;

    ItemInventory inv;
    private Tooltip tooltip;
    private Vector2 offset;

    void Start ()
    {
        inv = GameObject.Find("Inventory").GetComponent<ItemInventory>();
        tooltip = inv.GetComponent<Tooltip>();
        Debug.Log("Finished Start");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Drag began");
        if (item != null)
        {
            this.transform.SetParent(this.transform.parent.parent.parent);
            this.transform.position = eventData.position - offset;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("On Drag");
        if (item != null)
        {
            this.transform.position = eventData.position - offset;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("On End Drag");
        this.transform.SetParent(inv.slots[slot].transform);
        this.transform.position = inv.slots[slot].transform.position;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        if (item != null)
        {
            offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter");
        tooltip.Activate(item);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit");
        tooltip.Deactivate();
    }
}
