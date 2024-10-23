using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractor : MonoBehaviour
{
    private IInteractable interactDoor;
    private InputController inputController;
    private ClueController clueController;
    private bool playerInTrigger = false;
    private bool isOpen;

    private void Update()
    {
        if (playerInTrigger && inputController.IsEKeyPressed())
        {
            Interact();
        }
    }

    private void Awake()
    {
        interactDoor = GetComponent<IInteractable>();
        inputController = GetComponent<InputController>();
        clueController = GetComponent<ClueController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = true;
            clueController.ShowClue();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = false;
            clueController.HideClue();
        }
    }

    private void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            interactDoor.TurnOn();
        }
        else
        {
            interactDoor.TurnOff();
        }
    }
}
