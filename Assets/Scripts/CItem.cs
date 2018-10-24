using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItem
{
    public string title = string.Empty;
    public string description = string.Empty;
    public int id = -1;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public CItem(int id, string title, string description, Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Items/" + title);
        this.stats = stats;
    }

    public CItem(CItem item)
    {
        id = item.id;
        title = item.title;
        description = item.description;
        icon = Resources.Load<Sprite>("Items/" + title);
        stats = item.stats;
    }
}
