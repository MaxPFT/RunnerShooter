using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [Header("-- Spawner --")]
    [SerializeField] private GameObject[] m_ground;
    [SerializeField] private float m_distanceBetweenNewGround;
    private bool m_hasGround;

    [Header("-- Timer --")]
    [SerializeField] private float m_timer;
    [SerializeField] private float m_maxTimer;

    [Header("-- Speed --")]
    [SerializeField] private float m_speed;
    [SerializeField] private float m_addSpeed;

    [SerializeField] private List<EnvironementMovement> m_listGameObject = new List<EnvironementMovement>(); 


    // Start is called before the first frame update
    void Start()
    {
        m_timer = m_maxTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_hasGround)
        {
            SpawnGround();
            m_hasGround = true;
        }
        m_timer -= Time.deltaTime;
        if (m_timer < 0f) 
        {
            m_speed = m_speed + m_addSpeed;
            UpdateSpeed(m_speed);
            m_timer = m_maxTimer;
        }

    }

    private void SpawnGround()
    {
        int _randomNum = Random.Range(1, 3);


        if (_randomNum == 1)
        {
            var item = Instantiate(m_ground[0], new Vector3(transform.position.x + m_distanceBetweenNewGround, -12, 0), Quaternion.identity);
            var script = item.GetComponent<EnvironementMovement>();
            script.SetSpeed(m_speed);
            m_listGameObject.Add(script);
        }
        if (_randomNum == 2)
        {
            var item = Instantiate(m_ground[1], new Vector3(transform.position.x + m_distanceBetweenNewGround, -10, 0), Quaternion.identity);
            var script = item.GetComponent<EnvironementMovement>();
            script.SetSpeed(m_speed);
            m_listGameObject.Add(script);
        }
        if (_randomNum == 3)
        {
            var item = Instantiate(m_ground[2], new Vector3(transform.position.x + m_distanceBetweenNewGround, -8, 0), Quaternion.identity);
            var script = item.GetComponent<EnvironementMovement>();
            script.SetSpeed(m_speed);
            m_listGameObject.Add(script);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            m_hasGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            m_hasGround = false;
        }
    }

    public void UpdateSpeed(float newSpeed)
    {
        foreach (var item in m_listGameObject)
        {
            item.SetSpeed(newSpeed);
        }
    }


}
