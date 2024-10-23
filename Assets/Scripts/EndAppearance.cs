using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndAppearance : MonoBehaviour
{
    [SerializeField] private GameObject end;
    private float time = 0.7f;

    public void Appear()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        LeanTween.scale(end, Vector3.one, time).setEaseInCubic();
    }
}
