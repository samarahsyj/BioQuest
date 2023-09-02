using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyTileManager : MonoBehaviour
{
    public Vector2Int gridPosition;
    public GameObject highlight;



    public Vector2Int GridPostion { get { return gridPosition;  } }

    public void SetUp(Vector2Int _pos)
    {
        gridPosition = _pos;
    }

    public void OnMouseEnter()
    {
        Debug.Log("onmouseenter");
        highlight.SetActive(true);
    }

    public void OnMouseDown()
    {
        highlight.SetActive(true);
        Debug.Log(gridPosition);
        Instantiate(GridManager.instance.menuPrefab).setUp(this);
    }


    public void OnMouseExit()
    {
        highlight.SetActive(false);
    }

    private void OnMouseUp()
    {
        Menu[] menus = FindObjectsOfType<Menu>();

        foreach (Menu menu in menus)
        {
            Destroy(menu.gameObject);
        }

        Instantiate(GridManager.instance.menuPrefab, (Vector2)gridPosition, Quaternion.identity).setUp(this);
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
}
