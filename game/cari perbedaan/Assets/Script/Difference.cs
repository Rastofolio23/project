using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Difference : MonoBehaviour
{
    
    public static event Action DiffereceClicked = delegate { };
 
    [SerializeField]
    
    private GameObject trueSprite;
    [SerializeField]
    private GameObject falseSprite;

   private SpriteRenderer spriteRender;

    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
  



    }

    private void OnMouseDown()
    {
        if (spriteRender.enabled)
        {
            ScoreScript.scoreValue -= 1;
           
            Destroy(falseSprite);
            trueSprite.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            trueSprite.GetComponent<BoxCollider2D>().enabled = false;
            DiffereceClicked();
        }
        else
        {
            ScoreScript.scoreValue -= 1;
            
            Destroy(falseSprite);
            trueSprite.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            trueSprite.GetComponent <BoxCollider2D>().enabled = false;
            DiffereceClicked();
        }
    }

    void Update()
    {
        if(ScoreScript.scoreValue == 0)
        {
           
        }
    }

}
