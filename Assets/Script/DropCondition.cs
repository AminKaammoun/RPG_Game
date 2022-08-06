using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DropCondition : MonoBehaviour
{
    public abstract bool Check(InvDraggableComponent draggble);
}
