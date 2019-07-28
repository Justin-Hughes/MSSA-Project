using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "ScriptObjectList")]
public class ScriptObjectList : ScriptableObject
{

    [TextArea (10, 14)] [SerializeField] string startMenu;/*TextArea defines the size of the text input box in inspector*/
    public string ShowMenu ()
    {
        return startMenu;
    }
}
