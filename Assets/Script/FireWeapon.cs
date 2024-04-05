using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    [SerializeField] private float _speadBullet;
    public PlayerShot pl;

    public Transform targets;
    public Rigidbody2D rb;
    public int damage;
    public GameObject coll;

    public void FixedUpdate()
    {
       transform.position = Vector2.MoveTowards(transform.position, PlayerShot.cool.transform.position,_speadBullet); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HpEnemy enemy = collision.GetComponent<HpEnemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
