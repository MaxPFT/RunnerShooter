using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] m_ground;
    [SerializeField] private float m_distanceBetweenNewGround;
    private bool m_hasGround;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_hasGround)
        {
            SpawnGround();
            m_hasGround = true;
        }
    }

    private void SpawnGround()
    {
        int _randomNum = Random.Range(1, 3);

        if (_randomNum == 1)
        {
            Instantiate(m_ground[0], new Vector3(transform.position.x + m_distanceBetweenNewGround, 0, 0), Quaternion.identity);
        }
        if (_randomNum == 2)
        {
            Instantiate(m_ground[1], new Vector3(transform.position.x + m_distanceBetweenNewGround, 2, 0), Quaternion.identity);
        }
        if (_randomNum == 3)
        {
            Instantiate(m_ground[2], new Vector3(transform.position.x + m_distanceBetweenNewGround, 4, 0), Quaternion.identity);
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
