using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOff : MonoBehaviour
{
    [SerializeField] GameObject[] lights;

    public void OffLight()
    {
        foreach (GameObject light in lights)
        {
            light.SetActive(false);
        }
    }

}
