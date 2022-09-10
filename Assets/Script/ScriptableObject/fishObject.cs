using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New fish Object", menuName = "Inventory System/Items/fish")]
public class fishObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.fish;
    }
}
