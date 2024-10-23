using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public bool IsEKeyPressed()
    {
        return Input.GetKeyDown(KeyCode.E);
    }
}
