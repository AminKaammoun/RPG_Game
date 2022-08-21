using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Material Object", menuName = "Inventory System/Items/Material")]
public class materialObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Materiel;
    }
}
