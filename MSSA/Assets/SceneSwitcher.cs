using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    public void GoToTankScene()
    {
        SceneManager.LoadScene("Tank Choice");
    }

    public void GoToMapScene()
    {
        SceneManager.LoadScene("Map Selection");
    }

    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScreen");
    }
}
