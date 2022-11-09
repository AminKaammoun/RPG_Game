using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New egg Object", menuName = "Inventory System/Items/eggs")]
public class eggObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.egg;
    }
}
