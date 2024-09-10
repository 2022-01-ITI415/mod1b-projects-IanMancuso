using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
 public class Basket : MonoBehaviour {
    //[Header("Set Dynamically")]
    //public Text scoreGT;  

    public UnityEvent updateScore;                                       
    void Start() {
        updateScore.AddListener(GameObject.FindGameObjectWithTag("UI").GetComponent<ScoreTracker>().UpdateScore);
    }

 void Update () {
        // Get the current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;                             
 // The Camera's z position sets how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;                     
 // Convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );    
 // Move the x position of this Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
    void OnCollisionEnter( Collision coll ) {                        
        // Find out what hit this basket
        GameObject collidedWith = coll.gameObject;                   
        if ( collidedWith.tag == "Apple" ) {                         
            Destroy( collidedWith );
            updateScore.Invoke();
            ///int score = int.Parse( scoreGT.text );                         
            // Add points for catching the apple
            //score += 100;
            // Convert the score back to a string and display it
            //scoreGT.text = score.ToString();
            //if (score > HighScore.score) {
            //    HighScore.score = score;
            //}
        }
    }
 }