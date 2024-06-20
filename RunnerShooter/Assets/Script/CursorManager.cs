using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D m_cursorTexture;
    private Vector2 m_cursorHotspot;

    // Start is called before the first frame update
    void Start()
    {
        m_cursorHotspot = new Vector2(m_cursorTexture.width / 2, m_cursorTexture.height / 2);
        Cursor.SetCursor(m_cursorTexture, m_cursorHotspot, CursorMode.Auto);
    }


}
