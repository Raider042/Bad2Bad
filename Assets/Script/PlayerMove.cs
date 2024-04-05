using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _speed;
    public PlayerShot playerShot;
    public Transform bon;
    void Update()
    {
        if(_joystick.Horizontal < 0 && !playerShot._activeFire)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (_joystick.Horizontal > 0 && !playerShot._activeFire)
        {
           transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_joystick.Horizontal * _speed, _joystick.Vertical * _speed);

    }
}
