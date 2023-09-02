using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerTile : MonoBehaviour
{
    [SerializeField] SpriteRenderer theImage;
    [SerializeField] PowerTypeManager theType;

    private void SetUp(PowerTypeManager _theType)
    {
        theImage.sprite = _theType.Image;
    }


}
