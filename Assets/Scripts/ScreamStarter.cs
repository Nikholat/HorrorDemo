using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamStarter : MonoBehaviour
{
    [SerializeField] private Transform screamer;
    [SerializeField] private Transform player;
    [SerializeField] private GameObject dummy;
    [SerializeField] private ScreamTrigger trigger;

    private float speed = 10f;
    void Update()
    {
        screamer.LookAt(player);
        screamer.position = Vector3.MoveTowards(screamer.position, player.position, Time.deltaTime * speed);
    }

    public void StartScream()
    {
        dummy.SetActive(true);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Finish"))
        {
           dummy.SetActive(false);
           trigger.DisableTrigger();
           Debug.Log("Finish");
        }
    }
}
