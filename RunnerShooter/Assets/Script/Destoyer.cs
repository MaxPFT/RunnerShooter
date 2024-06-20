using UnityEngine;
using UnityEngine.SceneManagement;

public class Destoyer : MonoBehaviour
{
    private int m_health;

    [SerializeField] private int m_damage;

    [SerializeField] private GameObject[] m_heathFullOnUI;
    [SerializeField] private GameObject[] m_heathBrokenOnUI;

    
    // Start is called before the first frame update
    void Start()
    {
        m_health = 3;
    }

    // Update is called once per frame
    void Update()
    {

        NoPointHealth();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == 8) 
        {
            m_health -= m_damage;
            Debug.Log(m_health);
            Destroy(collision.gameObject);
            m_heathFullOnUI[m_health].gameObject.SetActive(false);
            m_heathBrokenOnUI[m_health].gameObject.SetActive(true);

            
        }
        
    }
    private void NoPointHealth()
    {
        if (m_health < 0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }
}
