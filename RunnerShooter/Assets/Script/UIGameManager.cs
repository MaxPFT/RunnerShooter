using TMPro;
using UnityEngine;

public class UIGameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TimerText;
    private float ElapsedTime;

    void Update()
    {
        ElapsedTime += Time.deltaTime;

        // Calcule des minutes et sencondes pour le timer
        int minutes = Mathf.FloorToInt(ElapsedTime / 60);
        int seconds = Mathf.FloorToInt(ElapsedTime % 60);

        // Mode d'affichage défini pour le timer
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
