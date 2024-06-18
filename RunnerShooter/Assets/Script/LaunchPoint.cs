using System.Collections.Generic;
using UnityEngine;

public class LaunchPoint : MonoBehaviour
{
    [SerializeField] private GameObject m_projectile;
    [SerializeField] private float m_projectileSpeed;
    [SerializeField] private float m_time;

    [SerializeField] private Color[] m_color;

    private Vector3 m_mousePosition;
    private Vector2 m_dir;
    private float m_lookAngle;
    private int m_index = 0;


    // Update is called once per frame
    void Update()
    {
        m_mousePosition = Input.mousePosition;
        m_mousePosition = Camera.main.ScreenToWorldPoint(m_mousePosition);

        Vector2 m_dir = new Vector2(m_mousePosition.x - transform.position.x, m_mousePosition.y - transform.position.y);

        transform.up = m_dir;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            m_index--;
            Debug.Log(m_color[m_index]);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            m_index = (m_index + 1) % m_color.Length;
            Debug.Log(m_color[m_index]);
        }

        

    }

    private void Shoot()
    {
        GameObject _projectileClone = Instantiate(m_projectile);
        _projectileClone.transform.position = transform.position;
        _projectileClone.transform.rotation = Quaternion.Euler(0, 0, m_lookAngle);
        _projectileClone.GetComponent<Rigidbody2D>().velocity = transform.up * m_projectileSpeed;
        _projectileClone.GetComponent<SpriteRenderer>().color = m_color[m_index];
        Destroy(_projectileClone, m_time);
    }



}
