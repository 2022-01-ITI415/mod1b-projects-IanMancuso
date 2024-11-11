using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Levelgen : MonoBehaviour
{
    // Start is called before the first frame update
    public int grid_size = 10;
    public int num_tiles = 19;
    Vector2 center_tile;
    Dictionary<Vector2,int> grid = new Dictionary<Vector2, int>();
    Vector2 position;
    String level = "";

    public GameObject cube;
    public GameObject player;

    Vector2 new_tile;
    void Start() {
        Console.WriteLine("WriteLine");
        Debug.Log("Debug");
        for( int x = -1; x <= grid_size; x++){
            for(int y = -1; y <= grid_size; y++){
                position = new Vector2(x,y);
                grid[position] = 0;
            }
        }
        center_tile = new Vector2(Mathf.Floor(grid_size/2),Mathf.Floor(grid_size/2));
        grid[center_tile] = 1;

        for(int i = 0; i < num_tiles; i++){
            switch(Random.Range(0,4)){
                case 0:
                    position = new Vector2(0,Random.Range(0,10));
                    break;
                case 1:
                    position = new Vector2(9,Random.Range(0,10));
                    break;
                case 2:
                    position = new Vector2(Random.Range(0,10),0);
                    break;
                case 3:
                    position = new Vector2(Random.Range(0,10),9);
                    break;
                default:
                    break;
            }
            while (grid[position] != 1)
            {
                switch (Random.Range(0, 4))
                {
                    case 0:
                        if (position.y == 9)
                        {
                            position.y -= 1;
                        }
                        else
                        {
                            position.y += 1;
                        }
                        break;
                    case 1:
                        if (position.y == 0)
                        {
                            position.y += 1;
                        }
                        else
                        {
                            position.y -= 1;
                        }
                        break;
                    case 2:
                        if (position.x == 9)
                        {
                            position.x -= 1;
                        }
                        else
                        {
                            position.x += 1;
                        }
                        break;
                    case 3:
                        if (position.x == 0)
                        {
                            position.x += 1;
                        }
                        else
                        {
                            position.x -= 1;
                        }
                        break;
                    default:
                        break;
                }
                if (grid[new Vector2(position.x + 1, position.y)] == 1 || grid[new Vector2(position.x - 1, position.y)] == 1 || grid[new Vector2(position.x, position.y + 1)] == 1 || grid[new Vector2(position.x, position.y - 1)] == 1)
                {
                    grid[position] = 1;
                }
            }
            
        }
        for(int row = 0; row < grid_size; row++)
        {
            for(int column = 0; column < grid_size; column++)
            {
                if (grid[new Vector2(row, column)] == 1)
                {
                    level += "#";
                    Instantiate(cube, new Vector3(row, 0, column), Quaternion.identity);
                } else
                {
                    level += "_";
                }
            }
            level += "\n";
        }

        Debug.Log(level);
        player.transform.position = new Vector3(Mathf.Floor(grid_size/2),1,Mathf.Floor(grid_size/2));
        transform.position += new Vector3(Mathf.Floor(grid_size/2),0,Mathf.Floor(grid_size/2));
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
