using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEvents : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 rotation = new Vector3 (0, 10, 0);
    Vector3 currentEulerAngles;
    private int level = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (level)
        {
            case 1:
                LevelOne();
                break;
            default:
                break;
        }
    }

    void LevelOne()
    {
        //if(transform.eulerAngles.x > -20)
        //{
        //    transform.Rotate (new Vector3 (-10, 0, 0) * Time.deltaTime);
        //} else {
            transform.Rotate (rotation * Time.deltaTime);
        //}

    }
}