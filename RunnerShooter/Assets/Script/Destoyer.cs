using UnityEngine;
using static UnityEditor.Progress;

public class Destoyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //je vais avoir besoin de ceci
        //item.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            Destroy(collision.gameObject);
        }
    }
}
