using UnityEngine;

internal class EnemyColor : MonoBehaviour
{
    public int m_indexColorEnemy;
    internal void SetColorIndexEnemy(int _indexColorEnemy)
    {
        m_indexColorEnemy = _indexColorEnemy;
    }
    
    public int ColorIndex()
    {

        return m_indexColorEnemy;
    }

}