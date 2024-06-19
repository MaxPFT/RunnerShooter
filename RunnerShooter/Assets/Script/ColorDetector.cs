using UnityEngine;

public class ColorDetector : MonoBehaviour
{
    public int color;



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
        if (collision.gameObject.layer == 3 || collision.gameObject.layer == 6 || collision.gameObject.layer == 7) 
        {
            return;
        }

        var _colorIndexEnemy = collision.GetComponent<EnemyColor>().ColorIndex();
        if (color == _colorIndexEnemy)
        {
            Destroy(collision.gameObject);
        }
    }
}
