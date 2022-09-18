using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New food Object", menuName = "Inventory System/Items/food")]

public class FoodObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Food;
    }
}