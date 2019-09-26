using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransitions : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    void Update()
    {

    }

    IEnumerator LoadScene() // Coroutine so that your transition animation plays through all the way
    {
        transitionAnim.SetTrigger("end");//Begins the selected transition
        yield return new WaitForSeconds(1.5f);// = Thread.Sleep() (in seconds)
        SceneManager.LoadScene(sceneName);// Changes the scene
    }
}
