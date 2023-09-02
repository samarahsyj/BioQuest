using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript Instance;

    public int cash = 20000;
    public int co2Level;
    public int landPollution;
    public int energy;

    const int energyPerSecond = 546;
    const int trashPerSecond = 12;
    const int cashPerSecond = 105;



    public int landPollutionCeiling = 5000;
    public int co2Ceiling = 2500;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }

    public void MakeCash(int cost, EmptyTileManager _tobuild)
    {
        cash -= cost;
    }
}


