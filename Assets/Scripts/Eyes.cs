using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    [SerializeField] private Transform eyeLeft;
    [SerializeField] private Transform eyeRight;
    [SerializeField] private Transform player;
    
    void Update()
    {
        eyeLeft.LookAt(player);
        eyeRight.LookAt(player);
    }
}
