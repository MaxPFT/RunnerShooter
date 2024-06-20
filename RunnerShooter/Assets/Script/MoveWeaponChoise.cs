using UnityEngine;

public class MoveWeaponChoise : MonoBehaviour
{
    [SerializeField] private GameObject[] m_rectTransformPositionOfWeapon;

    private int m_index;
    private RectTransform m_rectTransform;
    




    // Start is called before the first frame update
    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            m_rectTransformPositionOfWeapon[m_index].SetActive(false);
            m_index--;
            if (m_index < 0)
            {
                m_index = m_rectTransformPositionOfWeapon.Length - 1;
            }
            m_rectTransformPositionOfWeapon[m_index].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            m_rectTransformPositionOfWeapon[m_index].SetActive(false);
            m_index = (m_index + 1) % m_rectTransformPositionOfWeapon.Length;
            m_rectTransformPositionOfWeapon[m_index].SetActive(true);


        }
    }
}
