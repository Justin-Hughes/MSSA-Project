using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject test;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (test.activeSelf) { test.SetActive(false); }
            else { test.SetActive(true); }
        }
    }
}
