using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{

    public static GameControl instance;
    public bool gameOver = false;
    public bool started = false;

    public static float fuelcount;

    public TextMesh scoreText;
    public GameObject gameovertext;

    public int Score = 0;
    public int num = 0;

    public TextMesh best;
    public int highscore = 0;
    public int count = 0;

    public float scrollSpeed = -3f;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            highscore = PlayerPrefs.GetInt("high", highscore);
            count = PlayerPrefs.GetInt("coun", count);
            Score = 0;
            
            //oxygenBar.Setsize(0.8f);
            
        }
        else if (instance != this)
        {
            Destroy(gameObject);

        }
    }


   public void Scored()
    {
        if(gameOver)
        {
            return;
        }
        if (Score < 0)
        {
            Score = 0;
        }
        else
        {
            Score++;
            scoreText.text = "SCORE: " + Score;
        }

    }

    public void Die() 
    {
        gameOver = true;
        gameovertext.SetActive(true);
        count++;
        

        if(count > 7)
        {
            AdControl.instance.Display_Inter();
            count = 0;
        }

        if (Score > highscore)
        {
            highscore = Score;
            PlayerPrefs.SetInt("high", highscore);
        }
        best.text = "BEST:" + highscore;
        PlayerPrefs.SetInt("coun", count);
    }


  


    // Update is called once per frame
    void Update()
    {
        if(num == 0)
        {
            Score = 0;
            num++;
        }
       
       

    }

}
