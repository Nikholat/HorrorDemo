using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
   public void StartGame()
   {
        SceneManager.LoadScene(1);
   }
}
