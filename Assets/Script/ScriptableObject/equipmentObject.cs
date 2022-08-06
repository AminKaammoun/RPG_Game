using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public class equipmentObject : ItemObject
{
    public int attack;
    public int Defence;
    public int Agility;
    public int hp;
    public int SP;
    private void Awake()
    {
        type = ItemType.Equipment;
    }
}
