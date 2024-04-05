using InventorySystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropUi : MonoBehaviour
{
    public void DropItem(Vector3 pos, InventoryItem item)
    {
        for (int i = 0; i < item.GetAmount(); i++)
        {
            Instantiate(item.GetRelatedGameObject(), pos, Quaternion.identity);
        }
    }
}
