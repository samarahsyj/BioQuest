using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum powerType { solar, wind, hydro}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PowerTile", order = 1)]
public class PowerTypeManager : ScriptableObject
{

    // Start is called before the first frame update

    public int cost;
    public int timeToBuild;
    [TextArea(5, 10)] public string description;
    public int energyProduction;
    public int duration;
    public Sprite Image;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
