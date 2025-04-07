using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
       if (GameObject.FindGameObjectWithTag("Player") != null) 
       {
        score +=1 *Time.deltaTime;
        scoreText.text=((int)score).ToString();
       }
    }
}
