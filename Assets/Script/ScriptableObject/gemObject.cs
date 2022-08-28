using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Gem Object", menuName = "Inventory System/Items/Gem")]
public class gemObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Gem;
    }
}
