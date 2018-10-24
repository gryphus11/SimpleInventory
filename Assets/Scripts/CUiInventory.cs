using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CUiInventory : MonoBehaviour
{
    public List<CUiItem> uiItems = new List<CUiItem>();
    public GameObject slotPrefab = null;
    public Transform slotPanel = null;

    private int _slotCount = 25;

    private void Awake()
    {
        for (int i = 0; i < _slotCount; ++i)
        {
            GameObject slotInstance = Instantiate(slotPrefab, slotPanel);
            uiItems.Add(slotInstance.GetComponentInChildren<CUiItem>());
        }
    }

    public void UpdateSlot(int slotIndex, CItem itemToUpdate)
    {
        uiItems[slotIndex].UpdateItem(itemToUpdate);
    }

    public void AddNewItem(CItem itemToAdd)
    {
        UpdateSlot(uiItems.FindIndex(uiItem => uiItem.item == null), itemToAdd);
    }

    public void RemoveItem(CItem itemToRemove)
    {
        UpdateSlot(uiItems.FindIndex(uiItem => uiItem.item == itemToRemove), null);
    }
}
