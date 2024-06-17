using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D m_rb2D;

    [Header("-- Jump --")]
    [SerializeField] private float m_jump;
    [SerializeField] private float m_checkGroundRadius;
    [SerializeField] private Transform m_groundCheckTransform;
    [SerializeField] private LayerMask m_groundLayerMask;
    private bool m_isGrounded;
    [Header("-- Movement --")]
    [SerializeField] private float m_speed;


    // Start is called before the first frame update
    void Start()
    {
        m_rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_isGrounded = Physics2D.OverlapCircle(m_groundCheckTransform.position, m_checkGroundRadius, m_groundLayerMask);

        Jump();
        Movement();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && m_isGrounded)
        {
            m_rb2D.AddForce(new Vector2(m_rb2D.velocity.x, m_jump));
        }
    }
    private void Movement()
    {
        transform.position = Vector3.right * m_speed * Time.deltaTime + transform.position;
    }


}
