using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private HpPlayer _player;
    [SerializeField] private float _offsetX;
    [SerializeField] private float _offsetY;
    [SerializeField] private float _offsetZ;

    private void Awake() {
        _player = FindAnyObjectByType<HpPlayer>();
    }

    private void Update() {
        if(_player == null)
        return;
        transform.position = new Vector3(_player.transform.position.x+_offsetX, _player.transform.position.y+_offsetY, _player.transform.position.z+_offsetZ);
    }
}
