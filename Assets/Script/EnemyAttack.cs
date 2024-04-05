using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float _damage;
    private float maxTime;
    private float time = 2;


    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.TryGetComponent<HpPlayer>(out var playerHp))
        {
            if(Time.time > maxTime)
            {
                playerHp.GetComponent<HpPlayer>().TakeDamage(_damage);
                maxTime = Time.time + time;
            }
        }
    }
    
 

}
