using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;
public class Dropper : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject   dropPrefab;
 // Speed at which the AppleTree moves
    //public float        speed = 0f;
 // Whether the Dropper is moving on the x or z axis
    //public int          direction = 0;
 // Distance where AppleTree turns around
    //public float        leftAndRightEdge = 9f;
 // Chance that the AppleTree will change directions
    //public float        chanceToChangeDirections = 0.001f;
 // Rate at which Apples will be instantiated
    public float        secondsBetweenAppleDrops = 1f;
 void Start () {
        // Dropping apples every second
        Invoke( "Drop", 2f );
    }

void Drop() {      
        Vector3 pos = transform.position;                                            
        GameObject drop = Instantiate<GameObject>( dropPrefab );     
        drop.transform.position = transform.position;                  
        Invoke( "Drop", secondsBetweenAppleDrops );
        pos.x = Random.Range(-9,9);
        pos.z = Random.Range(-9,9);
        transform.position = pos;            
    }

 void Update () {
        // Basic Movement
        /**
        Vector3 pos = transform.position;
        switch (direction)
        {
            case 0:
                pos.x += speed * Time.deltaTime; 
                break;
            case 1:
                pos.z += speed * Time.deltaTime; 
                break;
            case 2:
                pos.x += (speed * -1) * Time.deltaTime;
                break;
            case 3:
                pos.z += (speed * -1) * Time.deltaTime;
                break;
            default:
                break;
        }
               
    
               
                     
        //transform.position = pos;                          
        // Changing Direction
        if ( pos.x < -leftAndRightEdge ) {                          
           direction = 0;                   
       } else if ( pos.x > leftAndRightEdge ) {                      
            direction = 2;                 
       } else if (pos.z < -leftAndRightEdge) {
           direction = 1;
       } else if(pos.z > leftAndRightEdge) {
           direction = 3;
       }*/
    }
void FixedUpdate() {
        // Changing Direction Randomly is now t
        //if ( Random.value < chanceToChangeDirections) {
        //    direction = Random.Range(0, 3);
        //}
    }

}