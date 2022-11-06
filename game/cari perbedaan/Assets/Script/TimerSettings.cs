using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TimerSettings : MonoBehaviour
{

    public bool WinGame = false;
    public GameObject gameOverMenu;
    public GameObject winMenu;

    public Text textTimer;
    public float Waktu = 100;
    public bool GameAktif = true;


    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        textTimer.text = Menit.ToString("00")
        +":"+ Detik.ToString("00");
    }

    float s;

    // Update is called once per frame
    private void Update()
    {
     
        if(GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }
        if(GameAktif && Waktu <= 0)
        {
            
            Debug.Log("Kalah");
            gameOverMenu.SetActive(true);
            GameAktif = false;
        }
        if(GameAktif && ScoreScript.scoreValue == 0)
        {
            Debug.Log("menang");
            WinGame = true;
    winMenu.SetActive(true);
            GameAktif = false;
        }
       
        SetText();
        
    }
}
