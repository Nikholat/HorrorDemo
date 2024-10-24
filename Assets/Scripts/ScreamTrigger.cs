using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class ScreamTrigger : MonoBehaviour
{
    [SerializeField] private ScreamStarter screamStarter;
    [SerializeField] private GameObject screamerTrigger;
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private MainMusic mainMusic;
    [SerializeField] private Notification notification;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            screamStarter.StartScream();
            soundManager.Jumpscare();
            mainMusic.SecondStop();
            notification.Enable();
        }
    }

    public void ActiveTrigger()
    {
        screamerTrigger.SetActive(true);
    }

    public void DisableTrigger()
    {
        screamerTrigger.SetActive(false);
    }
}
