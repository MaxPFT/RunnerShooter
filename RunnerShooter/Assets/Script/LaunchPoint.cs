using System.Collections.Generic;
using UnityEngine;

public class LaunchPoint : MonoBehaviour
{
    [SerializeField] private GameObject m_projectile;
    [SerializeField] private float m_projectileSpeed;
    [SerializeField] private float m_time;

    [SerializeField] private Color[] m_color;
    [SerializeField] private Sprite[] m_weaponColor;
    [SerializeField] private SpriteRenderer m_spriteRenderer;

    private Vector3 m_mousePosition; 
    private Vector2 m_dir;
    private float m_lookAngle;
    private int m_indexProjectile = 0;


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
            m_indexProjectile--;
            if (m_indexProjectile < 0) 
            { 
                m_indexProjectile = m_color.Length - 1; 
               
            }
            m_spriteRenderer.sprite = m_weaponColor[m_indexProjectile];

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            m_indexProjectile = (m_indexProjectile + 1) % m_color.Length;
            m_spriteRenderer.sprite = m_weaponColor[m_indexProjectile];
        }

        

    }

    private void Shoot()
    {
        GameObject _projectileClone = Instantiate(m_projectile);
        _projectileClone.transform.position = transform.position;
        _projectileClone.transform.rotation = Quaternion.Euler(0, 0, m_lookAngle);
        _projectileClone.GetComponent<Rigidbody2D>().velocity = transform.up * m_projectileSpeed;
        _projectileClone.GetComponent<SpriteRenderer>().color = m_color[m_indexProjectile];
        _projectileClone.GetComponent<ColorDetector>().color = m_indexProjectile;
        Destroy(_projectileClone, m_time);
    }



}
