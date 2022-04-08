using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void LoadGame()
    {
        Application.LoadLevel(1);
    }
    public void ToOptions()
    {
        Application.LoadLevel(3);
    }
    public void ToMain()
    {
        Application.LoadLevel(0);
    }
   public void Exit()
    {
        Application.Quit();
    }
}
