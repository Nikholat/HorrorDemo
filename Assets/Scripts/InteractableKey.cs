using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableKey : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private MainMusic mainMusic;
    [SerializeField] private ScreamTrigger screamTrigger;
    private InputController inputController;
    private ClueController clueController;
    private LightOff lightOff;
    private DummyOff dummyOff;
    private bool playerInTrigger = false;

    private void Awake()
    {
        inputController = GetComponent<InputController>();
        clueController = GetComponent<ClueController>();
        lightOff = GetComponent<LightOff>();
        dummyOff = GetComponent<DummyOff>();
        mainMusic.TurnOnFirst();
    }

     private void Update()
    {
        if (playerInTrigger && inputController.IsEKeyPressed())
        {
            HideKey();
            clueController.HideClue();
            lightOff.OffLight();
            soundManager.LightBreak();
            dummyOff.OffDummy();
            soundManager.HorrorRunning();
            mainMusic.TurnOnSecond();
            screamTrigger.ActiveTrigger();
        }
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

    private void HideKey()
    {
        key.SetActive(false);
    }
}
