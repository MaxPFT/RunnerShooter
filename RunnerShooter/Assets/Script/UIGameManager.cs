using TMPro;
using UnityEngine;

public class UIGameManager : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private TextMeshProUGUI m_timerText;
    [SerializeField] private TextMeshProUGUI m_showScore;
    [SerializeField] private TextMeshProUGUI m_highScore;


    [Header("Score")]
    [SerializeField] private int m_timerScore;

    [Header("Other")]
    public int m_globalScore;
    private float ElapsedTime;
    private float m_time = 1;
    private float m_maxTime = 1;


    void Update()
    {
        ElapsedTime += Time.deltaTime;

        // Calcule des minutes et sencondes pour le timer
        int minutes = Mathf.FloorToInt(ElapsedTime / 60);
        int seconds = Mathf.FloorToInt(ElapsedTime % 60);

        // Mode d'affichage défini pour le timer
        m_timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        m_time -= Time.deltaTime;
        if (m_time <= 0)
        {
            m_globalScore += m_timerScore;
            m_time = m_maxTime;

        }

        m_showScore.text = "Score : " + Mathf.Round(m_globalScore);
        HighScoreUpdate();

    }
    public void HighScoreUpdate() 
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (m_globalScore > PlayerPrefs.GetInt("SavedHighScore"))
            {
                PlayerPrefs.SetInt("SavedHighScore", m_globalScore);
            }
            

        }
        else
        {
            PlayerPrefs.SetInt("SavedHighScore", m_globalScore);
        }
        m_highScore.text = "High Score : " + PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}
