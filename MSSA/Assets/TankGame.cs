using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankGame : MonoBehaviour
{
    [SerializeField] Text textComponent;// SerializeField creates an editable item for this variable in the Unity Inspector
    [SerializeField] ScriptObjectList startingState;


    ScriptObjectList currentState;

    // Start is called before the first frame update
    void Start ()
    {
        currentState = startingState;
        textComponent.text = currentState.ShowMenu();
    }

    // Update is called once per frame
    void Update ()
    {
    }
}
