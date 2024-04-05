

using TMPro;
using Unity.Mathematics;
using UnityEngine;

using Vector3 = UnityEngine.Vector3;


public class PlayerShot : MonoBehaviour
{
    [SerializeField] public Transform _posFire;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private TextMeshProUGUI _quantityBulletText;
    [SerializeField] 
    private int _quantityBullet;
    public int quantityBullet
    {
        get => _quantityBullet;
        set
        {
            _quantityBullet = value;
            _quantityBulletText.text = _quantityBullet.ToString();
        }
    }
    
    public bool _activeFire;
    public float timeShot;
    private float nexShot;
    public static GameObject cool;
    public int damag;
    public Vector3 target;
    public Transform ak;
    public Transform bone;
     public Transform player;

    private void Awake() {
        _quantityBulletText.text = quantityBullet.ToString();
    }
    private void Update()
    {
       
        if(_activeFire){

            if(cool.transform.position.x < transform.position.x)
            {
                player.eulerAngles = Vector3.zero;       
            }
            else
            {
                player.eulerAngles = new Vector3(0, 180, 0);
            }

            Vector3 from = bone.transform.up;
            Vector3 to = cool.transform.position - bone.position;
            float angle = Vector3.SignedAngle(from, to, bone.transform.forward);
            bone.transform.rotation = Quaternion.Lerp(bone.transform.rotation, Quaternion.Euler(bone.eulerAngles.x, bone.eulerAngles.y, bone.eulerAngles.z+angle), 2f*Time.deltaTime);
        }
    }

    public void Fire()
    {
         if (target != null)
        {
            if (Time.time > nexShot)
            {
                nexShot = Time.time + timeShot;
                if (_activeFire)
                {
                    Instantiate(_bullet, _posFire.position, _posFire.rotation);
                    quantityBullet--;

                if (quantityBullet <= 0)
                {
                    _activeFire = false;
                }
                }
            }
        }
        
    }

   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<HpEnemy>(out var enemys))
        {
            _activeFire = true;
            cool = enemys.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent<HpEnemy>(out var enemys)){

            _activeFire = false;
            bone.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
