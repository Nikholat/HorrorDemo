using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    [SerializeField] Transform camPosition;
    void Update()
    {
        transform.position = camPosition.position;
    }
}
