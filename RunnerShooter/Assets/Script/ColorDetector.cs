using System;
using UnityEngine;

public class ColorDetector : MonoBehaviour
{
    public int color;
    [SerializeField] private int m_killScore;
    [SerializeField] private GameObject m_particulesEffect;
    private UIGameManager m_uiManager;

    



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
        if (collision.gameObject.layer == 3 || collision.gameObject.layer == 6 || collision.gameObject.layer == 7) 
        {
            return;
        }

        var _colorIndexEnemy = collision.GetComponent<EnemyColor>().ColorIndex();
        if (color == _colorIndexEnemy)
        {
            
            m_uiManager.m_globalScore += m_killScore;
            GameObject _particules = (GameObject)Instantiate(m_particulesEffect, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    internal void ConnectToUiManager(UIGameManager _uiManager)
    {
        m_uiManager = _uiManager;
    }
    
}
