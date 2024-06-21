using UnityEngine;

public class GroundEnemySpawner : MonoBehaviour
{
    [Header("-- Spawner --")]
    [SerializeField] private GameObject m_groundEnemy;
    [SerializeField] private GameObject[] m_groundSpawnerEnemy;
    [SerializeField] private Sprite[] m_spriteEnemy;
    private int m_randomSpawner;

    [Header("-- Color --")]
    public Color[] m_colorGroundEnemy;
    private int m_indexColorGroundEnemy = 0;



    private void Awake()
    {
        m_randomSpawner = Random.Range(0, 3);
        m_indexColorGroundEnemy = Random.Range(0, 4);
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnGroundEnemy();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnGroundEnemy()
    {
        var item = Instantiate(m_groundEnemy, m_groundSpawnerEnemy[m_randomSpawner].transform.position, Quaternion.identity);
        item.GetComponent<SpriteRenderer>().sprite = m_spriteEnemy[m_randomSpawner];
        item.transform.parent = transform;
        item.GetComponent<EnemyColor>().SetColorIndexEnemy(m_indexColorGroundEnemy);
        item.GetComponent<SpriteRenderer>().color = m_colorGroundEnemy[m_indexColorGroundEnemy];
    }
}
