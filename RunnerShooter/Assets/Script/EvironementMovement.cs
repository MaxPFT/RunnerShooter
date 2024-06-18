using UnityEngine;

public class EvironementMovement : MonoBehaviour
{
    [Header("-- Movement --")]
    [SerializeField] private float m_speed;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        transform.position = Vector3.left * m_speed * Time.deltaTime + transform.position;
    }

    public void SetSpeed(float speed)
    {
        m_speed = speed;
    }
}
