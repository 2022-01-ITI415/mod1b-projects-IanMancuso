using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreGT;
    public int score = 0;                                         
    void Start() {
        // Find a reference to the ScoreCounter GameObject
        GameObject scoreGO = GameObject.Find("ScoreCounter");              
        // Get the Text Component of that GameObject
        scoreGT = scoreGO.GetComponent<Text>();                            
        // Set the starting number of points to 0
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score += score;
        scoreGT.text = score.ToString();
    }
}
