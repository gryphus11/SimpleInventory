using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItemDatabase : MonoBehaviour
{
    public List<CItem> items = new List<CItem>();

    private void Awake()
    {
        BuildDatabase();
    }

    public CItem GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public CItem GetItem(string itemName)
    {
        return items.Find(item => item.title.Equals(itemName));
    }

    private void BuildDatabase()
    {
        items = new List<CItem>()
        {
            new CItem(0, "Diamond Sword", "A sword made of diamonds.",
                new Dictionary<string, int>
                {
                    { "Power", 15},
                    {"Defence", 10}
                }),
            new CItem(1, "Diamond Ore", "A pretty diamond",
                new Dictionary<string, int>
                {
                    { "Value", 300}
                }),
            new CItem(2, "Silver Pick", "A pick that could kill a vampire",
                new Dictionary<string, int>
                {
                    { "Power", 5},
                    { "Mining", 20},
                }),
        };
    }
}
