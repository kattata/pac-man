using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
        
    public void LoadScene(int level)
      { 
         SceneManager.LoadScene(level);
       }

    public void QuitGame() 
        {
            Application.Quit();
        }

    // public void Update() 
    //     {
            
    //     }
}
