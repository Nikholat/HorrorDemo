using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractDoor : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;
    [SerializeField] private SoundManager soundManager;
    public bool IsEnable { get; private set; }


    public void TurnOn()
    {
        animator.SetBool("IsOpen", true);
        IsEnable = true;
        soundManager.UnlockLockedDoor();
    }

    public void TurnOff()
    {
        animator.SetBool("IsOpen", false);
        IsEnable = false;
        soundManager.UnlockLockedDoor();
    }
}
