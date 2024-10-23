using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueController : MonoBehaviour
{
    [SerializeField] private GameObject clue;
   
    void Start()
    {
        clue.SetActive(false);
    }
    public void ShowClue()
    {
        clue.SetActive(true);
    }

    public void HideClue()
    {
        clue.SetActive(false);
    }
}
