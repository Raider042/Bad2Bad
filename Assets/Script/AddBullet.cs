using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBullet : MonoBehaviour
{
    private PlayerShot _playerShot;
    public int addBullets;
    private void Awake() {
        _playerShot = FindAnyObjectByType<PlayerShot>();
    }
     private void OnCollisionEnter2D(Collision2D other)
     {
         if(other.gameObject.TryGetComponent<HpPlayer>(out var playerHp))
         {
             _playerShot.quantityBullet += addBullets;
         }
     }
}
