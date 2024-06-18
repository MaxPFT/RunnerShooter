using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("-- Spawner --")]
    [SerializeField] private GameObject m_enemy;

    [Header("-- Timer --")]
    [SerializeField] private float m_timer;
    [SerializeField] private float m_minTimer;
    [SerializeField] private float m_maxTimer;

    [Header("-- Speed --")]
    [SerializeField] private float m_speed;

    public Color[] m_color;
    private int m_indexColorEnemy = 0;



    // Start is called before the first frame update
    void Start()
    {
        m_timer = Random.Range(m_minTimer, m_maxTimer);
        m_indexColorEnemy = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        m_timer -= Time.deltaTime;
        if (m_timer <= 0f)
        {
            SpawnEnemy();
            m_timer = Random.Range(m_minTimer, m_maxTimer);
            m_indexColorEnemy = Random.Range(0, 4);

        }
    }

    private void SpawnEnemy()
    {
        var item = Instantiate(m_enemy, new Vector3(transform.position.x, 15, 0), Quaternion.identity);
        item.GetComponent<EvironementMovement>().SetSpeed(m_speed);
        item.GetComponent<EnemyColor>().SetColorIndex(m_indexColorEnemy);
        item.GetComponent<SpriteRenderer>().color = m_color[m_indexColorEnemy];
    }


}
