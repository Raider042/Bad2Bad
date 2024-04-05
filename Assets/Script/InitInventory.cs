using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitInventory : MonoBehaviour
{
    private void Start() {
        gameObject.SetActive(false);
        Destroy(this);
    }
}
