using System;
using UnityEngine;
using UnityEngine.AI;

public class AgentManager : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private Transform _enemy;
    private bool _activeMove;

    void FixedUpdate()
    {
        if(_activeMove && _target != null)
        {
            _enemy.transform.position = Vector2.MoveTowards(_enemy.transform.position, _target.position, _speed * Time.deltaTime);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMove>() != null)
        {
            _target = collision.transform;
            _activeMove = true;
        }
    }
}
