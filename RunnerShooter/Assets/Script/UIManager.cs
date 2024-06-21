using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonForStartEasyGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void ButtonForStartMediumGame()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void ButtonForStartHardGame()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }








    public void ButtonForStartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonForRestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void ButtonForQuitGame()
    {
        Application.Quit();
    }


}
