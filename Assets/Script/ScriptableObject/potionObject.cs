using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Potion Object", menuName = "Inventory System/Items/Potion")]
public class potionObject : ItemObject
{
    public int restoreHealthValue;
    private void Awake()
    {
        type = ItemType.Potion;
    }
}
