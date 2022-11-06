using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

   public void startFunction()
    {
        SceneManager.LoadScene("runner1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
   
}
