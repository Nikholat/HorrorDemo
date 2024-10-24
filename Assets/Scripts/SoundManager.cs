using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip breakLightSound;
    [SerializeField] private AudioClip horrorRunning;
    [SerializeField] private AudioClip itsLockedVoice;
    [SerializeField] private AudioClip soundToUnlockDoor;
    [SerializeField] private AudioClip openDoor;
    [SerializeField] private AudioClip jumpscare;
    [SerializeField] private AudioClip notification;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void LightBreak()
    {
        audioSource.PlayOneShot(breakLightSound);
    }

    public void HorrorRunning()
    {
        audioSource.PlayOneShot(horrorRunning);
    }

    public void UnlockLockedDoor()
    {
        audioSource.PlayOneShot(soundToUnlockDoor);
        audioSource.PlayOneShot(itsLockedVoice);
    }

    public void OpenCloseDoor()
    {
        audioSource.PlayOneShot(openDoor);
    }

    public void Jumpscare()
    {
        audioSource.PlayOneShot(jumpscare);
    }

    public void Notification()
    {
        audioSource.PlayOneShot(notification);
    }
}
