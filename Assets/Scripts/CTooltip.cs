using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTooltip : MonoBehaviour
{
    private Text _tooltipText = null;

    // Use this for initialization
    void Start()
    {
        _tooltipText = GetComponentInChildren<Text>();
        gameObject.SetActive(false);
    }

    public void GenerateTooltip(CItem item)
    {
        string statText = "";
        if (item.stats.Count > 0)
        {
            foreach (var stat in item.stats)
            {
                statText += stat.Key + " : " + stat.Value + "\n";
            }
        }

        string tooltip = string.Format("<b>{0}</b>\n{1}\n\n<b>{2}</b>", item.title, item.description, statText);

        _tooltipText.text = tooltip;
        gameObject.SetActive(true);
    }
}
