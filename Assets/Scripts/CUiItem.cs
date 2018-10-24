using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CUiItem : MonoBehaviour, IPointerDownHandler
{
    public CItem item = null;
    private Image _spriteImage = null;
    private CUiItem _selectedItem = null;

    private void Awake()
    {
        _selectedItem = GameObject.Find("SelectedItem").GetComponent<CUiItem>();
        _spriteImage = GetComponent<Image>();
        UpdateItem(null);
    }

    public void UpdateItem(CItem item)
    {
        this.item = item;
        if (this.item != null)
        {
            _spriteImage.color = Color.white;
            _spriteImage.sprite = item.icon;
        }
        else
        {
            _spriteImage.color = Color.clear;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (item != null)
        {
            if (_selectedItem.item != null)
            {
                CItem itemClone = new CItem(_selectedItem.item);

                Debug.Log(gameObject.transform.parent.name + "  Current Item : " + item.title + "  " + "Selected Item : " + itemClone.title);

                _selectedItem.UpdateItem(item);
                UpdateItem(itemClone);
            }
            else
            {
                Debug.Log(gameObject.transform.parent.name + "  Current Item : " + item.title + " Selected Item : Nothing");

                _selectedItem.UpdateItem(item);
                UpdateItem(null);
            }
        }
        else if (_selectedItem.item != null)
        {
            Debug.Log(gameObject.transform.parent.name + "  Current Item : Nothing  Selected Item : " + _selectedItem.item.title);

            UpdateItem(_selectedItem.item);
            _selectedItem.UpdateItem(null);
        }
        else
        {
            Debug.Log(gameObject.transform.name + "No Items");
        }
    }
}
