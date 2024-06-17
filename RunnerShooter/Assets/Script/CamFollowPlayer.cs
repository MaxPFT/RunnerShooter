using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject m_player;
    private Vector3 m_offset;


    void Start()
    {
        m_offset = transform.position - m_player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(m_player.transform.position.x + m_offset.x, transform.position.y, transform.position.z);
    }
}
