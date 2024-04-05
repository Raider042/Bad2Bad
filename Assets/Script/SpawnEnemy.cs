using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Transform _enemy;
    public Collider2D spawnPos;
    
    [SerializeField] private int _quantityEnemy;

    private void Start() {
       Spawn();
    }
    public void Spawn()
    {
         for (int i = 0; i < _quantityEnemy; i++)
        {
            float randomX = Random.Range(spawnPos.bounds.min.x, spawnPos.bounds.max.x);
            float randomY = Random.Range(spawnPos.bounds.min.y, spawnPos.bounds.max.y);
        
            Vector2 randomPosition = new Vector2(randomX, randomY);    
            Instantiate(_enemy, randomPosition, Quaternion.identity);
        }
       
    }
}
