using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyTileManager : MonoBehaviour
{
    public Vector2 gridPosition;
    public GameObject highlight;

    public void SetUp(Vector2 _pos)
    {
        gridPosition = _pos;
    }

    public void OnMouseEnter()
    {
        Debug.Log("onmouseenter");
        highlight.SetActive(true);
    }

    public void OnMouseExit()
    {

        //check if window is open
        highlight.SetActive(false);
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
