using UnityEngine;
using UnityEngine.SceneManagement;

public class Destoyer : MonoBehaviour
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
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == 8) 
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }
}
