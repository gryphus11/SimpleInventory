using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CUiItem : MonoBehaviour
{
    public CItem item = null;
    private Image _spriteImage = null;

    private void Awake()
    {
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
}
