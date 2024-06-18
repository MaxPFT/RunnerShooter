using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using static UnityEditor.Progress;

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
            //m_distanceBetweenNewGround -= m_addSpeed;
            m_timer = m_maxTimer;
        }

    }

    private void SpawnGround()
    {
        int _randomNum = Random.Range(1, 3);


        if (_randomNum == 1)
        {
            var item = Instantiate(m_ground[0], new Vector3(transform.position.x + m_distanceBetweenNewGround, -6, 0), Quaternion.identity);
            item.GetComponent<GroundMovement>().SetSpeed(m_speed);
        }
        if (_randomNum == 2)
        {
            var item = Instantiate(m_ground[1], new Vector3(transform.position.x + m_distanceBetweenNewGround, -4, 0), Quaternion.identity);
            item.GetComponent<GroundMovement>().SetSpeed(m_speed);
        }
        if (_randomNum == 3)
        {
            var item = Instantiate(m_ground[2], new Vector3(transform.position.x + m_distanceBetweenNewGround, -2, 0), Quaternion.identity);
            item.GetComponent<GroundMovement>().SetSpeed(m_speed);
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
    

}
