using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverScript : MonoBehaviour
{
    public TimerSettings timerSettings;
    public int nextSceneLoad;

   

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    // Start is called before the first frame update
    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
            SceneManager.LoadScene("Mainmenu");
    }
    
    public void TryAgain()
    {
        Application.LoadLevel(Application.loadedLevelName);
      
        
    }
    public void NextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            Debug.Log("TO BE CONTINUE...");
        }
        else
        {
            SceneManager.LoadScene(nextSceneLoad);
            if (timerSettings.WinGame == true)
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
       
    }
}
