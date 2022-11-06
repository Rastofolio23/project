using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    Text score;
    public static int scoreValue;
   
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = GameObject.FindGameObjectsWithTag("Differences").Length;
       score = GetComponent<Text> ();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue.ToString();
        
    }

   
}
