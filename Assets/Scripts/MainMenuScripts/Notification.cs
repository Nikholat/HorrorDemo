using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification : MonoBehaviour
{
    [SerializeField] private GameObject notificationGroup;
    [SerializeField] private Transform notification;
    [SerializeField] CanvasGroup background;
    [SerializeField] SoundManager soundManager;

    public void Enable() 
    {
        StartCoroutine(Timer());
    }

     private IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        notificationGroup.SetActive(true);
        background.alpha = 0f;
        background.LeanAlpha(1f, 0.5f);

        notification.localPosition = new Vector3(0, -Screen.height, 0);
        notification.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
        soundManager.Notification();
    }
}
