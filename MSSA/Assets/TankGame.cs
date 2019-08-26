using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TankGame : MonoBehaviour
{
    [SerializeField] Text textComponent;// SerializeField creates an editable item for this variable in the Unity Inspector
    [SerializeField] States startingState; // Creates a block in which to assign an object of States type
    

    States stateControl; // Initializes a new States object called stateControl

    // Start is called before the first frame update
    void Start ()
    {
        stateControl = startingState;
        textComponent.text = stateControl.GetStateText();
    }

    // Update is called once per frame
    void Update ()
    {
        ManageState();

    }
    private void ManageState()
    {
        var currentState = stateControl;
        var nextStates = stateControl.SelectedMenu();
        try
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                stateControl = nextStates[0];
            }
        }
        catch (System.IndexOutOfRangeException)
        {
            stateControl = currentState;
        }


        textComponent.text = stateControl.GetStateText();
    }
}
