using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] int xsize, ysize;
    public EmptyTileManager[,] grid;
    [SerializeField] EmptyTileManager _emptyPrefab;
    [SerializeField] HouseTileManager _housePrefab;
    public HouseTileManager[] house_grid;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    public void GenerateGrid()
    {


        grid = new EmptyTileManager[xsize, ysize];
        house_grid = new HouseTileManager[xsize];

        for (int x = 0; x < xsize; x++)
        {
            for (int y = 0; y < ysize; y++)
            {
                grid[x, y] = Instantiate(_emptyPrefab, new Vector2(x + 0.5f, y + 0.5f), Quaternion.identity);
                grid[x, y].SetUp(new Vector2(x, y));
            }


        }

        

        for (int x = 0; x < xsize; x++)
        {
            house_grid[x] = Instantiate(_housePrefab, new Vector2(x+0.5f, ysize + 0.5f), Quaternion.identity);
            house_grid[x].SetUp(new Vector2(x, ysize));
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
