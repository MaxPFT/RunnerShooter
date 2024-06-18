using System;
using UnityEngine;

internal class EnemyColor : MonoBehaviour
{
    public int m_indexColorEnemy;
    internal void SetColorIndex(int _indexColorEnemy)
    {
        m_indexColorEnemy = _indexColorEnemy;
    }

    public int ColorIndexEnemy()
    {

    return m_indexColorEnemy; 
    }

}