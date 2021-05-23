using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene_loader : MonoBehaviour
{
    // Start is called before the first frame update
   public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
