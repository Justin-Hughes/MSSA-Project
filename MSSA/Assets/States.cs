using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu (menuName = "ScriptObjectList")]
public class States : ScriptableObject
{
    

    [TextArea (10, 14)] [SerializeField] string menuDisplayText;/*TextArea defines the size of the text input box in inspector*/
    [SerializeField] States[] nextState;
    public string GetStateText ()
    {
        return menuDisplayText;
    }

    public States[] SelectedMenu()
    {
        return nextState;
    }



}
