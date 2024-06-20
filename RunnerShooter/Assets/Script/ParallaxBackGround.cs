using UnityEngine;

public class ParallaxBackGround : MonoBehaviour
{
    [SerializeField] private float m_speedOfParalax;
    private Material m_material;
    // Start is called before the first frame update
    void Start()
    {
        m_material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = m_material.GetTextureOffset("_MainTex");
        offset.x += m_speedOfParalax * Time.deltaTime;
        m_material.SetTextureOffset("_MainTex", offset);
    }
}
