using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Menu : MonoBehaviour
{
    public TMP_Text position;

    public void setUp(EmptyTileManager _menu)
    {
        position.gameObject.SetActive(true);
        Debug.Log("here");
        position.text = "Location:" + _menu.gridPosition;
    }

    
}
