using UnityEngine;
using UnityEngine.UI;

public class HpEnemy : MonoBehaviour
{
    [SerializeField] public float healf;
    [SerializeField] public float FullHealf;
    [SerializeField] public Slider helfBar;
    [SerializeField] private GameObject[] item;

    void OnEnable()
    {
        helfBar.value = healf;
    }

    public void TakeDamage(int damage)
    {
        healf -= damage;
        helfBar.value = healf;
        if(healf <= 0)
        {
            int randomItem = Random.Range(0, item.Length);
            Instantiate(item[randomItem], transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
