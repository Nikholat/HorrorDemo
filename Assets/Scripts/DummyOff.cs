using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyOff : MonoBehaviour
{
    [SerializeField] GameObject[] Dummys;

    public void OffDummy()
    {
        foreach (GameObject light in Dummys)
        {
            light.SetActive(false);
        }
    }
}
