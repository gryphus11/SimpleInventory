using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInventory : MonoBehaviour
{
    public List<CItem> characterItems = new List<CItem>();
    public CItemDatabase itemDatabase = null;
    public CUiInventory inventoryUI = null;

    private void Start()
    {
        GiveItem(2);
        GiveItem(1);
        RemoveItem(2);
    }

    public void GiveItem(int id)
    {
        CItem itemToAdd = itemDatabase.GetItem(id);

        if (itemToAdd != null)
        {
            characterItems.Add(itemToAdd);
            inventoryUI.AddNewItem(itemToAdd);
            Debug.Log("Added Item : " + itemToAdd.title);
        }
        else
        {
            Debug.Log("Not Found Item");
        }
    }

    public void GiveItem(string name)
    {
        CItem itemToAdd = itemDatabase.GetItem(name);

        if (itemToAdd != null)
        {
            characterItems.Add(itemToAdd);
            inventoryUI.AddNewItem(itemToAdd);
            Debug.Log("Added Item : " + itemToAdd.title);
        }
        else
        {
            Debug.Log("Not Found Item");
        }
    }

    public CItem CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }

    public CItem CheckForItem(string name)
    {
        return characterItems.Find(item => item.title == name);
    }

    public void RemoveItem(int id)
    {
        CItem itemToRemove = CheckForItem(id);

        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            inventoryUI.RemoveItem(itemToRemove);
            Debug.Log("Removed Item : " + itemToRemove.title);
        }
    }

    private void OnDestroy()
    {
        Debug.Log("Inventory Destroy!");
        characterItems.Clear();
        characterItems = null;
    }
}
