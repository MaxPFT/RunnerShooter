using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D m_rb2D;

    [Header("-- Jump --")]
    [SerializeField] private float m_jump;
    [SerializeField] private float m_checkGroundRadius;
    [SerializeField] private Transform m_groundCheckTransform;
    [SerializeField] private LayerMask m_groundLayerMask;
    private bool m_isGrounded;


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

        if (transform.position.y <= -20)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && m_isGrounded)
        {
            m_rb2D.AddForce(new Vector2(m_rb2D.velocity.x, m_jump));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3 || collision.gameObject.layer == 6 || collision.gameObject.layer == 7 || collision.gameObject.layer == 9)
        {
            return;
        }
        if (collision.gameObject.layer == 8)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }


}
