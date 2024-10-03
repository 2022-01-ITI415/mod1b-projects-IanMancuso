using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelgen : MonoBehaviour
{
    // Start is called before the first frame update
    public int grid_size = 10;
    public int num_tiles = 10;
    Vector2() center_tile = Vector2()
    Dictionary grid = new Dictionary();
    Vector2() position =  new Vector2();

    Vector2() new_tile = new Vector2();
    void Start()
    {
        for( int x = 0; x < grid_size; x++){
            for(int y = 0; y < grid_size; y++){
                position = Vector2(x,y);
                grid(position) = 0;
            }
        }
        center_tile = Vector2(Math.Floor(grid_size/2),Math.Floor(grid_size/2));
        grid(center_tile) = 1;

        for(int i = 0; i < num_tiles; i++){
            switch(Random.Range(0,4)){
                case 0:
                    position = Vector2(0,Random.Range(0,10));

                case 1:
                    position = Vector2(9,Random.Range(0,10));

                case 2:
                    position = Vector2(Random.Range(0,10),0);
                
                case 3:
                    position = Vector2(Random.Range(0,10),9);
            }

            switch(Random.Range(0,4)){
                case 0:
                    if (position.y == 9){
                        position.y -= 1
                    } else {
                        position.y += 1
                    }
                case 1:
                    if (position.y == 0){
                        position.y += 1
                    } else {
                        position.y -= 1
                    }
                case 2:
                    if (position.x == 9){
                        position.x -= 1
                    } else {
                        position.x += 1
                    }
                case 3:
                    if (position.x == 0){
                        position.x += 1
                    } else {
                        position.x -= 1
                    }
            }
        }

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
