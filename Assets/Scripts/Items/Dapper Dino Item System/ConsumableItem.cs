﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[CreateAssetMenu(fileName = "New Consumable Item", menuName = "Items/Consumable")]
public class ConsumableItem : InventoryItem
{
    [Header("Consumable Data")]
    [SerializeField] private string useText = "Does something";


    public override string GetInfoDisplayText()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append(Name).AppendLine();
        builder.Append("<color=green>Use: ").Append(useText).Append("</color").AppendLine();
        builder.Append("Max Stack: ").Append(MaxStack).AppendLine();
        builder.Append("Sell Price: ").Append(SellPrice).Append(" Gold");

        return builder.ToString();
    }
}
