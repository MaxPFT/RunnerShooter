using UnityEngine;

public class AerialEnemySpawner : MonoBehaviour
{
    [Header("-- Spawner/Enemy --")]
    [SerializeField] private GameObject m_aerialEnemy;
    [SerializeField] private Sprite[] m_spriteEnemy;

    [Header("-- Timer --")]
    [SerializeField] private float m_timer;
    [SerializeField] private float m_minTimer;
    [SerializeField] private float m_maxTimer;

    [Header("-- Speed --")]
    [SerializeField] private float m_speed;

    public Color[] m_colorAerialEnemy;
    private int m_indexColorAerialEnemy = 0;



    // Start is called before the first frame update
    void Start()
    {
        m_timer = Random.Range(m_minTimer, m_maxTimer);
        m_indexColorAerialEnemy = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        m_timer -= Time.deltaTime;
        if (m_timer <= 0f)
        {
            SpawnAerialEnemy();
            m_timer = Random.Range(m_minTimer, m_maxTimer);
            m_indexColorAerialEnemy = Random.Range(0, 4);

        }
    }

    private void SpawnAerialEnemy()
    {
        var item = Instantiate(m_aerialEnemy, new Vector3(transform.position.x, 15, 0), Quaternion.identity);
        item.GetComponent<EnvironementMovement>().SetSpeed(m_speed);
        item.GetComponent<EnemyColor>().SetColorIndexEnemy(m_indexColorAerialEnemy);
        item.GetComponent<SpriteRenderer>().color = m_colorAerialEnemy[m_indexColorAerialEnemy];
        item.GetComponent<SpriteRenderer>().sprite = m_spriteEnemy[m_indexColorAerialEnemy];

    }


}
