using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransitions : MonoBehaviour
{
    public Animator transitionAnim;
    // scripts must be attached attached to a game object and that game
    // object must be attached to a button in order for the UI to use it

    // make sure transition panels have raycast object unchecked or else it
    // will block UI elements from the mouse.
    public void Coroutine(string x)
    {
        StartCoroutine(Load(x));
    }
    public IEnumerator Load(string sceneName) // Coroutine so that your transition animation plays through all the way
    {
        transitionAnim.SetTrigger("end");//Begins the selected transition
        yield return new WaitForSeconds(1.5f);// = Thread.Sleep() (in seconds)
        SceneManager.LoadScene(sceneName);// Changes the scene
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
