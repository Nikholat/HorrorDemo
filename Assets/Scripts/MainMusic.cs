using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusic : MonoBehaviour
{
    [SerializeField] private AudioSource firstMusic;
    [SerializeField] private AudioSource secondMusic;

    public void TurnOnFirst()
    {
        firstMusic.Play();
        secondMusic.Stop();
    }

    public void TurnOnSecond()
    {
        StartCoroutine(Timer());
    }

    public void SecondStop()
    {
        secondMusic.Stop();
    }

    private IEnumerator Timer()
    {
        firstMusic.Stop();
        yield return new WaitForSeconds(2);
        secondMusic.Play();
    }
}

