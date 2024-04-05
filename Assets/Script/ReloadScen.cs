using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScen : MonoBehaviour
{
    public void RestartScen()
    {
        SceneManager.LoadScene(0);
    }
        
  
}
