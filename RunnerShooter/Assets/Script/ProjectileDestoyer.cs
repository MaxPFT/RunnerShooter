using UnityEngine;

public class ProjectileDestoyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 || collision.gameObject.layer == 6 || collision.gameObject.layer == 7 || collision.gameObject.layer == 8)
        {
            return;
        }
        if (collision.gameObject.layer == 9)
        {
            Destroy(collision.gameObject);
        }

    }

}
