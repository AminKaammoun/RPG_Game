using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Potion Object", menuName = "Inventory System/Items/plant")]
public class plantObject : ItemObject
{
   
    private void Awake()
    {
        type = ItemType.plant;
    }
}
